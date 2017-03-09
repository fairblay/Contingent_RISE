namespace Contingent_RISE
{
    partial class TransferVUZ
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
            this.mlGroup = new MetroFramework.Controls.MetroLabel();
            this.mlDirectionTraining = new MetroFramework.Controls.MetroLabel();
            this.mlVUZ = new MetroFramework.Controls.MetroLabel();
            this.mgVUZ = new MetroFramework.Controls.MetroGrid();
            this.mcbVUZ = new MetroFramework.Controls.MetroComboBox();
            this.mbOK = new MetroFramework.Controls.MetroButton();
            this.mbCancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtbNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mdtB = new MetroFramework.Controls.MetroDateTime();
            this.mdtSign = new MetroFramework.Controls.MetroDateTime();
            this.mbOpen = new MetroFramework.Controls.MetroButton();
            this.mlScanName = new MetroFramework.Controls.MetroLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mcbGroupIn = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mtbDescription = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mgVUZ)).BeginInit();
            this.SuspendLayout();
            // 
            // mlFIO
            // 
            this.mlFIO.AutoSize = true;
            this.mlFIO.Location = new System.Drawing.Point(29, 85);
            this.mlFIO.Name = "mlFIO";
            this.mlFIO.Size = new System.Drawing.Size(43, 19);
            this.mlFIO.TabIndex = 0;
            this.mlFIO.Text = "ФИО:";
            // 
            // mlGroup
            // 
            this.mlGroup.AutoSize = true;
            this.mlGroup.Location = new System.Drawing.Point(29, 115);
            this.mlGroup.Name = "mlGroup";
            this.mlGroup.Size = new System.Drawing.Size(55, 19);
            this.mlGroup.TabIndex = 1;
            this.mlGroup.Text = "Группа:";
            // 
            // mlDirectionTraining
            // 
            this.mlDirectionTraining.AutoSize = true;
            this.mlDirectionTraining.Location = new System.Drawing.Point(29, 145);
            this.mlDirectionTraining.Name = "mlDirectionTraining";
            this.mlDirectionTraining.Size = new System.Drawing.Size(169, 19);
            this.mlDirectionTraining.TabIndex = 2;
            this.mlDirectionTraining.Text = "Направление подготовки:";
            // 
            // mlVUZ
            // 
            this.mlVUZ.AutoSize = true;
            this.mlVUZ.Location = new System.Drawing.Point(29, 174);
            this.mlVUZ.Name = "mlVUZ";
            this.mlVUZ.Size = new System.Drawing.Size(36, 19);
            this.mlVUZ.TabIndex = 3;
            this.mlVUZ.Text = "ВУЗ:";
            // 
            // mgVUZ
            // 
            this.mgVUZ.AllowUserToResizeRows = false;
            this.mgVUZ.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgVUZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgVUZ.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgVUZ.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgVUZ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgVUZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgVUZ.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgVUZ.EnableHeadersVisualStyles = false;
            this.mgVUZ.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgVUZ.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgVUZ.Location = new System.Drawing.Point(29, 297);
            this.mgVUZ.Name = "mgVUZ";
            this.mgVUZ.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgVUZ.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgVUZ.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgVUZ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgVUZ.Size = new System.Drawing.Size(765, 167);
            this.mgVUZ.TabIndex = 4;
            this.mgVUZ.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgVUZ_RowEnter);
            // 
            // mcbVUZ
            // 
            this.mcbVUZ.DisplayMember = "name";
            this.mcbVUZ.FormattingEnabled = true;
            this.mcbVUZ.ItemHeight = 23;
            this.mcbVUZ.Location = new System.Drawing.Point(123, 171);
            this.mcbVUZ.Name = "mcbVUZ";
            this.mcbVUZ.Size = new System.Drawing.Size(278, 29);
            this.mcbVUZ.TabIndex = 5;
            this.mcbVUZ.UseSelectable = true;
            this.mcbVUZ.ValueMember = "Id";
            this.mcbVUZ.SelectedValueChanged += new System.EventHandler(this.mcbVUZ_SelectedValueChanged);
            // 
            // mbOK
            // 
            this.mbOK.Location = new System.Drawing.Point(555, 660);
            this.mbOK.Name = "mbOK";
            this.mbOK.Size = new System.Drawing.Size(75, 23);
            this.mbOK.TabIndex = 6;
            this.mbOK.Text = "Применить";
            this.mbOK.UseSelectable = true;
            this.mbOK.Click += new System.EventHandler(this.mbOK_Click);
            // 
            // mbCancel
            // 
            this.mbCancel.Location = new System.Drawing.Point(672, 660);
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.Size = new System.Drawing.Size(75, 23);
            this.mbCancel.TabIndex = 7;
            this.mbCancel.Text = "Отменить";
            this.mbCancel.UseSelectable = true;
            this.mbCancel.Click += new System.EventHandler(this.mbCancel_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 214);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "№ Приказа:";
            // 
            // mtbNumber
            // 
            // 
            // 
            // 
            this.mtbNumber.CustomButton.Image = null;
            this.mtbNumber.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.mtbNumber.CustomButton.Name = "";
            this.mtbNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbNumber.CustomButton.TabIndex = 1;
            this.mtbNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbNumber.CustomButton.UseSelectable = true;
            this.mtbNumber.CustomButton.Visible = false;
            this.mtbNumber.Lines = new string[0];
            this.mtbNumber.Location = new System.Drawing.Point(123, 213);
            this.mtbNumber.MaxLength = 32767;
            this.mtbNumber.Name = "mtbNumber";
            this.mtbNumber.PasswordChar = '\0';
            this.mtbNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbNumber.SelectedText = "";
            this.mtbNumber.SelectionLength = 0;
            this.mtbNumber.SelectionStart = 0;
            this.mtbNumber.Size = new System.Drawing.Size(278, 23);
            this.mtbNumber.TabIndex = 9;
            this.mtbNumber.UseSelectable = true;
            this.mtbNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(407, 174);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(119, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Дата подписания:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(407, 214);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(113, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Дата вступления:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(29, 253);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(42, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Скан:";
            // 
            // mdtB
            // 
            this.mdtB.Location = new System.Drawing.Point(540, 171);
            this.mdtB.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtB.Name = "mdtB";
            this.mdtB.Size = new System.Drawing.Size(227, 29);
            this.mdtB.TabIndex = 12;
            // 
            // mdtSign
            // 
            this.mdtSign.Location = new System.Drawing.Point(540, 210);
            this.mdtSign.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtSign.Name = "mdtSign";
            this.mdtSign.Size = new System.Drawing.Size(227, 29);
            this.mdtSign.TabIndex = 12;
            // 
            // mbOpen
            // 
            this.mbOpen.Location = new System.Drawing.Point(162, 251);
            this.mbOpen.Name = "mbOpen";
            this.mbOpen.Size = new System.Drawing.Size(75, 23);
            this.mbOpen.TabIndex = 13;
            this.mbOpen.Text = "Открыть";
            this.mbOpen.UseSelectable = true;
            this.mbOpen.Click += new System.EventHandler(this.mbOpen_Click);
            // 
            // mlScanName
            // 
            this.mlScanName.AutoSize = true;
            this.mlScanName.Location = new System.Drawing.Point(261, 252);
            this.mlScanName.Name = "mlScanName";
            this.mlScanName.Size = new System.Drawing.Size(104, 19);
            this.mlScanName.TabIndex = 14;
            this.mlScanName.Text = "Выберите файл";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PDF|*.pdf|JPG|*.jpg|Все файлы|*.*";
            // 
            // mcbGroupIn
            // 
            this.mcbGroupIn.DisplayMember = "name";
            this.mcbGroupIn.FormattingEnabled = true;
            this.mcbGroupIn.ItemHeight = 23;
            this.mcbGroupIn.Location = new System.Drawing.Point(162, 470);
            this.mcbGroupIn.Name = "mcbGroupIn";
            this.mcbGroupIn.Size = new System.Drawing.Size(239, 29);
            this.mcbGroupIn.TabIndex = 15;
            this.mcbGroupIn.UseSelectable = true;
            this.mcbGroupIn.ValueMember = "Id";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(29, 472);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(118, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Группа перевода:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(29, 521);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Заметки:";
            // 
            // mtbDescription
            // 
            // 
            // 
            // 
            this.mtbDescription.CustomButton.Image = null;
            this.mtbDescription.CustomButton.Location = new System.Drawing.Point(499, 1);
            this.mtbDescription.CustomButton.Name = "";
            this.mtbDescription.CustomButton.Size = new System.Drawing.Size(105, 105);
            this.mtbDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbDescription.CustomButton.TabIndex = 1;
            this.mtbDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbDescription.CustomButton.UseSelectable = true;
            this.mtbDescription.CustomButton.Visible = false;
            this.mtbDescription.Lines = new string[0];
            this.mtbDescription.Location = new System.Drawing.Point(162, 521);
            this.mtbDescription.MaxLength = 32767;
            this.mtbDescription.Multiline = true;
            this.mtbDescription.Name = "mtbDescription";
            this.mtbDescription.PasswordChar = '\0';
            this.mtbDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbDescription.SelectedText = "";
            this.mtbDescription.SelectionLength = 0;
            this.mtbDescription.SelectionStart = 0;
            this.mtbDescription.Size = new System.Drawing.Size(605, 107);
            this.mtbDescription.TabIndex = 18;
            this.mtbDescription.UseSelectable = true;
            this.mtbDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TransferVUZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 699);
            this.Controls.Add(this.mtbDescription);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.mcbGroupIn);
            this.Controls.Add(this.mlScanName);
            this.Controls.Add(this.mbOpen);
            this.Controls.Add(this.mdtSign);
            this.Controls.Add(this.mdtB);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtbNumber);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.mbOK);
            this.Controls.Add(this.mcbVUZ);
            this.Controls.Add(this.mgVUZ);
            this.Controls.Add(this.mlVUZ);
            this.Controls.Add(this.mlDirectionTraining);
            this.Controls.Add(this.mlGroup);
            this.Controls.Add(this.mlFIO);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferVUZ";
            this.Resizable = false;
            this.Text = "Перевод в ВУЗ";
            ((System.ComponentModel.ISupportInitialize)(this.mgVUZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlFIO;
        private MetroFramework.Controls.MetroLabel mlGroup;
        private MetroFramework.Controls.MetroLabel mlDirectionTraining;
        private MetroFramework.Controls.MetroLabel mlVUZ;
        private MetroFramework.Controls.MetroGrid mgVUZ;
        private MetroFramework.Controls.MetroComboBox mcbVUZ;
        private MetroFramework.Controls.MetroButton mbOK;
        private MetroFramework.Controls.MetroButton mbCancel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtbNumber;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime mdtB;
        private MetroFramework.Controls.MetroDateTime mdtSign;
        private MetroFramework.Controls.MetroButton mbOpen;
        private MetroFramework.Controls.MetroLabel mlScanName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroComboBox mcbGroupIn;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox mtbDescription;
    }
}