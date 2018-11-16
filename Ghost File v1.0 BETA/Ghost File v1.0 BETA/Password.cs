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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
            Controls.Add(new MyMenuStrip
            {
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(20, 20, 20),
                GripStyle = ToolStripGripStyle.Visible
            });
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EnterPassword.Text))
            {
                InputError.Visible = true;
                MessageBox.Show("Please enter your password!");
            }
            else
            { 
            //** CODE FOR PASSWORD LOGIN **//
            if (File.Exists("C:/GhostFile/data.xml"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Information));
                    FileStream read = new FileStream("C:/GhostFile/data.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                    Information info = (Information)xs.Deserialize(read);
                    //enter code if textbox = info.Password; then show main
                    if (EnterPassword.Text == info.Password)
                    {
                        if(!Directory.Exists("C:/GhostFile/Files"))
                        {
                            //** CREATE BATCH FILE TO DIRECTORY **//
                            //** CODE FOR UNLOCK **//

                            StreamWriter swunlock = new StreamWriter("C:/GhostFile/unlockcommand.bat");
                            swunlock.WriteLine(BatUnlock.Text);
                            swunlock.Close();

                            string pathunlock = "C:/GhostFile/unlockcommand.bat"; //Hides Files
                            File.SetAttributes(pathunlock, File.GetAttributes(pathunlock) | FileAttributes.Hidden); // Hides Files

                            //EXECUTE THE UNLOCK BATCH FILE
                            Process proc = null;
                            try
                            {
                                string batDir = string.Format(@"C:\GhostFile\");
                                proc = new Process();
                                proc.StartInfo.WorkingDirectory = batDir;
                                proc.StartInfo.FileName = "unlockcommand.bat";
                                proc.StartInfo.CreateNoWindow = false;
                                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                proc.Start();
                                proc.WaitForExit();
                                File.Delete("C:/GhostFile/unlockcommand.bat");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.StackTrace.ToString());
                            }
                        }
                        //** LAST CODE **//
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                    }
                }
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84) // WM_NCHITTEST
            {
                m.Result = (IntPtr)2; // HTCAPTION
                return;
            }
            base.WndProc(ref m);
        }

        class MyMenuStrip : MenuStrip
        {
            protected override void WndProc(ref Message m)
            {
                if (m.Msg == 0x84) // WM_NCHITTEST
                {
                    m.Result = (IntPtr)(-1); // HTTRANSPARENT
                    return;
                }
                base.WndProc(ref m);
            }
        }

        private void Password_Load(object sender, EventArgs e)
        {
            EnterPassword.PasswordChar = '•';
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            //** PASSWORD CHARACTER AND EYE ICON **//
            if (EnterPassword.PasswordChar == '•')
            {
                EnterPassword.PasswordChar = '\0';
                this.ShowPassword.Image = Properties.Resources.EyeIconX;
            }
            else if (EnterPassword.PasswordChar == '\0')
            {
                EnterPassword.PasswordChar = '•';
                this.ShowPassword.Image = Properties.Resources.EyeIcon;
            }
        }

        private void EnterPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.EnterPassword.Text))
            {
                InputError.Visible = false;
            }
        }
    }
}
