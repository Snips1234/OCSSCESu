using Org.BouncyCastle.Crypto.Operators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using OCSSCESu.Properties;
using OCSSCESu.helper;

namespace OCSSCESu
{
    public partial class FrmVoting : Form
    {
        public FrmVoting()
        {
            InitializeComponent();
        }



        private void CreateCandidate(string name, string id, string yl, Image img)
        {
            UCCandidate _candidate = new UCCandidate()
            {
                Size = new Size((candidateFlowLayout.Width / 3) -10, 126),  
                CandidateName = name,
                CandidateId = id,
                CandidateYearLevel= yl,
                CandidateImage = img

            };

            candidateFlowLayout.Controls.Add(_candidate);
        }
        private void FrmVoting_Load(object sender, EventArgs e)
        {
            foreach(DataRow candidate in AppState.Instance.CandidatesTable.Rows)
            {

                CreateCandidate(candidate["candidate_full_name"].ToString(), candidate["candidate_id"].ToString(), candidate["candidate_year_level"].ToString(), PublicHelper.Base64ToImage(candidate["candidate_image"].ToString()));
            }

        }


        private async Task DisplayCandidates(string position, string course = "", string year_level = "")
        {
            candidateFlowLayout.Controls.Clear();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
