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
    public partial class DeleteStudents : MetroFramework.Forms.MetroForm
    {
        string filename = "";
        string Idperson;
        string Idprofiles;
        string Iddoc;
        string coursee, Idstatus, Idgroup;

        public DeleteStudents(string FIO, string group, string Id_person, string Id_profiles, string Id_doc, string Course, string Id_group)
        {
            InitializeComponent();
            mlFIO.Text += FIO;
            mlGroup.Text += group;
            Idperson = Id_person;
            Idprofiles = Id_profiles;
            Iddoc = Id_doc;
            coursee = Course;
            Idgroup = Id_group;
        }

        private void DeleteStudents_Load(object sender, EventArgs e)
        {

        }

        private void mbOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.SafeFileName;
            mlScanName.Text = filename;
        }

        private void mbAccept_Click(object sender, EventArgs e)
        {
            if (mtbNumber.Text != "" && mlScanName.Text != " " && mlScanName.Text != "" && mlScanName.Text != "Выберите файл")
            {
            string strb = String.Format("{0: yyyy-MM-dd}", mdtB.Value);
            string strs = String.Format("{0: yyyy-MM-dd}", mdtSign.Value);

            Data.CreateCommand("INSERT INTO document(name, typeDocument, number, dateDocument, dateStart, scan, \"description\") VALUES ('Приказ №" + mtbNumber.Text + " от " + mdtB.Text + "','Приказ', '" + mtbNumber.Text + "','" + strs + "','" + strb + "','" + mlScanName.Text + "','" + mtbDescription.Text + "')");
            Data.CreateCommand("INSERT INTO student(Id_person, Id_document, Id_group, course, Id_statusStudent, Id_profiles) VALUES ('" + Idperson + "',(SELECT MAX(Id) FROM document),'" + Idgroup + "','" + coursee + "','1','" + Idprofiles + "')");
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
