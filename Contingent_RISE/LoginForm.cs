using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace Contingent_RISE
{
    public partial class LoginForm :MetroForm
    {
        SqlConnection con;
        string server = "labit-1\\sqlexpress";
        string DS = "193.108.39.226/DEVELOPMENT-SER";
        string BD = "RISO";
        

        public LoginForm()
        {

            InitializeComponent();
            this.Select();
            mtbLogin.Text = "test";
        }

        private void mbLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //con = new SqlConnection("Data Source='10.250.253.3,1433';Network Library='DBMSSOCN'; Initial Catalog = 'RISO'; User ID = 'test'; Password = 'T_est';");
                con = new SqlConnection("Server=" + server + ";Database=" + BD + ";uid=" + mtbLogin.Text + ";pwd=" + mtbPw.Text);
                con.Open();
                //MessageBox.Show("Data Source=193.108.39.226,2309;Network Library=DBMSSOCN; Initial Catalog = 'RISO'; User ID = 'test'; Password = 'T_est';");
                // MessageBox.Show("Успешное соединение!", "Соединение с БД", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Data.connection = "Data Source='10.250.253.3,1433';Network Library='DBMSSOCN'; Initial Catalog = 'RISO'; User ID = 'test'; Password = 'T_est';";
                Data.connection = "Server=" + server + ";Database=" + BD + ";uid=" + mtbLogin.Text + ";pwd=" + mtbPw.Text;
                this.Close();
            }
            catch (Exception ex)
            {
               MetroMessageBox.Show(this, ex.Message, "Неправильный логин или пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void mbClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
