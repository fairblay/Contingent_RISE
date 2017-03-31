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
    public partial class TransferVUZ : MetroFramework.Forms.MetroForm
    {

        string filename = "";
        string Idperson;
        string Idprofiles;
        string Iddoc;
        string coursee, Idgroup,IdVUZ, IdStudent;
        int IdprofilesInDg, IdStatusVUZ;

        public TransferVUZ(string FIO, string directionTrainingName,string directionTrCode, string idVUZ, string Id_person, string Id_profiles, string Id_doc, string Course, string Id_group, string Id_VUZ, string Id_Student)
        {
            InitializeComponent();

            Idperson = Id_person;
            Idprofiles = Id_profiles;
            Iddoc = Id_doc;
            coursee = Course;
            Idgroup = Id_group;
            IdVUZ = Id_VUZ;
            IdStudent = Id_Student;
            mcbVUZ.DataSource = Data.CreateDataAdapter("SELECT Id, name FROM VUZ");
            mlFIO.Text += "   "+FIO;
            mgTransV.DataSource = Data.CreateDataAdapter("SELECT studentVUZ.Id, Id_person, Id_group, VUZ.name as 'ВУЗ', directionTraining.name as 'Направление в ВУЗе', qulifyLevel.name as 'Квалификационный уровень', \"form\".name as 'Форма обучения', profiles.name as 'Профиль', \"group\".name as 'Группа', \"group\".course as 'Курс', studentVUZ.Id_VUZ, profiles.Id FROM studentVUZ INNER JOIN \"group\" ON studentVUZ.Id_group = \"group\".Id INNER JOIN VUZ ON studentVUZ.Id_VUZ = VUZ.Id INNER JOIN profiles ON \"group\".Id_profiles = profiles.Id INNER JOIN \"form\" ON profiles.Id_form = \"form\".Id INNER JOIN qulifyLevel ON profiles.Id_qulifyLevel = qulifyLevel.Id INNER JOIN direction ON profiles.Id_direction = direction.Id INNER JOIN directionTraining ON direction.Id_directionTraining = directionTraining.Id WHERE Id_person = " + IdStudent);
            mgTransV.Columns[0].Visible = false;
            mgTransV.Columns[1].Visible = false;
            mgTransV.Columns[2].Visible = false;
            mgTransV.Columns[10].Visible = false;
            mgTransV.Columns[11].Visible = false;
            mgTransV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            mgVUZ.Columns[0].Visible = false;
            mgVUZ.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;         
            //MessageBox.Show("SELECT profiles.Id, qulifyLevel.name, directionTraining.code, directionTraining.name, profiles.name, form.name, direction.\"year\" FROM profiles INNER JOIN form ON profiles.Id_form=form.Id INNER JOIN qulifyLevel ON profiles.Id_qulifyLevel=qulifyLevel.Id INNER JOIN direction ON profiles.Id_direction=direction.Id INNER JOIN directionTraining ON direction.Id_directionTraining=directionTraining.Id INNER JOIN VUZ ON direction.Id_VUZ=VUZ.Id WHERE VUZ.Id='" + mcbVUZ.SelectedValue+"'");
        }

        private void mcbVUZ_SelectedValueChanged(object sender, EventArgs e)
        {
            mgVUZ.DataSource = Data.CreateDataAdapter("SELECT profiles.Id, qulifyLevel.name as 'Квалификационный уровень', directionTraining.code as 'Код', directionTraining.name as 'Направление подготовки', profiles.name as 'Профиль', \"form\".name as 'Форма обучения', direction.\"year\" as 'Год' FROM profiles INNER JOIN form ON profiles.Id_form=\"form\".Id INNER JOIN qulifyLevel ON profiles.Id_qulifyLevel=qulifyLevel.Id INNER JOIN direction ON profiles.Id_direction=direction.Id INNER JOIN directionTraining ON direction.Id_directionTraining=directionTraining.Id INNER JOIN VUZ ON direction.Id_VUZ=VUZ.Id WHERE VUZ.Id=" + mcbVUZ.SelectedValue);
            //MessageBox.Show("SELECT profiles.Id, qulifyLevel.name as 'Квалификационный уровень', directionTraining.code as 'Код', directionTraining.name as 'Направление подготовки', profiles.name as 'Профиль', \"form\".name as 'Форма обучения', direction.\"year\" as 'Год' FROM profiles INNER JOIN form ON profiles.Id_form=\"form\".Id INNER JOIN qulifyLevel ON profiles.Id_qulifyLevel=qulifyLevel.Id INNER JOIN direction ON profiles.Id_direction=direction.Id INNER JOIN directionTraining ON direction.Id_directionTraining=directionTraining.Id INNER JOIN VUZ ON direction.Id_VUZ=VUZ.Id WHERE VUZ.Id=" + mcbVUZ.SelectedValue);

        }

        private void mbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mgVUZ_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            {
                int num;

                DataGridView d = (DataGridView)sender;
                if (e.RowIndex + 1 < d.RowCount)

                {
                    //MessageBox.Show(d.RowCount.ToString() + " " + e.RowIndex.ToString());
                    num = e.RowIndex;

                    IdStatusVUZ = Convert.ToInt32(mgTransV[0, mgTransV.CurrentCell.RowIndex].Value.ToString());
                    IdprofilesInDg = Convert.ToInt32 (mgVUZ[0, num].Value.ToString());
                    mcbGroupIn.DataSource = Data.CreateDataAdapter("SELECT Id, name FROM \"group\" WHERE Id_profiles="+ IdprofilesInDg);

                }

            }
        }

        private void mbOK_Click(object sender, EventArgs e)
        {
            if (mtbNumber.Text != "" && mlScanName.Text != " " && mlScanName.Text != "" && mlScanName.Text != "Выберите файл")
            {
                string strb = String.Format("{0: yyyy-MM-dd}", mdtB.Value);
                string strs = String.Format("{0: yyyy-MM-dd}", mdtSign.Value);

                Data.CreateCommand("INSERT INTO document(name, typeDocument, number, dateDocument, dateStart, scan, \"description\") VALUES ('Приказ №" + mtbNumber.Text + " от " + mdtB.Text + "','Приказ', '" + mtbNumber.Text + "','" + strs + "','" + strb + "','" + mlScanName.Text + "','" + mtbDescription.Text + "')");
                Data.CreateCommand("INSERT INTO student(Id_person, Id_document, Id_group, course, Id_statusStudent, Id_profiles) VALUES ('" + Idperson + "',(SELECT MAX(Id) FROM document),'" + mcbGroupIn.SelectedValue + "',(SELECT course FROM \"group\" WHERE Id = " + mcbGroupIn.SelectedValue + "),'2','" + IdprofilesInDg + "')"); // 2 - СТАТУС ПЕРЕВЕДЕН
                Data.CreateCommand("UPDATE studentVUZ SET Id_group= "+mcbGroupIn.SelectedValue+", Id_VUZ= "+mcbVUZ.SelectedValue+" WHERE Id="+IdStatusVUZ);
                
                //MessageBox.Show("INSERT INTO document(name, typeDocument, number, dateDocument, dateStart, scan, \"description\") VALUES ('Приказ №" + mtbNumber.Text + " от " + mdtB.Text + "','Приказ', '" + mtbNumber.Text + "','" + strs + "','" + strb + "','" + mlScanName.Text + "')");
               // MessageBox.Show("INSERT INTO student(Id_person, Id_document, Id_group, course, Id_statusStudent, Id_profiles) VALUES ('" + Idperson + "',(SELECT MAX(Id) FROM document),'" + mcbGroupIn.SelectedValue + "',(SELECT course FROM \"group\" WHERE Id = " + mcbGroupIn.SelectedValue + "),'2','" + Idprofiles + "')");
                Close();
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
