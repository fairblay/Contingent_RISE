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
    public partial class Rename : MetroFramework.Forms.MetroForm
    {
        string filename = "";
        string Idperson;
        string Idprofiles;
        string Iddoc;
        string coursee, Idgroup, oldfio, IdStudent;

        public Rename(string FIO, string Id_person, string Id_profiles, string Id_doc, string Course, string Id_group, string Id_student)
        {
            InitializeComponent();
            mlFIO.Text += FIO;
            mtbNewFIO.Text += FIO;
            Idperson = Id_person;
            Idprofiles = Id_profiles;
            Iddoc = Id_doc;
            coursee = Course;
            Idgroup = Id_group;
            oldfio = FIO;
            IdStudent = Id_student;

            mgRename.DataSource = Data.CreateDataAdapter("SELECT studentVUZ.Id, Id_person, Id_group, VUZ.name as 'ВУЗ', directionTraining.name as 'Направление в ВУЗе', qulifyLevel.name as 'Квалификационный уровень', \"form\".name as 'Форма обучения', profiles.name as 'Профиль', \"group\".name as 'Группа', \"group\".course as 'Курс', studentVUZ.Id_VUZ, profiles.Id FROM studentVUZ INNER JOIN \"group\" ON studentVUZ.Id_group = \"group\".Id INNER JOIN VUZ ON studentVUZ.Id_VUZ = VUZ.Id INNER JOIN profiles ON \"group\".Id_profiles = profiles.Id INNER JOIN \"form\" ON profiles.Id_form = \"form\".Id INNER JOIN qulifyLevel ON profiles.Id_qulifyLevel = qulifyLevel.Id INNER JOIN direction ON profiles.Id_direction = direction.Id INNER JOIN directionTraining ON direction.Id_directionTraining = directionTraining.Id WHERE Id_person = " + IdStudent);
            mgRename.Columns[0].Visible = false;
            mgRename.Columns[1].Visible = false;
            mgRename.Columns[2].Visible = false;
            mgRename.Columns[10].Visible = false;
            mgRename.Columns[11].Visible = false;

        }

        private void mbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mbOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.SafeFileName;
            mlScanName.Text = filename;
        }

        private void mbOk_Click(object sender, EventArgs e)
        {
            if (mtbNumDoc.Text != "" && mlScanName.Text != " " && mlScanName.Text != "" && mlScanName.Text != "Выберите файл")
            {
            string strb = String.Format("{0: yyyy-MM-dd}", mdtB.Value);
            string strs = String.Format("{0: yyyy-MM-dd}", mdtSign.Value);
            Data.CreateCommand("INSERT INTO document(name, typeDocument, number, dateDocument, dateStart, scan, \"description\") VALUES ('Приказ №" + mtbNumDoc.Text + " от " + mdtB.Text + "','Приказ', '" + mtbNumDoc.Text + "','" + strs + "','" + strb + "','" + mlScanName.Text + "','" + oldfio + "')");
            Data.CreateCommand("INSERT INTO student(Id_person, Id_document, Id_group, course, Id_statusStudent, Id_profiles) VALUES('" + Idperson + "', (SELECT MAX(Id) FROM document), '" + mgRename[2, mgRename.CurrentCell.RowIndex].Value.ToString() + "', '" + mgRename[9, mgRename.CurrentCell.RowIndex].Value.ToString() + "', '7', (SELECT Id_profiles FROM \"group\" WHERE Id = " + mgRename[2, mgRename.CurrentCell.RowIndex].Value.ToString() + "))");
            Data.CreateCommand("UPDATE Person SET FIO='"+mtbNewFIO.Text+"' WHERE FIO='"+oldfio+"'");
            //MessageBox.Show(coursee);
            Close();
            }
            else MetroMessageBox.Show(this, "Заполните все поля данными", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
