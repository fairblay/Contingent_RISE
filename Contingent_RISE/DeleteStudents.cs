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
        string coursee, Idgroup, IdStudent;

        public DeleteStudents(string FIO, string Id_person, string Id_profiles, string Id_doc, string Course, string Id_group, string Id_student)
        {
            InitializeComponent();
            mlFIO.Text += FIO;
            Idperson = Id_person;
            Idprofiles = Id_profiles;
            Iddoc = Id_doc;
            coursee = Course;
            Idgroup = Id_group;
            IdStudent = Id_student;


            mgDelete.DataSource = Data.CreateDataAdapter("SELECT studentVUZ.Id, Id_person, Id_group, VUZ.name as 'ВУЗ', directionTraining.name as 'Направление в ВУЗе', qulifyLevel.name as 'Квалификационный уровень', \"form\".name as 'Форма обучения', profiles.name as 'Профиль', \"group\".name as 'Группа', \"group\".course as 'Курс', studentVUZ.Id_VUZ, profiles.Id FROM studentVUZ INNER JOIN \"group\" ON studentVUZ.Id_group = \"group\".Id INNER JOIN VUZ ON studentVUZ.Id_VUZ = VUZ.Id INNER JOIN profiles ON \"group\".Id_profiles = profiles.Id INNER JOIN \"form\" ON profiles.Id_form = \"form\".Id INNER JOIN qulifyLevel ON profiles.Id_qulifyLevel = qulifyLevel.Id INNER JOIN direction ON profiles.Id_direction = direction.Id INNER JOIN directionTraining ON direction.Id_directionTraining = directionTraining.Id WHERE Id_person = " + IdStudent);
            mgDelete.Columns[0].Visible = false;
            mgDelete.Columns[1].Visible = false;
            mgDelete.Columns[2].Visible = false;
            mgDelete.Columns[10].Visible = false;
            mgDelete.Columns[11].Visible = false;

            mgDelete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
            Data.CreateCommand("INSERT INTO student(Id_person, Id_document, Id_group, course, Id_statusStudent, Id_profiles) VALUES('" + Idperson + "', (SELECT MAX(Id) FROM document), '" + mgDelete[2, mgDelete.CurrentCell.RowIndex].Value.ToString() + "', '" + mgDelete[9, mgDelete.CurrentCell.RowIndex].Value.ToString() + "', '1', (SELECT Id_profiles FROM \"group\" WHERE Id = " + mgDelete[2, mgDelete.CurrentCell.RowIndex].Value.ToString() + "))"); Close();
            }
            else MetroMessageBox.Show(this, "Заполните все поля данными", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void mbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
