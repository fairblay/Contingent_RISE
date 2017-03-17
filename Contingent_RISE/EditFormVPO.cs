using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Data.SqlClient;

namespace Contingent_RISE
{
    public partial class EditFormVPO : MetroForm
    {
        string oldid;
        public EditFormVPO(string Id, string name, string phone, string namecity)
        {
        
            InitializeComponent();
            mtbVPO.Text = name;
            mtbNumberPhone.Text = phone;
            mcbCity.DataSource = Data.CreateDataAdapter("SELECT Id, Name FROM city");
            oldid = Id;
            mcbCity.Text = namecity;

            // SqlDataReader dr;
            //    dr = Data.CreateCommandDataReader("SELECT name, phone, Id_city FROM VUZ WHERE Id=" + Id);
            //   dr.Read();
            //   mtbVPO.Text = dr.GetValue(0).ToString();

        }
        public EditFormVPO()
        {

            InitializeComponent();
            this.Text = "Добавление (ВПО)";
            mbEdit.Text = "Добавить";
            mcbCity.DataSource = Data.CreateDataAdapter("SELECT Id, Name FROM city");
        }
        private void EditFormVPO_Load(object sender, EventArgs e)
        {
            
        }

        private void mbEdit_Click(object sender, EventArgs e)
        {
            if (mtbVPO.Text != "" && mtbNumberPhone.Text != "")
            {
                if (mbEdit.Text == "Изменить")
                {
                    // MessageBox.Show("UPDATE VUZ SET name='" + mtbVPO.Text + "',phone='" + mtbNumberPhone.Text + "',Id_city='" + mcbCity.SelectedValue + "' WHERE Id=" + oldid);
                    DialogResult result;
                    result = MetroMessageBox.Show(this, "Вы уверены?", "Изменить данные о ВУЗе", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                        Data.CreateCommand("UPDATE VUZ SET name='" + mtbVPO.Text + "',phone='" + mtbNumberPhone.Text + "',Id_city='" + mcbCity.SelectedValue + "' WHERE Id=" + oldid);


                }
                else
                {
                    DialogResult result1;
                    result1 = MetroMessageBox.Show(this, "Вы уверены?", "Добавить ВУЗ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result1 == DialogResult.OK)
                        Data.CreateCommand("INSERT INTO VUZ(name,phone,Id_city) VALUES ('" + mtbVPO.Text + "','" + mtbNumberPhone.Text + "','" + mcbCity.SelectedValue + "')");
                    //MessageBox.Show("INSERT INTO VUZ(name,phone,Id_city) VALUES ('" + mtbVPO.Text + "','" + mtbNumberPhone.Text + "','" + mcbCity.SelectedValue + "')");
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
