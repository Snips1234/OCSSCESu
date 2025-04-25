using OCSSCESu.helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCSSCESu
{
    public partial class FrmVoting : Form
    {
        private string[] votingSequence = {
            "Representative",
            "President",
            "Vice President for Internal Affairs",
            "Vice President for External Affairs",
            "Secretary for Internal Affairs",
            "Secretary for External Affairs",
            "Treasurer",
            "Auditor",
            "Business Manager",
            "Public Relation Officer"
        };

        private int currentPhase = 0;
        private string SelectedCandidateId;
        private string _studentId, _course, _yearLevel;
        private DataRow voteRow;
        private Dictionary<string, string> positionSelections = new Dictionary<string, string>();

        public FrmVoting(string studentId, string course, string yearLevel, string currentSelection = "", string previousSelection = "")
        {
            InitializeComponent();
            _studentId = studentId;
            _course = course;
            _yearLevel = yearLevel;

            voteRow = AppState.Instance.BallotTable.NewRow();
            voteRow["studentId"] = studentId;
            voteRow["course"] = course;
            voteRow["yearLevel"] = yearLevel;
        }

        private void FrmVoting_Load(object sender, EventArgs e)
        {
            LoadCurrentPhase();
        }

        private bool isInitializing = false;

        private void LoadCurrentPhase()
        {
            isInitializing = true;

            if (currentPhase >= votingSequence.Length)
            {
                // Voting complete - save all selections to BallotTable
                SaveVotesToBallotTable();
                DisplayVoteSummary();
                return;
            }

            string currentPosition = votingSequence[currentPhase];
            currentVotingPhase.Text = currentPosition;

            if (currentPosition != "Representative")
            {
                DisplayCandidates(currentPosition);
                previousButton.Visible = true;
            }
            else
            {
                DisplayCandidates(currentPosition, _course, _yearLevel);
                previousButton.Visible = false;
            }

            // Restore previous selection if it exists
            if (positionSelections.TryGetValue(currentPosition, out var selectedId))
            {
                foreach (UCCandidate c in candidateFlowLayout.Controls)
                {
                    if (c.CandidateId == selectedId)
                    {
                        c.SetCheckedSilent(true);
                        c.BackColor = Color.LightBlue;
                        SelectedCandidateId = selectedId;
                        break;
                    }
                }
            }

            isInitializing = false;
        }

        private void SaveVotesToBallotTable()
        {
            // Create a new row for the ballot
            DataRow newBallot = AppState.Instance.BallotTable.NewRow();

            // Set student information
            newBallot["studentId"] = _studentId;
            newBallot["course"] = _course;
            newBallot["yearLevel"] = _yearLevel;

            // Map each position selection to the corresponding column
            foreach (var position in votingSequence)
            {
                if (positionSelections.TryGetValue(position, out var candidateId))
                {
                    string columnName = GetColumnKey(position);
                    newBallot[columnName] = candidateId;
                }
            }

            // Add the completed ballot to the table
            AppState.Instance.BallotTable.Rows.Add(newBallot);

            // Optional: Clear the selections after saving
            //positionSelections.Clear();
        }


        private void DisplayVoteSummary()
        {
            candidateFlowLayout.Controls.Clear();
            currentVotingPhase.Text = "Review Your Votes";

            // Configure flow layout
            candidateFlowLayout.SuspendLayout();
            candidateFlowLayout.AutoScroll = true;
            candidateFlowLayout.WrapContents = false;
            candidateFlowLayout.FlowDirection = FlowDirection.TopDown;

            // Add header
            var summaryHeader = new Label()
            {
                Text = "Your Votes:",
                Font = new Font("Arial", 14, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(0, 10, 0, 20)
            };
            candidateFlowLayout.Controls.Add(summaryHeader);

            // Display each vote
            foreach (var position in votingSequence)
            {
                if (positionSelections.TryGetValue(position, out var candidateId))
                {
                    var candidate = AppState.Instance.CandidatesTable.AsEnumerable()
                        .FirstOrDefault(r => r["candidate_id"].ToString() == candidateId);

                    var panel = new Panel()
                    {
                        Size = new Size(candidateFlowLayout.ClientSize.Width - 30, 80),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.AliceBlue,
                        Margin = new Padding(0, 0, 0, 10)
                    };

                    // Add position and candidate info
                    panel.Controls.Add(new Label()
                    {
                        Text = $"{position}:",
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        Location = new Point(10, 10),
                        AutoSize = true
                    });

                    if (candidate != null)
                    {
                        panel.Controls.Add(new Label()
                        {
                            Text = candidate["candidate_full_name"].ToString(),
                            Font = new Font("Arial", 10),
                            Location = new Point(20, 30),
                            AutoSize = true
                        });

                        panel.Controls.Add(new Label()
                        {
                            Text = $"{candidate["candidate_course"]} - {candidate["candidate_year_level"]}",
                            Font = new Font("Arial", 8),
                            Location = new Point(20, 50),
                            AutoSize = true
                        });
                    }

                    candidateFlowLayout.Controls.Add(panel);
                }
            }

            // Add button panel
            var buttonPanel = new Panel()
            {
                Size = new Size(candidateFlowLayout.ClientSize.Width - 30, 60),
                Margin = new Padding(0, 20, 0, 10)
            };

            // Add Change Vote button
            var changeVoteButton = new Button()
            {
                Text = "Change Vote",
                Size = new Size(150, 40),
                Font = new Font("Arial", 10),
                BackColor = Color.LightGoldenrodYellow,
                Location = new Point(10, 10)
            };
            changeVoteButton.Click += (s, e) => ReturnToVoting();
            buttonPanel.Controls.Add(changeVoteButton);

            // Add Submit button
            var submitButton = new Button()
            {
                Text = "Submit Votes",
                Size = new Size(150, 40),
                Font = new Font("Arial", 10, FontStyle.Bold),
                BackColor = Color.LightGreen,
                Location = new Point(170, 10)
            };
            submitButton.Click += (s, e) => SubmitVotes();
            buttonPanel.Controls.Add(submitButton);

            candidateFlowLayout.Controls.Add(buttonPanel);
            
            candidateFlowLayout.ResumeLayout();
        }

        private void ReturnToVoting()
        {
            candidateFlowLayout.FlowDirection = FlowDirection.LeftToRight;
            currentPhase = 0;
            previousButton.Enabled = true;
            nextButton.Enabled = true;
            LoadCurrentPhase();
        }

        private void SubmitVotes()
        {
            try
            {
                // Save to database
                SaveVotesToDatabase();

                //MessageBox.Show("Your votes have been submitted successfully!", "Success",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error submitting votes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void SaveVotesToDatabase()
        {
            try
            {
                // First save to local BallotTable
                SaveVotesToBallotTable();

                // Get the most recently added ballot (the one we just saved)
                var lastBallot = AppState.Instance.BallotTable.AsEnumerable().Last();

                CRUD crud = new CRUD();
                string query = @"
            INSERT INTO ballotTbl(
                president, 
                VPIA, 
                VPEA, 
                secIA, 
                secEA, 
                treasurer, 
                auditor, 
                BM, 
                PRO, 
                representative)  
            VALUES(
                @president, 
                @VPIA, 
                @VPEA, 
                @secIA, 
                @secEA, 
                @treasurer, 
                @auditor, 
                @BM, 
                @PRO, 
                @representative
            );";

                // Add parameters with null handling
                crud.AddParameters("@president", lastBallot["president_id"] ?? DBNull.Value);
                crud.AddParameters("@VPIA", lastBallot["VPIA_id"] ?? DBNull.Value);
                crud.AddParameters("@VPEA", lastBallot["VPEA_id"] ?? DBNull.Value);
                crud.AddParameters("@secIA", lastBallot["secIA_id"] ?? DBNull.Value);
                crud.AddParameters("@secEA", lastBallot["secEA_id"] ?? DBNull.Value);
                crud.AddParameters("@treasurer", lastBallot["treasurer_id"] ?? DBNull.Value);
                crud.AddParameters("@auditor", lastBallot["auditor_id"] ?? DBNull.Value);
                crud.AddParameters("@BM", lastBallot["BM_id"] ?? DBNull.Value);
                crud.AddParameters("@PRO", lastBallot["PRO_id"] ?? DBNull.Value);
                crud.AddParameters("@representative", lastBallot["representative_id"] ?? DBNull.Value);

                bool result = await Task.Run(() => crud.ExecuteNonQuery(query, true));

                if (result)
                {

                    MarkStudentAsVoted();

                    MessageBox.Show("Your votes have been successfully submitted!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    FrmMockup frmMockUp = new FrmMockup();
                    frmMockUp.Show();
                }
                else
                {
                    MessageBox.Show("Failed to submit votes. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving votes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MarkStudentAsVoted()
        {
            try
            {
                CRUD crud = new CRUD();
                string updateCodeQuery = "UPDATE codeTbl SET codeStatus = 'used' WHERE studentId = @studentId";
                crud.AddParameters("@studentId", _studentId);
                bool dbUpdated = crud.ExecuteNonQuery(updateCodeQuery, true);

                if (dbUpdated)
                {
                    DataRow[] studentRows = AppState.Instance.StudentUniqueCodeTable.Select($"student_id = '{_studentId}'");
                    if (studentRows.Length > 0)
                    {
                        studentRows[0]["student_unique_code_status"] = "used";
                    }
                    else
                    {
                        Debug.WriteLine($"Student {_studentId} not found in StudentUniqueCodeTable");
                    }
                }
                else
                {
                    Debug.WriteLine("Database update failed - not updating local table");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in MarkStudentAsVoted: {ex.Message}");
            }
        }


        private void CreateCandidate(string name, string id, string yl, string course, Image img)
        {
            UCCandidate _candidate = new UCCandidate()
            {
                Size = new Size((candidateFlowLayout.Width / 3) - 10, 126),
                CandidateName = name,
                CandidateId = id,
                CandidateYearLevel = yl,
                CandidateCourse = course,
                CandidateImage = img
            };

            _candidate.CandidateCheckedChanged += (s, e) =>
            {
                if (isInitializing) return;

                var selectedCandidate = (UCCandidate)s;

                foreach (UCCandidate c in candidateFlowLayout.Controls)
                {
                    bool isSelected = (c == selectedCandidate);
                    c.SetCheckedSilent(isSelected);  // This avoids firing CheckedChanged
                    c.BackColor = isSelected ? Color.LightBlue : Color.Silver;

                    if (isSelected)
                        SelectedCandidateId = c.CandidateId;
                }
            };


            candidateFlowLayout.Controls.Add(_candidate);
        }


        private void DisplayCandidates(string position, string course = "", string year_level = "")
        {

            candidateFlowLayout.Controls.Clear();
            SelectedCandidateId = null;

            try
            {
                var filteredData = AppState.Instance.CandidatesTable.AsEnumerable()
                    .Where(r => r["candidate_position"].ToString() == position);

                if (!string.IsNullOrEmpty(course))
                    filteredData = filteredData.Where(r => r["candidate_course"].ToString() == course);

                if (!string.IsNullOrEmpty(year_level))
                    filteredData = filteredData.Where(r => r["candidate_year_level"].ToString() == year_level);

                foreach (var candidate in filteredData)
                {
                    CreateCandidate(
                        candidate["candidate_full_name"].ToString(),
                        candidate["candidate_id"].ToString(),
                        candidate["candidate_year_level"].ToString(),
                        candidate["candidate_course"].ToString(),
                        PublicHelper.Base64ToImage(candidate["candidate_image"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying candidates: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectedCandidateId))
            {
                string currentPosition = votingSequence[currentPhase];

                // Save the selection for this position
                positionSelections[currentPosition] = SelectedCandidateId;

                // Update the vote row
                string columnKey = GetColumnKey(currentPosition);
                voteRow[columnKey] = SelectedCandidateId;

                currentPhase++;
                LoadCurrentPhase();
            }
            else
            {
                MessageBox.Show("Please select a candidate before proceeding.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetColumnKey(string position)
        {
            switch (position.ToLower())
            {
                case "representative":
                    return "representative_id";
                case "president":
                    return "president_id";
                case "vice president for internal affairs":
                    return "VPIA_id";
                case "vice president for external affairs":
                    return "VPEA_id";
                case "secretary for internal affairs":
                    return "secIA_id";
                case "secretary for external affairs":
                    return "secEA_id";
                case "treasurer":
                    return "treasurer_id";
                case "auditor":
                    return "auditor_id";
                case "business manager":
                    return "BM_id";
                case "public relation officer":
                    return "PRO_id";
                default:
                    return "";
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentPhase > 0)
            {
                // Save current selection before going back
                string currentPosition = votingSequence[currentPhase];
                if (!string.IsNullOrEmpty(SelectedCandidateId))
                {
                    positionSelections[currentPosition] = SelectedCandidateId;
                }

                currentPhase--;
                LoadCurrentPhase();
            }
        }
    }
}
