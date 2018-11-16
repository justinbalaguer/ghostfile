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
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
            Controls.Add(new MyMenuStrip
            {
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(20, 20, 20),
                GripStyle = ToolStripGripStyle.Visible
            });
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordText.Text) && string.IsNullOrWhiteSpace(PasswordTextConfirm.Text))
            {
                InputError.Visible = true;
                InputErrorConfirm.Visible = true;
                MessageBox.Show("Please input password!");
            }
            else if (string.IsNullOrWhiteSpace(PasswordText.Text))
            {
                InputError.Visible = true;
                MessageBox.Show("Please input password!");
            }
            else if (string.IsNullOrWhiteSpace(PasswordTextConfirm.Text))
            {
                InputErrorConfirm.Visible = true;
                MessageBox.Show("Please confirm password!");
            }
            else
            {
                //** SAVE PASSWORD TO XML CODE **//
                try
                {
                    if (PasswordTextConfirm.Text == PasswordText.Text)
                    {
                        Information info = new Information();
                        info.Password = PasswordText.Text;
                        SaveXML.SaveData(info, "C:/GhostFile/data.xml");

                        //Hides Files
                        string xml = "C:/GhostFile/data.xml";
                        File.SetAttributes(xml, File.GetAttributes(xml) | FileAttributes.Hidden);

                        Main Menu = new Main();
                        Menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password doesn't match!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            //** PASSWORD CHARACTER AND EYE ICON **//
            if (PasswordText.PasswordChar == '•')
            {
                PasswordText.PasswordChar = '\0';
                this.ShowPassword.Image = Properties.Resources.EyeIconX;
            }
            else if (PasswordText.PasswordChar == '\0')
            {
                PasswordText.PasswordChar = '•';
                this.ShowPassword.Image = Properties.Resources.EyeIcon;
            }  
        }

        private void ShowPasswordConfirm_Click(object sender, EventArgs e)
        {
            //** PASSWORD CHARACTER AND EYE ICON **//
            if (PasswordTextConfirm.PasswordChar == '•')
            {
                PasswordTextConfirm.PasswordChar = '\0';
                this.ShowPasswordConfirm.Image = Properties.Resources.EyeIconX;
            }
            else if (PasswordTextConfirm.PasswordChar == '\0')
            {
                PasswordTextConfirm.PasswordChar = '•';
                this.ShowPasswordConfirm.Image = Properties.Resources.EyeIcon;
            }
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            PasswordText.PasswordChar = '•';
            PasswordTextConfirm.PasswordChar = '•';
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.PasswordText.Text))
            {
                InputError.Visible = false;
            }
        }

        private void PasswordTextConfirm_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.PasswordTextConfirm.Text))
            {
                InputErrorConfirm.Visible = false;
            }
        }
    }
}
