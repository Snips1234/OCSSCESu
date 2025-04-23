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
        public FrmUserAuthentication()
        {
            InitializeComponent();
        }

        private void FrmUserAuthentication_Load(object sender, EventArgs e)
        {
            formShadow.SetShadowForm(this);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
