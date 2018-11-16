namespace Ghost_File_v1._0_BETA
{
    partial class Setup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.PasswordTextConfirm = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.ShowPassword = new System.Windows.Forms.PictureBox();
            this.ShowPasswordConfirm = new System.Windows.Forms.PictureBox();
            this.InputError = new System.Windows.Forms.Label();
            this.InputErrorConfirm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordText
            // 
            this.PasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.Location = new System.Drawing.Point(176, 83);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(165, 27);
            this.PasswordText.TabIndex = 0;
            this.PasswordText.TextChanged += new System.EventHandler(this.PasswordText_TextChanged);
            // 
            // PasswordTextConfirm
            // 
            this.PasswordTextConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextConfirm.Location = new System.Drawing.Point(176, 120);
            this.PasswordTextConfirm.Multiline = true;
            this.PasswordTextConfirm.Name = "PasswordTextConfirm";
            this.PasswordTextConfirm.Size = new System.Drawing.Size(165, 27);
            this.PasswordTextConfirm.TabIndex = 1;
            this.PasswordTextConfirm.TextChanged += new System.EventHandler(this.PasswordTextConfirm_TextChanged);
            // 
            // Submit
            // 
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(207, 164);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(103, 32);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label3.Location = new System.Drawing.Point(12, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ghost File v1.0 BETA";
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(437, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(21, 20);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.Location = new System.Drawing.Point(405, 2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(15, 20);
            this.MinimizeButton.TabIndex = 9;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPassword.Image = global::Ghost_File_v1._0_BETA.Properties.Resources.EyeIcon;
            this.ShowPassword.Location = new System.Drawing.Point(347, 83);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(25, 27);
            this.ShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPassword.TabIndex = 10;
            this.ShowPassword.TabStop = false;
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // ShowPasswordConfirm
            // 
            this.ShowPasswordConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPasswordConfirm.Image = global::Ghost_File_v1._0_BETA.Properties.Resources.EyeIcon;
            this.ShowPasswordConfirm.Location = new System.Drawing.Point(347, 120);
            this.ShowPasswordConfirm.Name = "ShowPasswordConfirm";
            this.ShowPasswordConfirm.Size = new System.Drawing.Size(25, 27);
            this.ShowPasswordConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPasswordConfirm.TabIndex = 11;
            this.ShowPasswordConfirm.TabStop = false;
            this.ShowPasswordConfirm.Click += new System.EventHandler(this.ShowPasswordConfirm_Click);
            // 
            // InputError
            // 
            this.InputError.AutoSize = true;
            this.InputError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputError.ForeColor = System.Drawing.Color.IndianRed;
            this.InputError.Location = new System.Drawing.Point(378, 86);
            this.InputError.Name = "InputError";
            this.InputError.Size = new System.Drawing.Size(17, 24);
            this.InputError.TabIndex = 12;
            this.InputError.Text = "*";
            this.InputError.Visible = false;
            // 
            // InputErrorConfirm
            // 
            this.InputErrorConfirm.AutoSize = true;
            this.InputErrorConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputErrorConfirm.ForeColor = System.Drawing.Color.IndianRed;
            this.InputErrorConfirm.Location = new System.Drawing.Point(378, 123);
            this.InputErrorConfirm.Name = "InputErrorConfirm";
            this.InputErrorConfirm.Size = new System.Drawing.Size(17, 24);
            this.InputErrorConfirm.TabIndex = 13;
            this.InputErrorConfirm.Text = "*";
            this.InputErrorConfirm.Visible = false;
            // 
            // Setup
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(470, 242);
            this.Controls.Add(this.InputErrorConfirm);
            this.Controls.Add(this.InputError);
            this.Controls.Add(this.ShowPasswordConfirm);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.PasswordTextConfirm);
            this.Controls.Add(this.PasswordText);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox PasswordTextConfirm;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.PictureBox ShowPassword;
        private System.Windows.Forms.PictureBox ShowPasswordConfirm;
        private System.Windows.Forms.Label InputError;
        private System.Windows.Forms.Label InputErrorConfirm;
    }
}