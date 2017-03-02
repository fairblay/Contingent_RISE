namespace Contingent_RISE
{
    partial class LoginForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtbLogin = new MetroFramework.Controls.MetroTextBox();
            this.mtbPw = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mbLogin = new MetroFramework.Controls.MetroButton();
            this.mbClose = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(203, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Логин";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(203, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Пароль";
            // 
            // mtbLogin
            // 
            // 
            // 
            // 
            this.mtbLogin.CustomButton.Image = null;
            this.mtbLogin.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.mtbLogin.CustomButton.Name = "";
            this.mtbLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbLogin.CustomButton.TabIndex = 1;
            this.mtbLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbLogin.CustomButton.UseSelectable = true;
            this.mtbLogin.CustomButton.Visible = false;
            this.mtbLogin.Lines = new string[0];
            this.mtbLogin.Location = new System.Drawing.Point(279, 63);
            this.mtbLogin.MaxLength = 32767;
            this.mtbLogin.Name = "mtbLogin";
            this.mtbLogin.PasswordChar = '\0';
            this.mtbLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbLogin.SelectedText = "";
            this.mtbLogin.SelectionLength = 0;
            this.mtbLogin.SelectionStart = 0;
            this.mtbLogin.Size = new System.Drawing.Size(178, 23);
            this.mtbLogin.TabIndex = 1;
            this.mtbLogin.UseSelectable = true;
            this.mtbLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbPw
            // 
            // 
            // 
            // 
            this.mtbPw.CustomButton.Image = null;
            this.mtbPw.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.mtbPw.CustomButton.Name = "";
            this.mtbPw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbPw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbPw.CustomButton.TabIndex = 1;
            this.mtbPw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbPw.CustomButton.UseSelectable = true;
            this.mtbPw.CustomButton.Visible = false;
            this.mtbPw.Lines = new string[0];
            this.mtbPw.Location = new System.Drawing.Point(279, 108);
            this.mtbPw.MaxLength = 32767;
            this.mtbPw.Name = "mtbPw";
            this.mtbPw.PasswordChar = '*';
            this.mtbPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbPw.SelectedText = "";
            this.mtbPw.SelectionLength = 0;
            this.mtbPw.SelectionStart = 0;
            this.mtbPw.Size = new System.Drawing.Size(178, 23);
            this.mtbPw.TabIndex = 2;
            this.mtbPw.UseSelectable = true;
            this.mtbPw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbPw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Contingent_RISE.Properties.Resources.b5cdab07;
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // mbLogin
            // 
            this.mbLogin.Location = new System.Drawing.Point(381, 150);
            this.mbLogin.Name = "mbLogin";
            this.mbLogin.Size = new System.Drawing.Size(75, 23);
            this.mbLogin.TabIndex = 4;
            this.mbLogin.Text = "Войти";
            this.mbLogin.UseSelectable = true;
            this.mbLogin.Click += new System.EventHandler(this.mbLogin_Click);
            // 
            // mbClose
            // 
            this.mbClose.Location = new System.Drawing.Point(381, 185);
            this.mbClose.Name = "mbClose";
            this.mbClose.Size = new System.Drawing.Size(75, 23);
            this.mbClose.TabIndex = 5;
            this.mbClose.Text = "Выйти";
            this.mbClose.UseSelectable = true;
            this.mbClose.Click += new System.EventHandler(this.mbClose_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 236);
            this.Controls.Add(this.mbClose);
            this.Controls.Add(this.mbLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtbPw);
            this.Controls.Add(this.mtbLogin);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "Вход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtbLogin;
        private MetroFramework.Controls.MetroTextBox mtbPw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton mbLogin;
        private MetroFramework.Controls.MetroButton mbClose;
    }
}