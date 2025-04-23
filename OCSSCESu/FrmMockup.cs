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
    public partial class FrmMockup : Form
    {
        public FrmMockup()
        {
            InitializeComponent();
        }

        private void FrmMockup_Load(object sender, EventArgs e) 
        {

        }

        private void FrmMockup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.Control && e.KeyCode == Keys.E) 
            {
                FrmConfig frmConfig = new FrmConfig();
                frmConfig.ShowDialog(this);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            FrmUserAuthentication frmAuth = new FrmUserAuthentication();
            frmAuth.ShowDialog(this);
        }
    }
}
