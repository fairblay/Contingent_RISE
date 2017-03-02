namespace Contingent_RISE
{
    partial class EditFormVPO
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtbVPO = new MetroFramework.Controls.MetroTextBox();
            this.mtbNumberPhone = new MetroFramework.Controls.MetroTextBox();
            this.mbEdit = new MetroFramework.Controls.MetroButton();
            this.mcbCity = new MetroFramework.Controls.MetroComboBox();
            this.mbCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Название ВУЗа";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 157);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Номер телефона";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 212);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Город";
            // 
            // mtbVPO
            // 
            // 
            // 
            // 
            this.mtbVPO.CustomButton.Image = null;
            this.mtbVPO.CustomButton.Location = new System.Drawing.Point(273, 1);
            this.mtbVPO.CustomButton.Name = "";
            this.mtbVPO.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbVPO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbVPO.CustomButton.TabIndex = 1;
            this.mtbVPO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbVPO.CustomButton.UseSelectable = true;
            this.mtbVPO.CustomButton.Visible = false;
            this.mtbVPO.Lines = new string[0];
            this.mtbVPO.Location = new System.Drawing.Point(157, 98);
            this.mtbVPO.MaxLength = 32767;
            this.mtbVPO.Name = "mtbVPO";
            this.mtbVPO.PasswordChar = '\0';
            this.mtbVPO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbVPO.SelectedText = "";
            this.mtbVPO.SelectionLength = 0;
            this.mtbVPO.SelectionStart = 0;
            this.mtbVPO.Size = new System.Drawing.Size(295, 23);
            this.mtbVPO.TabIndex = 1;
            this.mtbVPO.UseSelectable = true;
            this.mtbVPO.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbVPO.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbNumberPhone
            // 
            // 
            // 
            // 
            this.mtbNumberPhone.CustomButton.Image = null;
            this.mtbNumberPhone.CustomButton.Location = new System.Drawing.Point(273, 1);
            this.mtbNumberPhone.CustomButton.Name = "";
            this.mtbNumberPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbNumberPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbNumberPhone.CustomButton.TabIndex = 1;
            this.mtbNumberPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbNumberPhone.CustomButton.UseSelectable = true;
            this.mtbNumberPhone.CustomButton.Visible = false;
            this.mtbNumberPhone.Lines = new string[0];
            this.mtbNumberPhone.Location = new System.Drawing.Point(157, 157);
            this.mtbNumberPhone.MaxLength = 32767;
            this.mtbNumberPhone.Name = "mtbNumberPhone";
            this.mtbNumberPhone.PasswordChar = '\0';
            this.mtbNumberPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbNumberPhone.SelectedText = "";
            this.mtbNumberPhone.SelectionLength = 0;
            this.mtbNumberPhone.SelectionStart = 0;
            this.mtbNumberPhone.Size = new System.Drawing.Size(295, 23);
            this.mtbNumberPhone.TabIndex = 2;
            this.mtbNumberPhone.UseSelectable = true;
            this.mtbNumberPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbNumberPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbEdit
            // 
            this.mbEdit.Location = new System.Drawing.Point(377, 270);
            this.mbEdit.Name = "mbEdit";
            this.mbEdit.Size = new System.Drawing.Size(75, 23);
            this.mbEdit.TabIndex = 4;
            this.mbEdit.Text = "Изменить";
            this.mbEdit.UseSelectable = true;
            this.mbEdit.Click += new System.EventHandler(this.mbEdit_Click);
            // 
            // mcbCity
            // 
            this.mcbCity.DisplayMember = "name";
            this.mcbCity.FormattingEnabled = true;
            this.mcbCity.ItemHeight = 23;
            this.mcbCity.Location = new System.Drawing.Point(157, 212);
            this.mcbCity.Name = "mcbCity";
            this.mcbCity.Size = new System.Drawing.Size(295, 29);
            this.mcbCity.TabIndex = 5;
            this.mcbCity.UseSelectable = true;
            this.mcbCity.ValueMember = "Id";
            // 
            // mbCancel
            // 
            this.mbCancel.Location = new System.Drawing.Point(23, 270);
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.Size = new System.Drawing.Size(75, 23);
            this.mbCancel.TabIndex = 6;
            this.mbCancel.Text = "Отмена";
            this.mbCancel.UseSelectable = true;
            this.mbCancel.Click += new System.EventHandler(this.mbCancel_Click);
            // 
            // EditFormVPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 316);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.mcbCity);
            this.Controls.Add(this.mbEdit);
            this.Controls.Add(this.mtbNumberPhone);
            this.Controls.Add(this.mtbVPO);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditFormVPO";
            this.Resizable = false;
            this.Text = "Редактирование (ВПО)";
            this.Load += new System.EventHandler(this.EditFormVPO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtbVPO;
        private MetroFramework.Controls.MetroTextBox mtbNumberPhone;
        private MetroFramework.Controls.MetroButton mbEdit;
        private MetroFramework.Controls.MetroComboBox mcbCity;
        private MetroFramework.Controls.MetroButton mbCancel;
    }
}