﻿namespace Contingent_RISE
{
    partial class TransferCouse
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
            this.mcbVUZ = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mcbGroup = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtbNumDoc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mdtSign = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mdtB = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mbOpen = new MetroFramework.Controls.MetroButton();
            this.mlScanName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.mtbDescription = new MetroFramework.Controls.MetroTextBox();
            this.mbOk = new MetroFramework.Controls.MetroButton();
            this.mbCancel = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ВУЗ:";
            // 
            // mcbVUZ
            // 
            this.mcbVUZ.DisplayMember = "name";
            this.mcbVUZ.FormattingEnabled = true;
            this.mcbVUZ.ItemHeight = 23;
            this.mcbVUZ.Location = new System.Drawing.Point(117, 72);
            this.mcbVUZ.Name = "mcbVUZ";
            this.mcbVUZ.Size = new System.Drawing.Size(265, 29);
            this.mcbVUZ.TabIndex = 1;
            this.mcbVUZ.UseSelectable = true;
            this.mcbVUZ.ValueMember = "Id";
            this.mcbVUZ.SelectedValueChanged += new System.EventHandler(this.mcbVUZ_SelectedValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Группа:";
            // 
            // mcbGroup
            // 
            this.mcbGroup.DisplayMember = "name";
            this.mcbGroup.FormattingEnabled = true;
            this.mcbGroup.ItemHeight = 23;
            this.mcbGroup.Location = new System.Drawing.Point(117, 115);
            this.mcbGroup.Name = "mcbGroup";
            this.mcbGroup.Size = new System.Drawing.Size(265, 29);
            this.mcbGroup.TabIndex = 3;
            this.mcbGroup.UseSelectable = true;
            this.mcbGroup.ValueMember = "Id";
            this.mcbGroup.SelectedValueChanged += new System.EventHandler(this.mcbGroup_SelectedValueChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 159);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "№ приказа:";
            // 
            // mtbNumDoc
            // 
            // 
            // 
            // 
            this.mtbNumDoc.CustomButton.Image = null;
            this.mtbNumDoc.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.mtbNumDoc.CustomButton.Name = "";
            this.mtbNumDoc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbNumDoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbNumDoc.CustomButton.TabIndex = 1;
            this.mtbNumDoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbNumDoc.CustomButton.UseSelectable = true;
            this.mtbNumDoc.CustomButton.Visible = false;
            this.mtbNumDoc.Lines = new string[0];
            this.mtbNumDoc.Location = new System.Drawing.Point(117, 160);
            this.mtbNumDoc.MaxLength = 32767;
            this.mtbNumDoc.Name = "mtbNumDoc";
            this.mtbNumDoc.PasswordChar = '\0';
            this.mtbNumDoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbNumDoc.SelectedText = "";
            this.mtbNumDoc.SelectionLength = 0;
            this.mtbNumDoc.SelectionStart = 0;
            this.mtbNumDoc.Size = new System.Drawing.Size(265, 23);
            this.mtbNumDoc.TabIndex = 5;
            this.mtbNumDoc.UseSelectable = true;
            this.mtbNumDoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbNumDoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 204);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(119, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Дата подписания:";
            // 
            // mdtSign
            // 
            this.mdtSign.Location = new System.Drawing.Point(182, 201);
            this.mdtSign.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtSign.Name = "mdtSign";
            this.mdtSign.Size = new System.Drawing.Size(200, 29);
            this.mdtSign.TabIndex = 7;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 246);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(113, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Дата вступления:";
            // 
            // mdtB
            // 
            this.mdtB.Location = new System.Drawing.Point(182, 241);
            this.mdtB.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtB.Name = "mdtB";
            this.mdtB.Size = new System.Drawing.Size(200, 29);
            this.mdtB.TabIndex = 9;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 286);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(42, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Скан:";
            // 
            // mbOpen
            // 
            this.mbOpen.Location = new System.Drawing.Point(182, 283);
            this.mbOpen.Name = "mbOpen";
            this.mbOpen.Size = new System.Drawing.Size(75, 23);
            this.mbOpen.TabIndex = 11;
            this.mbOpen.Text = "Открыть";
            this.mbOpen.UseSelectable = true;
            this.mbOpen.Click += new System.EventHandler(this.mbOpen_Click);
            // 
            // mlScanName
            // 
            this.mlScanName.AutoSize = true;
            this.mlScanName.Location = new System.Drawing.Point(272, 285);
            this.mlScanName.Name = "mlScanName";
            this.mlScanName.Size = new System.Drawing.Size(104, 19);
            this.mlScanName.TabIndex = 12;
            this.mlScanName.Text = "Выберите файл";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 327);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(62, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Заметки:";
            // 
            // mtbDescription
            // 
            // 
            // 
            // 
            this.mtbDescription.CustomButton.Image = null;
            this.mtbDescription.CustomButton.Location = new System.Drawing.Point(122, 2);
            this.mtbDescription.CustomButton.Name = "";
            this.mtbDescription.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.mtbDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbDescription.CustomButton.TabIndex = 1;
            this.mtbDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbDescription.CustomButton.UseSelectable = true;
            this.mtbDescription.CustomButton.Visible = false;
            this.mtbDescription.Lines = new string[0];
            this.mtbDescription.Location = new System.Drawing.Point(182, 324);
            this.mtbDescription.MaxLength = 32767;
            this.mtbDescription.Multiline = true;
            this.mtbDescription.Name = "mtbDescription";
            this.mtbDescription.PasswordChar = '\0';
            this.mtbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mtbDescription.SelectedText = "";
            this.mtbDescription.SelectionLength = 0;
            this.mtbDescription.SelectionStart = 0;
            this.mtbDescription.Size = new System.Drawing.Size(200, 80);
            this.mtbDescription.TabIndex = 14;
            this.mtbDescription.UseSelectable = true;
            this.mtbDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbOk
            // 
            this.mbOk.Location = new System.Drawing.Point(260, 419);
            this.mbOk.Name = "mbOk";
            this.mbOk.Size = new System.Drawing.Size(75, 23);
            this.mbOk.TabIndex = 15;
            this.mbOk.Text = "Применить";
            this.mbOk.UseSelectable = true;
            this.mbOk.Click += new System.EventHandler(this.mbOk_Click);
            // 
            // mbCancel
            // 
            this.mbCancel.Location = new System.Drawing.Point(352, 419);
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.Size = new System.Drawing.Size(75, 23);
            this.mbCancel.TabIndex = 16;
            this.mbCancel.Text = "Отмена";
            this.mbCancel.UseSelectable = true;
            this.mbCancel.Click += new System.EventHandler(this.mbCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PDF|*.pdf|JPG|*.jpg|Все файлы|*.*";
            // 
            // TransferCouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 454);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.mbOk);
            this.Controls.Add(this.mtbDescription);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.mlScanName);
            this.Controls.Add(this.mbOpen);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.mdtB);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.mdtSign);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mtbNumDoc);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mcbGroup);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mcbVUZ);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferCouse";
            this.Resizable = false;
            this.Text = "Перевод на курс";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox mcbVUZ;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox mcbGroup;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtbNumDoc;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime mdtSign;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime mdtB;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton mbOpen;
        private MetroFramework.Controls.MetroLabel mlScanName;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox mtbDescription;
        private MetroFramework.Controls.MetroButton mbOk;
        private MetroFramework.Controls.MetroButton mbCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}