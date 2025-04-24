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
            FrmVoting frmVoting = new FrmVoting();
            frmVoting.Show();
            this.Close();
            _frmMockup.Close();
            frmVoting.BringToFront();
        }
    }
}
