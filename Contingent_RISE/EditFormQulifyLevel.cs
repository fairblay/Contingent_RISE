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
    public partial class EditFormQulifyLevel : MetroForm
    {
        string oldid;
        public EditFormQulifyLevel(string name, string id)
        {
            InitializeComponent();
            mtbName.Text = name;
            oldid = id;
        }
        public EditFormQulifyLevel()
        {
            InitializeComponent();
            this.Text = "Добавление (Квалификационный уровень)";
            mbAdd.Text = "Добавить";
        }

        private void mbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mbAdd_Click(object sender, EventArgs e)
        {
            if (mtbName.Text != "")
            {
                if (mbAdd.Text == "Изменить")
                {
                    DialogResult result;
                    result = MetroMessageBox.Show(this, "Вы уверены?", "Изменить квалификационный уровень", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                        Data.CreateCommand("UPDATE qulifyLevel SET name='" + mtbName.Text + "' WHERE Id=" + oldid);

                }
                else
                {
                    DialogResult result1;
                    result1 = MetroMessageBox.Show(this, "Вы уверены?", "Добавить квалификационный уровень", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result1 == DialogResult.OK)
                        Data.CreateCommand("INSERT INTO qulifyLevel(name) VALUES ('" + mtbName.Text + "')");

                }

                Close();
            }
            else MetroMessageBox.Show(this, "Заполните все поля данными", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
