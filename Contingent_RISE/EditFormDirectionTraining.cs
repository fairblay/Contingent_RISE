using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contingent_RISE
{
    public partial class EditFormDirectionTraining : MetroForm
    {
        string oldid;
        public EditFormDirectionTraining(string name, string id)
        {
            InitializeComponent();
            mtbName.Text = name;
            oldid = id;
        }
        public EditFormDirectionTraining()
        {
            InitializeComponent();
            this.Text = "Добавление (Направление подготовки)";
            mbEdit.Text = "Добавить";
        }

        private void mbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mbEdit_Click(object sender, EventArgs e)
        {
            if (mbEdit.Text == "Изменить")
            {
                Data.CreateCommand("UPDATE directionTraining SET name='" + mtbName.Text + "' WHERE Id=" + oldid);
                MetroMessageBox.Show(this, "Вы уверены?", "Изменение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else
            {
                Data.CreateCommand("INSERT INTO directionTraining(name) VALUES ('" + mtbName.Text + "')");

            }

            Close();
        }
    }
}
