﻿namespace Contingent_RISE
{
    partial class DeleteStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mlFIO = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mlScan = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mdtB = new MetroFramework.Controls.MetroDateTime();
            this.mdtSign = new MetroFramework.Controls.MetroDateTime();
            this.mbOpen = new MetroFramework.Controls.MetroButton();
            this.mtbNumber = new MetroFramework.Controls.MetroTextBox();
            this.mlScanName = new MetroFramework.Controls.MetroLabel();
            this.mtbDescription = new MetroFramework.Controls.MetroTextBox();
            this.mbAccept = new MetroFramework.Controls.MetroButton();
            this.mbCancel = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mgDelete = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.mgDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // mlFIO
            // 
            this.mlFIO.AutoSize = true;
            this.mlFIO.Location = new System.Drawing.Point(35, 72);
            this.mlFIO.Name = "mlFIO";
            this.mlFIO.Size = new System.Drawing.Size(43, 19);
            this.mlFIO.TabIndex = 0;
            this.mlFIO.Text = "ФИО:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 247);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "№ Приказа:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 289);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(119, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Дата подписания:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(35, 326);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(113, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Дата вступления:";
            // 
            // mlScan
            // 
            this.mlScan.AutoSize = true;
            this.mlScan.Location = new System.Drawing.Point(35, 363);
            this.mlScan.Name = "mlScan";
            this.mlScan.Size = new System.Drawing.Size(42, 19);
            this.mlScan.TabIndex = 5;
            this.mlScan.Text = "Скан:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(35, 407);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Заметки:";
            // 
            // mdtB
            // 
            this.mdtB.Location = new System.Drawing.Point(175, 285);
            this.mdtB.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtB.Name = "mdtB";
            this.mdtB.Size = new System.Drawing.Size(538, 29);
            this.mdtB.TabIndex = 7;
            // 
            // mdtSign
            // 
            this.mdtSign.Location = new System.Drawing.Point(175, 322);
            this.mdtSign.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtSign.Name = "mdtSign";
            this.mdtSign.Size = new System.Drawing.Size(538, 29);
            this.mdtSign.TabIndex = 8;
            // 
            // mbOpen
            // 
            this.mbOpen.Location = new System.Drawing.Point(175, 363);
            this.mbOpen.Name = "mbOpen";
            this.mbOpen.Size = new System.Drawing.Size(75, 23);
            this.mbOpen.TabIndex = 9;
            this.mbOpen.Text = "Открыть";
            this.mbOpen.UseSelectable = true;
            this.mbOpen.Click += new System.EventHandler(this.mbOpen_Click);
            // 
            // mtbNumber
            // 
            // 
            // 
            // 
            this.mtbNumber.CustomButton.Image = null;
            this.mtbNumber.CustomButton.Location = new System.Drawing.Point(516, 1);
            this.mtbNumber.CustomButton.Name = "";
            this.mtbNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbNumber.CustomButton.TabIndex = 1;
            this.mtbNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbNumber.CustomButton.UseSelectable = true;
            this.mtbNumber.CustomButton.Visible = false;
            this.mtbNumber.Lines = new string[0];
            this.mtbNumber.Location = new System.Drawing.Point(175, 247);
            this.mtbNumber.MaxLength = 32767;
            this.mtbNumber.Name = "mtbNumber";
            this.mtbNumber.PasswordChar = '\0';
            this.mtbNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbNumber.SelectedText = "";
            this.mtbNumber.SelectionLength = 0;
            this.mtbNumber.SelectionStart = 0;
            this.mtbNumber.Size = new System.Drawing.Size(538, 23);
            this.mtbNumber.TabIndex = 10;
            this.mtbNumber.UseSelectable = true;
            this.mtbNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlScanName
            // 
            this.mlScanName.AutoSize = true;
            this.mlScanName.Location = new System.Drawing.Point(273, 367);
            this.mlScanName.Name = "mlScanName";
            this.mlScanName.Size = new System.Drawing.Size(104, 19);
            this.mlScanName.TabIndex = 11;
            this.mlScanName.Text = "Выберите файл";
            // 
            // mtbDescription
            // 
            // 
            // 
            // 
            this.mtbDescription.CustomButton.Image = null;
            this.mtbDescription.CustomButton.Location = new System.Drawing.Point(476, 2);
            this.mtbDescription.CustomButton.Name = "";
            this.mtbDescription.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.mtbDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbDescription.CustomButton.TabIndex = 1;
            this.mtbDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbDescription.CustomButton.UseSelectable = true;
            this.mtbDescription.CustomButton.Visible = false;
            this.mtbDescription.Lines = new string[0];
            this.mtbDescription.Location = new System.Drawing.Point(175, 407);
            this.mtbDescription.MaxLength = 32767;
            this.mtbDescription.Multiline = true;
            this.mtbDescription.Name = "mtbDescription";
            this.mtbDescription.PasswordChar = '\0';
            this.mtbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mtbDescription.SelectedText = "";
            this.mtbDescription.SelectionLength = 0;
            this.mtbDescription.SelectionStart = 0;
            this.mtbDescription.Size = new System.Drawing.Size(538, 64);
            this.mtbDescription.TabIndex = 12;
            this.mtbDescription.UseSelectable = true;
            this.mtbDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbAccept
            // 
            this.mbAccept.Location = new System.Drawing.Point(529, 494);
            this.mbAccept.Name = "mbAccept";
            this.mbAccept.Size = new System.Drawing.Size(75, 23);
            this.mbAccept.TabIndex = 13;
            this.mbAccept.Text = "Применить";
            this.mbAccept.UseSelectable = true;
            this.mbAccept.Click += new System.EventHandler(this.mbAccept_Click);
            // 
            // mbCancel
            // 
            this.mbCancel.Location = new System.Drawing.Point(636, 494);
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.Size = new System.Drawing.Size(75, 23);
            this.mbCancel.TabIndex = 14;
            this.mbCancel.Text = "Отмена";
            this.mbCancel.UseSelectable = true;
            this.mbCancel.Click += new System.EventHandler(this.mbCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PDF|*.pdf|JPG|*.jpg|Все файлы|*.*";
            // 
            // mgDelete
            // 
            this.mgDelete.AllowUserToResizeRows = false;
            this.mgDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgDelete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgDelete.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgDelete.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgDelete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgDelete.EnableHeadersVisualStyles = false;
            this.mgDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgDelete.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgDelete.Location = new System.Drawing.Point(35, 105);
            this.mgDelete.Name = "mgDelete";
            this.mgDelete.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgDelete.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgDelete.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgDelete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgDelete.Size = new System.Drawing.Size(846, 114);
            this.mgDelete.TabIndex = 15;
            // 
            // DeleteStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 533);
            this.Controls.Add(this.mgDelete);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.mbAccept);
            this.Controls.Add(this.mtbDescription);
            this.Controls.Add(this.mlScanName);
            this.Controls.Add(this.mtbNumber);
            this.Controls.Add(this.mbOpen);
            this.Controls.Add(this.mdtSign);
            this.Controls.Add(this.mdtB);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.mlScan);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mlFIO);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteStudents";
            this.Resizable = false;
            this.Text = "Отчисление студента";
            this.Load += new System.EventHandler(this.DeleteStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlFIO;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel mlScan;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime mdtB;
        private MetroFramework.Controls.MetroDateTime mdtSign;
        private MetroFramework.Controls.MetroButton mbOpen;
        private MetroFramework.Controls.MetroTextBox mtbNumber;
        private MetroFramework.Controls.MetroLabel mlScanName;
        private MetroFramework.Controls.MetroTextBox mtbDescription;
        private MetroFramework.Controls.MetroButton mbAccept;
        private MetroFramework.Controls.MetroButton mbCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroGrid mgDelete;
    }
}