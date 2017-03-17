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
    public partial class EditFormForm : MetroForm
    {
        string oldid;
        public EditFormForm(string name, string id)
        {
            InitializeComponent();
            mtbName.Text = name;
            oldid = id;
        }
        public EditFormForm()
        {
            InitializeComponent();
            this.Text = "Добавление (Форма обучения)";
            mbEdit.Text = "Добавить";
        }


        private void mbEdit_Click(object sender, EventArgs e)
        {
            if (mtbName.Text != "")
            {
                if (mbEdit.Text == "Изменить")
                {
                    DialogResult result;
                    result = MetroMessageBox.Show(this, "Вы уверены?", "Изменить форму обучения", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                        Data.CreateCommand("UPDATE form SET name='" + mtbName.Text + "' WHERE Id=" + oldid);
                }
                else
                {
                    DialogResult result1;
                    result1 = MetroMessageBox.Show(this, "Вы уверены?", "Добавить форму обучения", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result1 == DialogResult.OK)
                        Data.CreateCommand("INSERT INTO form(name) VALUES ('" + mtbName.Text + "')");

                }

                Close();
            }
            else MetroMessageBox.Show(this, "Заполните все поля данными", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void mbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
