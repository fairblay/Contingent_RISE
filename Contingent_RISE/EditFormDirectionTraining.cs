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
        public EditFormDirectionTraining(string name, string id, string code)
        {
            InitializeComponent();
            mtbName.Text = name;
            oldid = id;
            mtbCode.Text = code;
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
            if (mtbName.Text != "" && mtbCode.Text !="")
            {
                if (mbEdit.Text == "Изменить")
                {
                    DialogResult result;
                    result = MetroMessageBox.Show(this, "Вы уверены?", "Изменить направление подготовки", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                        Data.CreateCommand("UPDATE directionTraining SET name='" + mtbName.Text + "', code='" + mtbCode.Text + "' WHERE Id=" + oldid);
                    //MessageBox.Show("UPDATE directionTraining SET name='" + mtbName.Text + "', code='" + mtbCode.Text + "' WHERE Id=" + oldid);

                }
                else
                {
                    DialogResult result1;
                    result1 = MetroMessageBox.Show(this, "Вы уверены?", "Добавить направление подготовки", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result1 == DialogResult.OK)
                        Data.CreateCommand("INSERT INTO directionTraining(name, code) VALUES ('" + mtbName.Text + "','" + mtbCode.Text + "')");

                }
                Close(); 
            }
            else MetroMessageBox.Show(this, "Заполните все поля данными", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
