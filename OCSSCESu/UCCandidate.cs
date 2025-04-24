using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OCSSCESu
{
  

    public partial class UCCandidate : UserControl

    {
        //private string _candidateName;
        //private string _candidatePosition;
        //private string _candidateId;
        //private string _candidateYearLevel;
        //private Image _candidateImage;

        public UCCandidate()
        {
            InitializeComponent();
        }

        public string CandidateName
        {
            get { return candidateName.Text; }
            set { candidateName.Text = value; }
        }

        public string CandidateYearLevel
        {
            get { return candidateYearLevel.Text; }
            set { candidateYearLevel.Text = value; }
        }

        public Image CandidateImage
        {
            get { return candidateImage.Image; }
            set { candidateImage.Image = value; }
        }

        public string CandidateId
        {
            get { return candidateId.Text; }
            set { candidateId.Text = value; }
        }

        private void candidateYearLevel_Click(object sender, EventArgs e)
        {
            if(checkBox.Checked)
            {
                checkBox.Checked = false;
            }else
            {
                checkBox.Checked = true;
            }
        }
    }
}
