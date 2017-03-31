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
        string coursee, Idstatus, IdVUZ, Idgroup, IdStudent;

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
                      Data.CreateCommand("INSERT INTO student(Id_person, Id_document, Id_group, course, Id_statusStudent, Id_profiles) VALUES('" + Idperson + "', (SELECT MAX(Id) FROM document), '" + mgAcadem[2, mgAcadem.CurrentCell.RowIndex].Value.ToString() + "', '" + mgAcadem[9, mgAcadem.CurrentCell.RowIndex].Value.ToString() + "', '" + status + "', (SELECT Id_profiles FROM \"group\" WHERE Id = " + mgAcadem[2, mgAcadem.CurrentCell.RowIndex].Value.ToString() + "))" );
                   // MessageBox.Show("INSERT INTO student(Id_person, Id_document, Id_group, course, Id_statusStudent, Id_profiles) VALUES('" + Idperson + "', (SELECT MAX(Id) FROM document), '" + mgAcadem[2, mgAcadem.CurrentCell.RowIndex].Value.ToString() + "', '" + mgAcadem[9, mgAcadem.CurrentCell.RowIndex].Value.ToString() + "', '" + status + "', (SELECT Id_profiles FROM \"group\" WHERE Id = " + mgAcadem[2, mgAcadem.CurrentCell.RowIndex].Value.ToString() + ")");
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

        public Academ(string FIO, string Id_person, string Id_profiles, string Id_doc, string Course, string Id_status, string Id_VUZ, string Id_group, string Id_student)
        {
            InitializeComponent();
            mlFIO.Text += FIO;
            Idperson = Id_person;
            Idprofiles = Id_profiles;
            Iddoc = Id_doc;
            coursee = Course;
            Idstatus = Id_status;
            IdVUZ = Id_VUZ;
            Idgroup = Id_group;
            IdStudent = Id_student;

            mgAcadem.DataSource = Data.CreateDataAdapter("SELECT studentVUZ.Id, Id_person, Id_group, VUZ.name as 'ВУЗ', directionTraining.name as 'Направление в ВУЗе', qulifyLevel.name as 'Квалификационный уровень', \"form\".name as 'Форма обучения', profiles.name as 'Профиль', \"group\".name as 'Группа', \"group\".course as 'Курс', studentVUZ.Id_VUZ, profiles.Id FROM studentVUZ INNER JOIN \"group\" ON studentVUZ.Id_group = \"group\".Id INNER JOIN VUZ ON studentVUZ.Id_VUZ = VUZ.Id INNER JOIN profiles ON \"group\".Id_profiles = profiles.Id INNER JOIN \"form\" ON profiles.Id_form = \"form\".Id INNER JOIN qulifyLevel ON profiles.Id_qulifyLevel = qulifyLevel.Id INNER JOIN direction ON profiles.Id_direction = direction.Id INNER JOIN directionTraining ON direction.Id_directionTraining = directionTraining.Id WHERE Id_person = " + IdStudent);
            mgAcadem.Columns[0].Visible = false;
            mgAcadem.Columns[1].Visible = false;
            mgAcadem.Columns[2].Visible = false;
            mgAcadem.Columns[10].Visible = false;
            mgAcadem.Columns[11].Visible = false;

            mgAcadem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }

        private void Academ_Load(object sender, EventArgs e)
        {

        }
        private void statuse()  // Статусы студента по БД
        {
            if (metroRadioButton1.Checked)
            {  status = 4; }
            else { status = 6; }
        }
    }
}
