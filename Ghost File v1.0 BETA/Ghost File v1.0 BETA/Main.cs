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

namespace Ghost_File_v1._0_BETA
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            Controls.Add(new MyMenuStrip { Dock = DockStyle.Top, BackColor = Color.FromArgb(20, 20, 20),
                GripStyle = ToolStripGripStyle.Visible});
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //** LOCK STATUS UPDATE **//
            if (Directory.Exists("C:/GhostFile/Files"))
            {
                LockStatus.Image = Properties.Resources.Unlock;
                Unlock.Enabled = false;
                Lock.Enabled = true;
                OpenFolder.Enabled = true;
            }
            else if (!Directory.Exists("C:/GhostFile/Files"))
            {
                LockStatus.Image = Properties.Resources.Lock;
                Lock.Enabled = false;
                Unlock.Enabled = true;
                OpenFolder.Enabled = false;
            }
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            //** GO TO FOLDER **//
            if (Directory.Exists("C:/GhostFile/Files"))
            {
                Process.Start(@"C:/GhostFile/Files");
            }
            else
            {
                MessageBox.Show("Please Unlock the folder first.");
            }
        }

        private void Unlock_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists("C:/GhostFile/Files"))
            {
                Password EnterPasswordForm = new Password();
                EnterPasswordForm.ShowDialog();
                LockStatus.Image = Properties.Resources.Unlock;
                //** BUTTON CLICKABLE **//
                Unlock.Enabled = false;
                Lock.Enabled = true;
                OpenFolder.Enabled = true;
            }
            else
            {
                MessageBox.Show("Folder is already Unlocked!");
            }
        }

        private void Lock_Click(object sender, EventArgs e)
        {
            if(Directory.Exists("C:/GhostFile/Files"))
            {
                //** CREATE BATCH FILE TO DIRECTORY **//
                //** CODE FOR LOCK **//

                StreamWriter swlock = new StreamWriter("C:/GhostFile/lockcommand.bat");
                swlock.WriteLine(BatLock.Text);
                swlock.Close();

                string pathlock = "C:/GhostFile/lockcommand.bat"; //Hides Files
                File.SetAttributes(pathlock, File.GetAttributes(pathlock) | FileAttributes.Hidden); // Hides Files

                //EXECUTE THE LOCK BATCH FILE
                Process proc = null;
                try
                {
                    string batDir = string.Format(@"C:\GhostFile\");
                    proc = new Process();
                    proc.StartInfo.WorkingDirectory = batDir;
                    proc.StartInfo.FileName = "lockcommand.bat";
                    proc.StartInfo.CreateNoWindow = false;
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.Start();
                    proc.WaitForExit();
                    File.Delete("C:/GhostFile/lockcommand.bat");
                    LockStatus.Image = Properties.Resources.Lock;
                    //** BUTTON CLICKABLE **//
                    Lock.Enabled = false;
                    Unlock.Enabled = true;
                    OpenFolder.Enabled = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace.ToString());
                }
            }
            else
            {
                MessageBox.Show("Folder is already Locked!");
            }
        }

        public void LockStatus_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string target = "http://www.facebook.com/justinbalaguer.i"; 

            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch
                (
                 System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string target = "http://www.instagram.com/justinbalaguer.i";

            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch
                (
                 System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string target = "http://www.twitter.com/justinbalaguer_";

            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch
                (
                 System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string target = "http://www.paypal.me/justinbalaguer";

            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch
                (
                 System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists("C:/GhostFile/Files"))
                {
                    DialogResult dr = MessageBox.Show("Closing this will Lock your folder. Continue?", "Exit", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        //** CREATE BATCH FILE TO DIRECTORY **//
                        //** CODE FOR LOCK **//

                        StreamWriter swlock = new StreamWriter("C:/GhostFile/lockcommand.bat");
                        swlock.WriteLine(BatLock.Text);
                        swlock.Close();

                        string pathlock = "C:/GhostFile/lockcommand.bat"; //Hides Files
                        File.SetAttributes(pathlock, File.GetAttributes(pathlock) | FileAttributes.Hidden); // Hides Files

                        //EXECUTE THE LOCK BATCH FILE
                        Process proc = null;
                        try
                        {
                            string batDir = string.Format(@"C:\GhostFile\");
                            proc = new Process();
                            proc.StartInfo.WorkingDirectory = batDir;
                            proc.StartInfo.FileName = "lockcommand.bat";
                            proc.StartInfo.CreateNoWindow = false;
                            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            proc.Start();
                            proc.WaitForExit();
                            File.Delete("C:/GhostFile/lockcommand.bat");
                            LockStatus.Image = Properties.Resources.Lock;
                            //** BUTTON CLICKABLE **//
                            Lock.Enabled = false;
                            Unlock.Enabled = true;
                            OpenFolder.Enabled = false;
                            Application.Exit();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.StackTrace.ToString());
                        }
                    }
                    else if (dr == DialogResult.No)
                    {

                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
}
