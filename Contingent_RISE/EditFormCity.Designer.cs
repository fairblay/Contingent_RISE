namespace Contingent_RISE
{
    partial class EditFormCity
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
            this.mbEdit = new MetroFramework.Controls.MetroButton();
            this.mtbCity = new MetroFramework.Controls.MetroTextBox();
            this.mbCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Название города";
            // 
            // mbEdit
            // 
            this.mbEdit.Location = new System.Drawing.Point(251, 170);
            this.mbEdit.Name = "mbEdit";
            this.mbEdit.Size = new System.Drawing.Size(75, 23);
            this.mbEdit.TabIndex = 1;
            this.mbEdit.Text = "Изменить";
            this.mbEdit.UseSelectable = true;
            this.mbEdit.Click += new System.EventHandler(this.mbEdit_Click);
            // 
            // mtbCity
            // 
            // 
            // 
            // 
            this.mtbCity.CustomButton.Image = null;
            this.mtbCity.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.mtbCity.CustomButton.Name = "";
            this.mtbCity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCity.CustomButton.TabIndex = 1;
            this.mtbCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCity.CustomButton.UseSelectable = true;
            this.mtbCity.CustomButton.Visible = false;
            this.mtbCity.Lines = new string[0];
            this.mtbCity.Location = new System.Drawing.Point(144, 102);
            this.mtbCity.MaxLength = 32767;
            this.mtbCity.Name = "mtbCity";
            this.mtbCity.PasswordChar = '\0';
            this.mtbCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCity.SelectedText = "";
            this.mtbCity.SelectionLength = 0;
            this.mtbCity.SelectionStart = 0;
            this.mtbCity.Size = new System.Drawing.Size(182, 23);
            this.mtbCity.TabIndex = 2;
            this.mtbCity.UseSelectable = true;
            this.mtbCity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbCancel
            // 
            this.mbCancel.Location = new System.Drawing.Point(23, 170);
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.Size = new System.Drawing.Size(75, 23);
            this.mbCancel.TabIndex = 3;
            this.mbCancel.Text = "Отмена";
            this.mbCancel.UseSelectable = true;
            this.mbCancel.Click += new System.EventHandler(this.mbCancel_Click);
            // 
            // EditFormCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 216);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.mtbCity);
            this.Controls.Add(this.mbEdit);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditFormCity";
            this.Resizable = false;
            this.Text = "Редактирование (Города)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton mbEdit;
        private MetroFramework.Controls.MetroTextBox mtbCity;
        private MetroFramework.Controls.MetroButton mbCancel;
    }
}