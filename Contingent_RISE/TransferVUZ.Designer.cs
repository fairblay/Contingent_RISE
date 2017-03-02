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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mlFIO = new MetroFramework.Controls.MetroLabel();
            this.mlGroup = new MetroFramework.Controls.MetroLabel();
            this.mlDirectionTraining = new MetroFramework.Controls.MetroLabel();
            this.mlVUZ = new MetroFramework.Controls.MetroLabel();
            this.mgVUZ = new MetroFramework.Controls.MetroGrid();
            this.mcbVUZ = new MetroFramework.Controls.MetroComboBox();
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgVUZ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.mgVUZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgVUZ.DefaultCellStyle = dataGridViewCellStyle11;
            this.mgVUZ.EnableHeadersVisualStyles = false;
            this.mgVUZ.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgVUZ.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgVUZ.Location = new System.Drawing.Point(29, 212);
            this.mgVUZ.Name = "mgVUZ";
            this.mgVUZ.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgVUZ.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.mgVUZ.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgVUZ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgVUZ.Size = new System.Drawing.Size(660, 218);
            this.mgVUZ.TabIndex = 4;
            // 
            // mcbVUZ
            // 
            this.mcbVUZ.DisplayMember = "name";
            this.mcbVUZ.FormattingEnabled = true;
            this.mcbVUZ.ItemHeight = 23;
            this.mcbVUZ.Location = new System.Drawing.Point(86, 171);
            this.mcbVUZ.Name = "mcbVUZ";
            this.mcbVUZ.Size = new System.Drawing.Size(315, 29);
            this.mcbVUZ.TabIndex = 5;
            this.mcbVUZ.UseSelectable = true;
            this.mcbVUZ.ValueMember = "Id";
            // 
            // TransferVUZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 453);
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
    }
}