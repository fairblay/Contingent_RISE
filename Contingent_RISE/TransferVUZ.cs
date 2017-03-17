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
        string coursee, Idstatus, Idgroup,IdVUZ;
        int IdprofilesInDg;

        public TransferVUZ(string FIO, string group, string directionTrainingName,string directionTrCode, string idVUZ, string Id_person, string Id_profiles, string Id_doc, string Course, string Id_group, string Id_VUZ)
        {
            InitializeComponent();

            Idperson = Id_person;
            Idprofiles = Id_profiles;
            Iddoc = Id_doc;
            coursee = Course;
            Idgroup = Id_group;
            IdVUZ = Id_VUZ;

            mcbVUZ.DataSource = Data.CreateDataAdapter("SELECT Id, name FROM VUZ");

            //mcbGroupIn.DataSource = Data.CreateCommandDataReader("SELECT Id, name FROM \"group\" WHERE Id_profiles=" + mgVUZ[0, mgVUZ.CurrentRow.Index].Value.ToString());
            mlFIO.Text += "   "+FIO;
            mlGroup.Text += "   " + group;
            mlDirectionTraining.Text += "   " + directionTrCode +" "+directionTrainingName;
            
           
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
                Data.CreateCommand("INSERT INTO student(Id_person, Id_document, Id_group, course, Id_statusStudent, Id_profiles) VALUES ('" + Idperson + "',(SELECT MAX(Id) FROM document),'" + mcbGroupIn.SelectedValue + "','" + coursee + "','2','" + IdprofilesInDg + "')");
                //MessageBox.Show("INSERT INTO document(name, typeDocument, number, dateDocument, dateStart, scan, \"description\") VALUES ('Приказ №" + mtbNumber.Text + " от " + mdtB.Text + "','Приказ', '" + mtbNumber.Text + "','" + strs + "','" + strb + "','" + mlScanName.Text + "')");
                //MessageBox.Show("INSERT INTO student(Id_person, Id_document, Id_group, course, Id_statusStudent, Id_profiles) VALUES ('" + Idperson + "',(SELECT MAX(Id) FROM document),'" + Idgroup + "','" + coursee + "','1','" + Idprofiles + "')");
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
