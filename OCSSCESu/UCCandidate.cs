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
        public event EventHandler CandidateCheckedChanged;
        public Guna.UI2.WinForms.Guna2CustomCheckBox CandidateCheckBox => checkBox;
        private bool suppressEvent = false;


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

        public string CandidateCourse
        {
            get { return courseLabel.Text; }
            set { courseLabel.Text = value; }
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

        public bool CandidateSelected
        {
            get { return checkBox.Checked; }
            set { checkBox.Checked = value; }
        }

        private void on_Click(object sender, EventArgs e)
        {
            this.Click += (s, evt) => checkBox.Checked = true;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Click += (s, evt) => // ✅ fixed
                {
                    checkBox.Checked = true;
                };
            }


        }



        public void SetCheckedSilent(bool value)
        {
            suppressEvent = true;
            checkBox.Checked = value;
            suppressEvent = false;
        }



        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!suppressEvent)
            {
                CandidateCheckedChanged?.Invoke(this, EventArgs.Empty);
            }
        }


    }
}
