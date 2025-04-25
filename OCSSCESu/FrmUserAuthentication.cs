using OCSSCESu.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCSSCESu
{
    public partial class FrmUserAuthentication : Form
    {
        private FrmMockup _frmMockup;
        public FrmUserAuthentication(FrmMockup frmMockup)
        {
            InitializeComponent();
            this._frmMockup = frmMockup;
        }

        private void FrmUserAuthentication_Load(object sender, EventArgs e)
        {
            formShadow.SetShadowForm(this);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(studentIdText.Text) && !String.IsNullOrWhiteSpace(uniqueCodeText.Text))
            {
                string studentId = studentIdText.Text.Trim();
                string studentCode = uniqueCodeText.Text.Trim();

                var match = AppState.Instance.StudentUniqueCodeTable.AsEnumerable()
                    .FirstOrDefault(row =>
                        row["student_id"].ToString() == studentId &&
                        row["student_unique_code"].ToString() == studentCode &&
                        row["student_unique_code_status"].ToString().ToLower() == "unuse"
                    );

                if (match != null)
                {
                    // Extract values from the row
                    string course = match["student_course"].ToString();
                    string yearLevel = match["student_year_level"].ToString();

                    // Pass data to FrmVoting
                    FrmVoting frmVoting = new FrmVoting(studentId, course, yearLevel, "Representative", "Representative");
                    frmVoting.Show();
                    this.Close();
                    _frmMockup.Close();
                    frmVoting.BringToFront();
                }
                else
                {
                    MessageBox.Show("Invalid or already used code.", "CODE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields.", "EMPTY FIELD DETECTED", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


    }
}
