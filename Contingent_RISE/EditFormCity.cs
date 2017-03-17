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
    public partial class EditFormCity : MetroForm
    {
        string oldid;
        public EditFormCity(string name, string id)
        {
            
            InitializeComponent();
            mtbCity.Text = name;
            oldid = id;
        }
        public EditFormCity()
        {
            InitializeComponent();
            this.Text = "Добавление (Города)";
            mbEdit.Text = "Добавить";
        }

        private void mbEdit_Click(object sender, EventArgs e)
        {
            if (mtbCity.Text != "")
            {
                if (mbEdit.Text == "Изменить")
                {
                    //MessageBox.Show("UPDATE city SET name='" + mtbCity.Text + "' WHERE Id=" + oldid);
                    DialogResult result;
                    result = MetroMessageBox.Show(this, "Вы уверены?", "Изменить город", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                        Data.CreateCommand("UPDATE city SET name='" + mtbCity.Text + "' WHERE Id=" + oldid);
                }
                else
                {
                    DialogResult result1;
                    result1 = MetroMessageBox.Show(this, "Вы уверены?", "Добавить город", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result1 == DialogResult.OK)
                        Data.CreateCommand("INSERT INTO city(name) VALUES ('" + mtbCity.Text + "')");
                    // MessageBox.Show("INSERT INTO city(name) VALUES ('" + mtbCity.Text + "')");
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
