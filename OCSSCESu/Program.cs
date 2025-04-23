using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OCSSCESu.Properties;
using System.Media;

namespace OCSSCESu
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var port = Settings.Default.port;
            var server = Settings.Default.server;
            var databaseName = Settings.Default.database;
            var username = Settings.Default.username;
            var password = Settings.Default.password;


            if (String.IsNullOrEmpty(port) || String.IsNullOrEmpty(server) || String.IsNullOrEmpty(databaseName) || String.IsNullOrEmpty(username))
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Application failed to open due to a connection failure.", "CONNECTION FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Run(new FrmConfig());
                return;
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmVoting());
        }
    }
}
