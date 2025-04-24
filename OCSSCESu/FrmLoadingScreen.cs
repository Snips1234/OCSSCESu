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
        DataTable candidates = AppState.Instance.CandidatesTable;
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
                                    CONCAT_WS(' ', s.fName, s.mName, s.lName, s.suffix) AS fullName, 
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

                DataTable candidates = await _async_crud.ReadDataAsync(query, false);

                dataRetrieveProgressBar.Minimum = 0;
                dataRetrieveProgressBar.Maximum = candidates.Rows.Count;
                dataRetrieveProgressBar.Value = 0;

                AppState.Instance.CandidatesTable.Rows.Clear();

                if(candidates.Rows.Count > 0)
                {
                    foreach (DataRow row in candidates.Rows)
                    {
                        AppState.Instance.CandidatesTable.Rows.Add(
                           row["candidateId"],
                           row["studentId"],
                           row["fullName"],
                           row["yearLevel"],
                           row["positionName"],
                           row["candidatePic"]
                        );

                        dataRetrieveProgressBar.Value += 1;
                        await Task.Delay(1000);
                    }

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
