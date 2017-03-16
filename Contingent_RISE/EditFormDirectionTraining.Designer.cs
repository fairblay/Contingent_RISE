namespace Contingent_RISE
{
    partial class EditFormDirectionTraining
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
            this.mtbName = new MetroFramework.Controls.MetroTextBox();
            this.mbEdit = new MetroFramework.Controls.MetroButton();
            this.mbCancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtbCode = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 101);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Наименование:";
            // 
            // mtbName
            // 
            // 
            // 
            // 
            this.mtbName.CustomButton.Image = null;
            this.mtbName.CustomButton.Location = new System.Drawing.Point(320, 1);
            this.mtbName.CustomButton.Name = "";
            this.mtbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbName.CustomButton.TabIndex = 1;
            this.mtbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbName.CustomButton.UseSelectable = true;
            this.mtbName.CustomButton.Visible = false;
            this.mtbName.Lines = new string[0];
            this.mtbName.Location = new System.Drawing.Point(146, 101);
            this.mtbName.MaxLength = 32767;
            this.mtbName.Name = "mtbName";
            this.mtbName.PasswordChar = '\0';
            this.mtbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbName.SelectedText = "";
            this.mtbName.SelectionLength = 0;
            this.mtbName.SelectionStart = 0;
            this.mtbName.Size = new System.Drawing.Size(342, 23);
            this.mtbName.TabIndex = 1;
            this.mtbName.UseSelectable = true;
            this.mtbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbEdit
            // 
            this.mbEdit.Location = new System.Drawing.Point(23, 222);
            this.mbEdit.Name = "mbEdit";
            this.mbEdit.Size = new System.Drawing.Size(75, 23);
            this.mbEdit.TabIndex = 2;
            this.mbEdit.Text = "Изменить";
            this.mbEdit.UseSelectable = true;
            this.mbEdit.Click += new System.EventHandler(this.mbEdit_Click);
            // 
            // mbCancel
            // 
            this.mbCancel.Location = new System.Drawing.Point(413, 222);
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.Size = new System.Drawing.Size(75, 23);
            this.mbCancel.TabIndex = 3;
            this.mbCancel.Text = "Отмена";
            this.mbCancel.UseSelectable = true;
            this.mbCancel.Click += new System.EventHandler(this.mbCancel_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Код:";
            // 
            // mtbCode
            // 
            // 
            // 
            // 
            this.mtbCode.CustomButton.Image = null;
            this.mtbCode.CustomButton.Location = new System.Drawing.Point(320, 1);
            this.mtbCode.CustomButton.Name = "";
            this.mtbCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCode.CustomButton.TabIndex = 1;
            this.mtbCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCode.CustomButton.UseSelectable = true;
            this.mtbCode.CustomButton.Visible = false;
            this.mtbCode.Lines = new string[0];
            this.mtbCode.Location = new System.Drawing.Point(146, 146);
            this.mtbCode.MaxLength = 32767;
            this.mtbCode.Name = "mtbCode";
            this.mtbCode.PasswordChar = '\0';
            this.mtbCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCode.SelectedText = "";
            this.mtbCode.SelectionLength = 0;
            this.mtbCode.SelectionStart = 0;
            this.mtbCode.Size = new System.Drawing.Size(342, 23);
            this.mtbCode.TabIndex = 5;
            this.mtbCode.UseSelectable = true;
            this.mtbCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EditFormDirectionTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 268);
            this.Controls.Add(this.mtbCode);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.mbEdit);
            this.Controls.Add(this.mtbName);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditFormDirectionTraining";
            this.Resizable = false;
            this.Text = "Редактирование (Направление подготовки)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtbName;
        private MetroFramework.Controls.MetroButton mbEdit;
        private MetroFramework.Controls.MetroButton mbCancel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtbCode;
    }
}