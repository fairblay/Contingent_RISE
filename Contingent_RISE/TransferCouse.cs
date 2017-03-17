using MetroFramework;
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

namespace Contingent_RISE
{
    public partial class TransferCouse  : MetroFramework.Forms.MetroForm
    {
        string filename = "";
        string Idperson;
        string Idprofiles;
        string Iddoc;
        string coursee, IdVUZ, Idgroup;


        public TransferCouse()
        {
            InitializeComponent();



            mcbVUZ.DataSource = Data.CreateDataAdapter("SELECT Id, name FROM VUZ");
            
        }


        private void mbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void mcbVUZ_SelectedValueChanged(object sender, EventArgs e)
        {
            mcbGroup.DataSource = Data.CreateDataAdapter("SELECT Id, name FROM \"group\" WHERE course<>4 AND course<>6 AND Id_VUZ=" + mcbVUZ.SelectedValue);
        }

        private void mcbGroup_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void mbOk_Click(object sender, EventArgs e)
        {
             
            if (mtbNumDoc.Text != "" && mlScanName.Text != "" && mlScanName.Text != " " && mlScanName.Text != "Выберите файл")
            {
                string strb = String.Format("{0: yyyy-MM-dd}", mdtB.Value);
                string strs = String.Format("{0: yyyy-MM-dd}", mdtSign.Value);
                using (SqlConnection con = new SqlConnection(Data.connection))
                {
                    Data.CreateCommand("INSERT INTO document(name, typeDocument, number, dateDocument, dateStart, scan, \"description\") VALUES ('Приказ №" + mtbNumDoc.Text + " от " + mdtB.Text + "','Приказ', '" + mtbNumDoc.Text + "','" + strs + "','" + strb + "','" + mlScanName.Text + "','" + mtbDescription.Text + "')");
                    Data.CreateCommand("UPDATE \"group\" SET course = course+1 WHERE Id=" + mcbGroup.SelectedValue);

                    //ВЫБОРКА СПИСКА ГРУППЫ
                    SqlCommand comm = new SqlCommand("SELECT Id_person, MAX(Id_document) as last_doc FROM student WHERE Id_group=" + mcbGroup.SelectedValue + " GROUP BY Id_person", con);
                    comm.Connection.Open();
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        Data.CreateCommand("INSERT INTO student VALUES (" + reader[0].ToString() + ",(SELECT MAX(Id) FROM document)," + mcbGroup.SelectedValue + ", (SELECT course FROM \"group\" WHERE Id=" + mcbGroup.SelectedValue + "), 2, (SELECT Id_profiles FROM \"group\" WHERE Id=" + mcbGroup.SelectedValue + "))");
                        //MessageBox.Show("INSERT INTO student VALUES ("+ reader[0].ToString()+",(SELECT MAX(Id) FROM document),"+mcbGroup.SelectedValue+", (SELECT course FROM \"group\" WHERE Id="+mcbGroup.SelectedValue+"), 2, (SELECT Id_profiles FROM \"group\" WHERE Id="+mcbGroup.SelectedValue+"))");
                    }

                    Close();
                }
            }
            else MetroMessageBox.Show(this, "Заполните все поля данными", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void mbOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.SafeFileName;
            mlScanName.Text = filename;
        }
    }
}
