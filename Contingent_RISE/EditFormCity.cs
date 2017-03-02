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
            if (mbEdit.Text == "Изменить")
            {
                Data.CreateCommand("UPDATE city SET name='" + mtbCity.Text + "' WHERE Id=" + oldid);
                //MessageBox.Show("UPDATE city SET name='" + mtbCity.Text + "' WHERE Id=" + oldid);

                MetroMessageBox.Show(this, "Вы уверены?", "Изменение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else
            {
                Data.CreateCommand("INSERT INTO city(name) VALUES ('" + mtbCity.Text + "')");
               // MessageBox.Show("INSERT INTO city(name) VALUES ('" + mtbCity.Text + "')");
            }

            Close();
        }

        private void mbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
