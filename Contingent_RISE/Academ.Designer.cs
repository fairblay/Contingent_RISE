﻿namespace Contingent_RISE
{
    partial class Academ
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
            this.mtbNumDoc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mdtSign = new MetroFramework.Controls.MetroDateTime();
            this.mdtB = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mbOpen = new MetroFramework.Controls.MetroButton();
            this.mlScanName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mtbDescription = new MetroFramework.Controls.MetroTextBox();
            this.mbOk = new MetroFramework.Controls.MetroButton();
            this.mbCancel = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.mgAcadem = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.mgAcadem)).BeginInit();
            this.SuspendLayout();
            // 
            // mlFIO
            // 
            this.mlFIO.AutoSize = true;
            this.mlFIO.Location = new System.Drawing.Point(23, 72);
            this.mlFIO.Name = "mlFIO";
            this.mlFIO.Size = new System.Drawing.Size(43, 19);
            this.mlFIO.TabIndex = 0;
            this.mlFIO.Text = "ФИО:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 229);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "№ приказа:";
            // 
            // mtbNumDoc
            // 
            // 
            // 
            // 
            this.mtbNumDoc.CustomButton.Image = null;
            this.mtbNumDoc.CustomButton.Location = new System.Drawing.Point(509, 1);
            this.mtbNumDoc.CustomButton.Name = "";
            this.mtbNumDoc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbNumDoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbNumDoc.CustomButton.TabIndex = 1;
            this.mtbNumDoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbNumDoc.CustomButton.UseSelectable = true;
            this.mtbNumDoc.CustomButton.Visible = false;
            this.mtbNumDoc.Lines = new string[0];
            this.mtbNumDoc.Location = new System.Drawing.Point(157, 229);
            this.mtbNumDoc.MaxLength = 32767;
            this.mtbNumDoc.Name = "mtbNumDoc";
            this.mtbNumDoc.PasswordChar = '\0';
            this.mtbNumDoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbNumDoc.SelectedText = "";
            this.mtbNumDoc.SelectionLength = 0;
            this.mtbNumDoc.SelectionStart = 0;
            this.mtbNumDoc.Size = new System.Drawing.Size(531, 23);
            this.mtbNumDoc.TabIndex = 3;
            this.mtbNumDoc.UseSelectable = true;
            this.mtbNumDoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbNumDoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 270);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(119, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Дата подписания:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 309);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(113, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Дата вступления:";
            // 
            // mdtSign
            // 
            this.mdtSign.Location = new System.Drawing.Point(157, 267);
            this.mdtSign.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtSign.Name = "mdtSign";
            this.mdtSign.Size = new System.Drawing.Size(531, 29);
            this.mdtSign.TabIndex = 5;
            // 
            // mdtB
            // 
            this.mdtB.Location = new System.Drawing.Point(157, 306);
            this.mdtB.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtB.Name = "mdtB";
            this.mdtB.Size = new System.Drawing.Size(531, 29);
            this.mdtB.TabIndex = 6;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 358);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(42, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Скан:";
            // 
            // mbOpen
            // 
            this.mbOpen.Location = new System.Drawing.Point(157, 356);
            this.mbOpen.Name = "mbOpen";
            this.mbOpen.Size = new System.Drawing.Size(75, 23);
            this.mbOpen.TabIndex = 8;
            this.mbOpen.Text = "Открыть";
            this.mbOpen.UseSelectable = true;
            this.mbOpen.Click += new System.EventHandler(this.mbOpen_Click);
            // 
            // mlScanName
            // 
            this.mlScanName.AutoSize = true;
            this.mlScanName.Location = new System.Drawing.Point(253, 357);
            this.mlScanName.Name = "mlScanName";
            this.mlScanName.Size = new System.Drawing.Size(104, 19);
            this.mlScanName.TabIndex = 9;
            this.mlScanName.Text = "Выберите файл";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 394);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Статус:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 461);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Заметки:";
            // 
            // mtbDescription
            // 
            // 
            // 
            // 
            this.mtbDescription.CustomButton.Image = null;
            this.mtbDescription.CustomButton.Location = new System.Drawing.Point(457, 2);
            this.mtbDescription.CustomButton.Name = "";
            this.mtbDescription.CustomButton.Size = new System.Drawing.Size(71, 71);
            this.mtbDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbDescription.CustomButton.TabIndex = 1;
            this.mtbDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbDescription.CustomButton.UseSelectable = true;
            this.mtbDescription.CustomButton.Visible = false;
            this.mtbDescription.Lines = new string[0];
            this.mtbDescription.Location = new System.Drawing.Point(157, 461);
            this.mtbDescription.MaxLength = 32767;
            this.mtbDescription.Multiline = true;
            this.mtbDescription.Name = "mtbDescription";
            this.mtbDescription.PasswordChar = '\0';
            this.mtbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mtbDescription.SelectedText = "";
            this.mtbDescription.SelectionLength = 0;
            this.mtbDescription.SelectionStart = 0;
            this.mtbDescription.Size = new System.Drawing.Size(531, 76);
            this.mtbDescription.TabIndex = 14;
            this.mtbDescription.UseSelectable = true;
            this.mtbDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbOk
            // 
            this.mbOk.Location = new System.Drawing.Point(494, 555);
            this.mbOk.Name = "mbOk";
            this.mbOk.Size = new System.Drawing.Size(75, 23);
            this.mbOk.TabIndex = 15;
            this.mbOk.Text = "Применить";
            this.mbOk.UseSelectable = true;
            this.mbOk.Click += new System.EventHandler(this.mbOk_Click);
            // 
            // mbCancel
            // 
            this.mbCancel.Location = new System.Drawing.Point(595, 555);
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.Size = new System.Drawing.Size(75, 23);
            this.mbCancel.TabIndex = 16;
            this.mbCancel.Text = "Отмена";
            this.mbCancel.UseSelectable = true;
            this.mbCancel.Click += new System.EventHandler(this.mbCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = " ";
            this.openFileDialog1.Filter = "PDF|*.pdf|JPG|*.jpg|Все файлы|*.*";
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(155, 398);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(185, 15);
            this.metroRadioButton1.TabIndex = 17;
            this.metroRadioButton1.Text = "Уход в академический отпуск";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(155, 425);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(211, 15);
            this.metroRadioButton2.TabIndex = 18;
            this.metroRadioButton2.Text = "Выход из академического отпуска";
            this.metroRadioButton2.UseSelectable = true;
            // 
            // mgAcadem
            // 
            this.mgAcadem.AllowUserToResizeRows = false;
            this.mgAcadem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgAcadem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgAcadem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgAcadem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgAcadem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgAcadem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgAcadem.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgAcadem.EnableHeadersVisualStyles = false;
            this.mgAcadem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgAcadem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgAcadem.Location = new System.Drawing.Point(23, 99);
            this.mgAcadem.Name = "mgAcadem";
            this.mgAcadem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgAcadem.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgAcadem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgAcadem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgAcadem.Size = new System.Drawing.Size(836, 124);
            this.mgAcadem.TabIndex = 19;
            // 
            // Academ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 590);
            this.Controls.Add(this.mgAcadem);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.mbOk);
            this.Controls.Add(this.mtbDescription);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.mlScanName);
            this.Controls.Add(this.mbOpen);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mdtB);
            this.Controls.Add(this.mdtSign);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtbNumDoc);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mlFIO);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Academ";
            this.Resizable = false;
            this.Text = "Академический отпуск";
            this.Load += new System.EventHandler(this.Academ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgAcadem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlFIO;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtbNumDoc;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime mdtSign;
        private MetroFramework.Controls.MetroDateTime mdtB;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton mbOpen;
        private MetroFramework.Controls.MetroLabel mlScanName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox mtbDescription;
        private MetroFramework.Controls.MetroButton mbOk;
        private MetroFramework.Controls.MetroButton mbCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroGrid mgAcadem;
    }
}