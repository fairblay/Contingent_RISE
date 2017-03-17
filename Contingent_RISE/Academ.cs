using MetroFramework;
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
    public partial class Academ : MetroFramework.Forms.MetroForm
    {
        string filename = "";
        string Idperson;
        string Idprofiles;
        string Iddoc;
        string coursee, Idstatus, IdVUZ, Idgroup;

        int status=0;

        private void mbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mbOk_Click(object sender, EventArgs e)
        {
            if (mtbNumDoc.Text != "" && mlScanName.Text != " " && mlScanName.Text != "" && mlScanName.Text != "Выберите файл")
            {
                if (metroRadioButton1.Checked || metroRadioButton2.Checked)
                {
                    string strb = String.Format("{0: yyyy-MM-dd}", mdtB.Value);
                    string strs = String.Format("{0: yyyy-MM-dd}", mdtSign.Value);
                    statuse();
                    Data.CreateCommand("INSERT INTO document(name, typeDocument, number, dateDocument, dateStart, scan, \"description\") VALUES ('Приказ №" + mtbNumDoc.Text + " от " + mdtB.Text + "','Приказ', '" + mtbNumDoc.Text + "','" + strs + "','" + strb + "','" + mlScanName.Text + "','" + mtbDescription.Text + "')");
                    Data.CreateCommand("INSERT INTO student(Id_person, Id_document, Id_group, course, Id_statusStudent, Id_profiles) VALUES ('" + Idperson + "',(SELECT MAX(Id) FROM document),'" + Idgroup + "','" + coursee + "','" + status + "','" + Idprofiles + "')");

                    Close();
                }
                else MetroMessageBox.Show(this, "Выберите статус", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MetroMessageBox.Show(this, "Заполните все поля данными", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void mbOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.SafeFileName;
            mlScanName.Text = filename;
        }

        public Academ(string FIO, string group, string Id_person, string Id_profiles, string Id_doc, string Course, string Id_status, string Id_VUZ, string Id_group)
        {
            InitializeComponent();
            mlFIO.Text += FIO;
            mlGroup.Text += group;
            Idperson = Id_person;
            Idprofiles = Id_profiles;
            Iddoc = Id_doc;
            coursee = Course;
            Idstatus = Id_status;
            IdVUZ = Id_VUZ;
            Idgroup = Id_group;

           


            }

        private void Academ_Load(object sender, EventArgs e)
        {

        }
        private void statuse()
        {
            if (metroRadioButton1.Checked)
            {  status = 4; }
            else { status = 6; }
        }
    }
}
