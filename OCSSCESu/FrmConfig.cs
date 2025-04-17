using OCSSCESu.helper;
using OCSSCESu.Properties;
using System;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics.Contracts;
using OCSSCESu.Helper;


namespace OCSSCESu
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void DatabaseConfig_Load(object sender, EventArgs e)
        {
            formShadow.SetShadowForm(this);
            portText.Text = Settings.Default.port;
            serverText.Text = Settings.Default.server;
            databaseText.Text = Settings.Default.database;
            usernameText.Text = Settings.Default.username;
            passwordText.Text = Settings.Default.password;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var port = portText.Text;
            var server = serverText.Text;
            var databaseName = databaseText.Text;
            var username = usernameText.Text;
            var password = passwordText.Text;

            if (String.IsNullOrEmpty(port) || String.IsNullOrEmpty(server) || String.IsNullOrEmpty(databaseName) || String.IsNullOrEmpty(username))
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("All field are required.", "EMPTY FIELD DETECTED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                Settings.Default.port = port;
                Settings.Default.server = server;
                Settings.Default.database = databaseName;
                Settings.Default.username = username;
                // encrypt password
                Settings.Default.password = password;

                // Save settings
                Settings.Default.Save();

                var conn = DatabaseHelper.DatabaseConnection();

                try
                {
                    if(conn != null)
                    {
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Configuration successfully saved.", "CONNECTION STABLISHED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SystemSounds.Hand.Play();
                        MessageBox.Show("Failed to stablish connection.", "CONNECTION FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
 
                }
                catch (Exception ex)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show(ex.Message, "CONNECTION FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn?.Close();
                }
              
            }


        }
    }
}
