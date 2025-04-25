using OCSSCESu.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCSSCESu
{
    public partial class FrmLoadingScreen : Form
    {
        CRUD _crud = new CRUD();
        AsyncCRUD _async_crud = new AsyncCRUD();

        public FrmLoadingScreen()
        {
            InitializeComponent();
        }


        private async Task GetAllCandidates()
        {

            try
            {
                string query = @"
                                SELECT 
                                    s.studentId,
                                    s.yearLevel,
                                    s.course,
                                    CONCAT_WS(' ', s.lName, s.fName, s.suffix, s.mName ) AS fullName, 
                                    c.candidateId, 
                                    c.candidatePic, 
                                    p.positionName
                                FROM 
                                    studentInfoTbl s
                                JOIN 
                                    candidateTbl c ON s.studentId = c.studentId
                                JOIN 
                                    positionTbl p ON c.positionId = p.positionId
                                ";

                string studentUniqueCodeQuery = @"SELECT * FROM codeTbl";

                DataTable candidates = await _async_crud.ReadDataAsync(query, false);
                //MessageBox.Show($"Candidates found: {candidates.Rows.Count}", "Debug");
                DataTable studentUniqueCode = await _async_crud.ReadDataAsync(studentUniqueCodeQuery, false);

                dataRetrieveProgressBar.Minimum = 0;
                dataRetrieveProgressBar.Maximum = candidates.Rows.Count + studentUniqueCode.Rows.Count;
                dataRetrieveProgressBar.Value = 0;

                AppState.Instance.CandidatesTable.Rows.Clear();
                AppState.Instance.StudentUniqueCodeTable.Rows.Clear();

                if(candidates.Rows.Count > 0 && studentUniqueCode.Rows.Count > 0)
                {
                    foreach (DataRow row in candidates.Rows)
                    {
                        AppState.Instance.CandidatesTable.Rows.Add(
                           row["candidateId"],
                           row["studentId"],
                           row["fullName"],
                           row["yearLevel"],
                           row["course"],
                           row["positionName"],
                           row["candidatePic"]
                        );

                        dataRetrieveProgressBar.Value += 1;
                        //await Task.Delay();
                    }

                    foreach (DataRow row in studentUniqueCode.Rows)
                    {
                        AppState.Instance.StudentUniqueCodeTable.Rows.Add(
                           row["studentId"],
                           row["fullName"],
                           row["yearLevel"],
                           row["course"],
                           row["uniqueCode"],
                           row["codeStatus"]
                        );

                        dataRetrieveProgressBar.Value += 1;
                        await Task.Delay(10);
                    }

                    //MessageBox.Show($"Candidates found: {candidates.Rows.Count}", "Debug");

                    FrmMockup frmMockup = new FrmMockup();
                    frmMockup.Show();
                    this.Hide();
                    frmMockup.BringToFront();
                }
              
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error loading candidates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FrmLoadingScreen_Load(object sender, EventArgs e)
        {
          await  GetAllCandidates();
        }
    }
}
