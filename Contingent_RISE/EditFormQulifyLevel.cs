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
            if (mbAdd.Text == "Изменить")
            {
                Data.CreateCommand("UPDATE qulifyLevel SET name='" + mtbName.Text + "' WHERE Id=" + oldid);
                MetroMessageBox.Show(this, "Вы уверены?", "Изменение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else
            {
                Data.CreateCommand("INSERT INTO qulifyLevel(name) VALUES ('" + mtbName.Text + "')");
                
            }

            Close();
        }
    }
}
