namespace Contingent_RISE
{
    partial class Rename
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtbNumDoc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mdtSign = new MetroFramework.Controls.MetroDateTime();
            this.mdtB = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mbOpen = new MetroFramework.Controls.MetroButton();
            this.mlScanName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mtbNewFIO = new MetroFramework.Controls.MetroTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mbOk = new MetroFramework.Controls.MetroButton();
            this.mbCancel = new MetroFramework.Controls.MetroButton();
            this.mgRename = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.mgRename)).BeginInit();
            this.SuspendLayout();
            // 
            // mlFIO
            // 
            this.mlFIO.AutoSize = true;
            this.mlFIO.Location = new System.Drawing.Point(23, 65);
            this.mlFIO.Name = "mlFIO";
            this.mlFIO.Size = new System.Drawing.Size(98, 19);
            this.mlFIO.TabIndex = 0;
            this.mlFIO.Text = "Текущее ФИО:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 217);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "№ приказа:";
            // 
            // mtbNumDoc
            // 
            // 
            // 
            // 
            this.mtbNumDoc.CustomButton.Image = null;
            this.mtbNumDoc.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.mtbNumDoc.CustomButton.Name = "";
            this.mtbNumDoc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbNumDoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbNumDoc.CustomButton.TabIndex = 1;
            this.mtbNumDoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbNumDoc.CustomButton.UseSelectable = true;
            this.mtbNumDoc.CustomButton.Visible = false;
            this.mtbNumDoc.Lines = new string[0];
            this.mtbNumDoc.Location = new System.Drawing.Point(147, 216);
            this.mtbNumDoc.MaxLength = 32767;
            this.mtbNumDoc.Name = "mtbNumDoc";
            this.mtbNumDoc.PasswordChar = '\0';
            this.mtbNumDoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbNumDoc.SelectedText = "";
            this.mtbNumDoc.SelectionLength = 0;
            this.mtbNumDoc.SelectionStart = 0;
            this.mtbNumDoc.Size = new System.Drawing.Size(466, 23);
            this.mtbNumDoc.TabIndex = 2;
            this.mtbNumDoc.UseSelectable = true;
            this.mtbNumDoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbNumDoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 284);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Дата вступления:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 255);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(119, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Дата подписания:";
            // 
            // mdtSign
            // 
            this.mdtSign.Location = new System.Drawing.Point(147, 248);
            this.mdtSign.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtSign.Name = "mdtSign";
            this.mdtSign.Size = new System.Drawing.Size(466, 29);
            this.mdtSign.TabIndex = 5;
            // 
            // mdtB
            // 
            this.mdtB.Location = new System.Drawing.Point(147, 283);
            this.mdtB.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtB.Name = "mdtB";
            this.mdtB.Size = new System.Drawing.Size(466, 29);
            this.mdtB.TabIndex = 6;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 329);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(42, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Скан:";
            // 
            // mbOpen
            // 
            this.mbOpen.Location = new System.Drawing.Point(147, 329);
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
            this.mlScanName.Location = new System.Drawing.Point(238, 330);
            this.mlScanName.Name = "mlScanName";
            this.mlScanName.Size = new System.Drawing.Size(104, 19);
            this.mlScanName.TabIndex = 9;
            this.mlScanName.Text = "Выберите файл";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 368);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Новое ФИО:";
            // 
            // mtbNewFIO
            // 
            // 
            // 
            // 
            this.mtbNewFIO.CustomButton.Image = null;
            this.mtbNewFIO.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.mtbNewFIO.CustomButton.Name = "";
            this.mtbNewFIO.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbNewFIO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbNewFIO.CustomButton.TabIndex = 1;
            this.mtbNewFIO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbNewFIO.CustomButton.UseSelectable = true;
            this.mtbNewFIO.CustomButton.Visible = false;
            this.mtbNewFIO.Lines = new string[0];
            this.mtbNewFIO.Location = new System.Drawing.Point(147, 368);
            this.mtbNewFIO.MaxLength = 32767;
            this.mtbNewFIO.Name = "mtbNewFIO";
            this.mtbNewFIO.PasswordChar = '\0';
            this.mtbNewFIO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbNewFIO.SelectedText = "";
            this.mtbNewFIO.SelectionLength = 0;
            this.mtbNewFIO.SelectionStart = 0;
            this.mtbNewFIO.Size = new System.Drawing.Size(466, 23);
            this.mtbNewFIO.TabIndex = 11;
            this.mtbNewFIO.UseSelectable = true;
            this.mtbNewFIO.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbNewFIO.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PDF|*.pdf|JPG|*.jpg|Все файлы|*.*";
            // 
            // mbOk
            // 
            this.mbOk.Location = new System.Drawing.Point(593, 402);
            this.mbOk.Name = "mbOk";
            this.mbOk.Size = new System.Drawing.Size(75, 23);
            this.mbOk.TabIndex = 12;
            this.mbOk.Text = "Применить";
            this.mbOk.UseSelectable = true;
            this.mbOk.Click += new System.EventHandler(this.mbOk_Click);
            // 
            // mbCancel
            // 
            this.mbCancel.Location = new System.Drawing.Point(685, 402);
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.Size = new System.Drawing.Size(75, 23);
            this.mbCancel.TabIndex = 13;
            this.mbCancel.Text = "Отмена";
            this.mbCancel.UseSelectable = true;
            this.mbCancel.Click += new System.EventHandler(this.mbCancel_Click);
            // 
            // mgRename
            // 
            this.mgRename.AllowUserToResizeRows = false;
            this.mgRename.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgRename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgRename.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgRename.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgRename.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgRename.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgRename.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgRename.EnableHeadersVisualStyles = false;
            this.mgRename.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgRename.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgRename.Location = new System.Drawing.Point(23, 94);
            this.mgRename.Name = "mgRename";
            this.mgRename.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgRename.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgRename.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgRename.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgRename.Size = new System.Drawing.Size(771, 105);
            this.mgRename.TabIndex = 14;
            // 
            // Rename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 437);
            this.Controls.Add(this.mgRename);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.mbOk);
            this.Controls.Add(this.mtbNewFIO);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.mlScanName);
            this.Controls.Add(this.mbOpen);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mdtB);
            this.Controls.Add(this.mdtSign);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtbNumDoc);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mlFIO);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rename";
            this.Resizable = false;
            this.Text = "Смена ФИО";
            ((System.ComponentModel.ISupportInitialize)(this.mgRename)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlFIO;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtbNumDoc;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime mdtSign;
        private MetroFramework.Controls.MetroDateTime mdtB;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton mbOpen;
        private MetroFramework.Controls.MetroLabel mlScanName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox mtbNewFIO;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroButton mbOk;
        private MetroFramework.Controls.MetroButton mbCancel;
        private MetroFramework.Controls.MetroGrid mgRename;
    }
}