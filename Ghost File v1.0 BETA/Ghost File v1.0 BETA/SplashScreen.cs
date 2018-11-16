using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Ghost_File_v1._0_BETA
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //** CREATE FOLDER **//

                // Determine whether the directory exists.
                if (Directory.Exists("C:/GhostFile"))
                {
                    progressBar1.Increment(5);
                    if (progressBar1.Value == progressBar1.Maximum)
                    {
                        if (File.Exists("C:/GhostFile/data.xml"))
                        {
                            //GO TO MAIN FORM
                            Main Menu = new Main();
                            Menu.Show();
                            timer1.Stop();
                            this.Hide();
                        }
                        else if (!File.Exists("C:/GhostFile/data.xml"))
                        {
                            //GO TO PASSWORD SETUP
                            Setup PasswordSetup = new Setup();
                            PasswordSetup.Show();
                            timer1.Stop();
                            this.Hide();
                        }
                    }
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory("C:/GhostFile");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                timer1.Stop();
            }
        }
    }
}
