namespace Contingent_RISE
{
    partial class TransferGroup
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
            this.mlFIO = new MetroFramework.Controls.MetroLabel();
            this.mlGroup = new MetroFramework.Controls.MetroLabel();
            this.d1 = new MetroFramework.Controls.MetroLabel();
            this.d2 = new MetroFramework.Controls.MetroLabel();
            this.mdtSign = new MetroFramework.Controls.MetroDateTime();
            this.mdtB = new MetroFramework.Controls.MetroDateTime();
            this.mlScan = new MetroFramework.Controls.MetroLabel();
            this.mbOpen = new MetroFramework.Controls.MetroButton();
            this.mbOk = new MetroFramework.Controls.MetroButton();
            this.mlScanName = new MetroFramework.Controls.MetroLabel();
            this.mbCancel = new MetroFramework.Controls.MetroButton();
            this.mcbGroup = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mtbDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtbNumDoc = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // mlFIO
            // 
            this.mlFIO.AutoSize = true;
            this.mlFIO.Location = new System.Drawing.Point(23, 73);
            this.mlFIO.Name = "mlFIO";
            this.mlFIO.Size = new System.Drawing.Size(47, 19);
            this.mlFIO.TabIndex = 0;
            this.mlFIO.Text = "ФИО: ";
            // 
            // mlGroup
            // 
            this.mlGroup.AutoSize = true;
            this.mlGroup.Location = new System.Drawing.Point(23, 98);
            this.mlGroup.Name = "mlGroup";
            this.mlGroup.Size = new System.Drawing.Size(59, 19);
            this.mlGroup.TabIndex = 1;
            this.mlGroup.Text = "Группа: ";
            // 
            // d1
            // 
            this.d1.AutoSize = true;
            this.d1.Location = new System.Drawing.Point(23, 162);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(123, 19);
            this.d1.TabIndex = 2;
            this.d1.Text = "Дата подписания: ";
            // 
            // d2
            // 
            this.d2.AutoSize = true;
            this.d2.Location = new System.Drawing.Point(23, 196);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(117, 19);
            this.d2.TabIndex = 3;
            this.d2.Text = "Дата вступления: ";
            // 
            // mdtSign
            // 
            this.mdtSign.Location = new System.Drawing.Point(152, 155);
            this.mdtSign.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtSign.Name = "mdtSign";
            this.mdtSign.Size = new System.Drawing.Size(200, 29);
            this.mdtSign.TabIndex = 4;
            // 
            // mdtB
            // 
            this.mdtB.Location = new System.Drawing.Point(152, 192);
            this.mdtB.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtB.Name = "mdtB";
            this.mdtB.Size = new System.Drawing.Size(200, 29);
            this.mdtB.TabIndex = 5;
            // 
            // mlScan
            // 
            this.mlScan.AutoSize = true;
            this.mlScan.Location = new System.Drawing.Point(23, 233);
            this.mlScan.Name = "mlScan";
            this.mlScan.Size = new System.Drawing.Size(46, 19);
            this.mlScan.TabIndex = 6;
            this.mlScan.Text = "Скан: ";
            // 
            // mbOpen
            // 
            this.mbOpen.Location = new System.Drawing.Point(152, 232);
            this.mbOpen.Name = "mbOpen";
            this.mbOpen.Size = new System.Drawing.Size(75, 23);
            this.mbOpen.TabIndex = 7;
            this.mbOpen.Text = "Открыть";
            this.mbOpen.UseSelectable = true;
            this.mbOpen.Click += new System.EventHandler(this.mbOpen_Click);
            // 
            // mbOk
            // 
            this.mbOk.Location = new System.Drawing.Point(254, 408);
            this.mbOk.Name = "mbOk";
            this.mbOk.Size = new System.Drawing.Size(75, 23);
            this.mbOk.TabIndex = 8;
            this.mbOk.Text = "Применить";
            this.mbOk.UseSelectable = true;
            this.mbOk.Click += new System.EventHandler(this.mbOk_Click);
            // 
            // mlScanName
            // 
            this.mlScanName.AutoSize = true;
            this.mlScanName.Location = new System.Drawing.Point(246, 233);
            this.mlScanName.Name = "mlScanName";
            this.mlScanName.Size = new System.Drawing.Size(104, 19);
            this.mlScanName.TabIndex = 9;
            this.mlScanName.Text = "Выберите файл";
            // 
            // mbCancel
            // 
            this.mbCancel.Location = new System.Drawing.Point(354, 408);
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.Size = new System.Drawing.Size(75, 23);
            this.mbCancel.TabIndex = 10;
            this.mbCancel.Text = "Отмена";
            this.mbCancel.UseSelectable = true;
            this.mbCancel.Click += new System.EventHandler(this.mbCancel_Click);
            // 
            // mcbGroup
            // 
            this.mcbGroup.DisplayMember = "name";
            this.mcbGroup.FormattingEnabled = true;
            this.mcbGroup.ItemHeight = 23;
            this.mcbGroup.Location = new System.Drawing.Point(152, 264);
            this.mcbGroup.Name = "mcbGroup";
            this.mcbGroup.Size = new System.Drawing.Size(121, 29);
            this.mcbGroup.TabIndex = 11;
            this.mcbGroup.UseSelectable = true;
            this.mcbGroup.ValueMember = "Id";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 267);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Группа перевода:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = " ";
            this.openFileDialog1.Filter = "PDF|*.pdf|JPG|*.jpg|Все файлы|*.*";
            // 
            // mtbDescription
            // 
            // 
            // 
            // 
            this.mtbDescription.CustomButton.Image = null;
            this.mtbDescription.CustomButton.Location = new System.Drawing.Point(128, 2);
            this.mtbDescription.CustomButton.Name = "";
            this.mtbDescription.CustomButton.Size = new System.Drawing.Size(69, 69);
            this.mtbDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbDescription.CustomButton.TabIndex = 1;
            this.mtbDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbDescription.CustomButton.UseSelectable = true;
            this.mtbDescription.CustomButton.Visible = false;
            this.mtbDescription.Lines = new string[0];
            this.mtbDescription.Location = new System.Drawing.Point(152, 300);
            this.mtbDescription.MaxLength = 32767;
            this.mtbDescription.Multiline = true;
            this.mtbDescription.Name = "mtbDescription";
            this.mtbDescription.PasswordChar = '\0';
            this.mtbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mtbDescription.SelectedText = "";
            this.mtbDescription.SelectionLength = 0;
            this.mtbDescription.SelectionStart = 0;
            this.mtbDescription.Size = new System.Drawing.Size(200, 74);
            this.mtbDescription.TabIndex = 13;
            this.mtbDescription.UseSelectable = true;
            this.mtbDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 300);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Заметки:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 126);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "№ приказа:";
            // 
            // mtbNumDoc
            // 
            // 
            // 
            // 
            this.mtbNumDoc.CustomButton.Image = null;
            this.mtbNumDoc.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.mtbNumDoc.CustomButton.Name = "";
            this.mtbNumDoc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbNumDoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbNumDoc.CustomButton.TabIndex = 1;
            this.mtbNumDoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbNumDoc.CustomButton.UseSelectable = true;
            this.mtbNumDoc.CustomButton.Visible = false;
            this.mtbNumDoc.Lines = new string[0];
            this.mtbNumDoc.Location = new System.Drawing.Point(152, 125);
            this.mtbNumDoc.MaxLength = 32767;
            this.mtbNumDoc.Name = "mtbNumDoc";
            this.mtbNumDoc.PasswordChar = '\0';
            this.mtbNumDoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbNumDoc.SelectedText = "";
            this.mtbNumDoc.SelectionLength = 0;
            this.mtbNumDoc.SelectionStart = 0;
            this.mtbNumDoc.Size = new System.Drawing.Size(200, 23);
            this.mtbNumDoc.TabIndex = 16;
            this.mtbNumDoc.UseSelectable = true;
            this.mtbNumDoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbNumDoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TransferGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 444);
            this.Controls.Add(this.mtbNumDoc);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtbDescription);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mcbGroup);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.mlScanName);
            this.Controls.Add(this.mbOk);
            this.Controls.Add(this.mbOpen);
            this.Controls.Add(this.mlScan);
            this.Controls.Add(this.mdtB);
            this.Controls.Add(this.mdtSign);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.mlGroup);
            this.Controls.Add(this.mlFIO);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferGroup";
            this.Resizable = false;
            this.Text = "Перевод в группу";
            this.Load += new System.EventHandler(this.TransferGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlFIO;
        private MetroFramework.Controls.MetroLabel mlGroup;
        private MetroFramework.Controls.MetroLabel d1;
        private MetroFramework.Controls.MetroLabel d2;
        private MetroFramework.Controls.MetroDateTime mdtSign;
        private MetroFramework.Controls.MetroDateTime mdtB;
        private MetroFramework.Controls.MetroLabel mlScan;
        private MetroFramework.Controls.MetroButton mbOpen;
        private MetroFramework.Controls.MetroButton mbOk;
        private MetroFramework.Controls.MetroLabel mlScanName;
        private MetroFramework.Controls.MetroButton mbCancel;
        private MetroFramework.Controls.MetroComboBox mcbGroup;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroTextBox mtbDescription;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtbNumDoc;
    }
}