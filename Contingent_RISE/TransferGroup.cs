using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contingent_RISE
{
    public partial class TransferGroup : MetroFramework.Forms.MetroForm
    {
        string filename = "";
        string Idperson;
        string Idprofiles;
        string Iddoc;
        string Idstatus,IdVUZ, IdStudent;
        int IdVUZz, IdStatusVUZ;
        public TransferGroup(string FIO, string Id_person, string Id_profiles, string Id_doc, string Id_status, string Id_VUZ, string Id_student)
        {
            InitializeComponent();
            mlFIO.Text +=FIO;
           
            
            Idperson = Id_person;
            Idprofiles = Id_profiles;
            Iddoc = Id_doc;
            Idstatus = Id_status;
            IdVUZ = Id_VUZ;
            IdStudent = Id_student;

            mgTrans.DataSource = Data.CreateDataAdapter("SELECT studentVUZ.Id, Id_person, Id_group, VUZ.name as 'ВУЗ', directionTraining.name as 'Направление в ВУЗе', qulifyLevel.name as 'Квалификационный уровень', \"form\".name as 'Форма обучения', profiles.name as 'Профиль', \"group\".name as 'Группа', \"group\".course as 'Курс', studentVUZ.Id_VUZ, profiles.Id FROM studentVUZ INNER JOIN \"group\" ON studentVUZ.Id_group = \"group\".Id INNER JOIN VUZ ON studentVUZ.Id_VUZ = VUZ.Id INNER JOIN profiles ON \"group\".Id_profiles = profiles.Id INNER JOIN \"form\" ON profiles.Id_form = \"form\".Id INNER JOIN qulifyLevel ON profiles.Id_qulifyLevel = qulifyLevel.Id INNER JOIN direction ON profiles.Id_direction = direction.Id INNER JOIN directionTraining ON direction.Id_directionTraining = directionTraining.Id WHERE Id_person = " + IdStudent);
            mgTrans.Columns[0].Visible = false;
            mgTrans.Columns[1].Visible = false;
            mgTrans.Columns[2].Visible = false;
            mgTrans.Columns[10].Visible = false;
            mgTrans.Columns[11].Visible = false;

            mgTrans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
           // mcbGroup.DataSource = Data.CreateDataAdapter("SELECT Id, name FROM \"group\" WHERE Id_VUZ=" + mgTrans[0, 1].Value.ToString());
            
            //MessageBox.Show("SELECT Id, name FROM \"group\" WHERE Id_VUZ=" +IdVUZ);
        }

        private void TransferGroup_Load(object sender, EventArgs e)
        {
            
        }

        private void mgTrans_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            {
                int num;

                DataGridView d = (DataGridView)sender;
                if (e.RowIndex + 1 < d.RowCount)

                {
                   
                    num = e.RowIndex;


                    IdVUZz = Convert.ToInt32(mgTrans[10, num].Value.ToString());
                    Idprofiles = mgTrans[11, num].Value.ToString();
                    IdStatusVUZ = Convert.ToInt32(mgTrans[0, num].Value.ToString());
                    mcbGroup.DataSource = Data.CreateDataAdapter("SELECT Id, name FROM \"group\" WHERE Id_VUZ=" + IdVUZz);

                }

            }
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
                Data.CreateCommand("INSERT INTO document(name, typeDocument, number, dateDocument, dateStart, scan, \"description\") VALUES ('Приказ №" + mtbNumDoc.Text + " от " + mdtB.Text + "','Приказ', '" + mtbNumDoc.Text + "','" + strs + "','" + strb + "','" + mlScanName.Text + "','" + mtbDescription.Text + "')");
                Data.CreateCommand("INSERT INTO student(Id_person, Id_document, Id_group, course, Id_statusStudent, Id_profiles) VALUES ('" + Idperson + "',(SELECT MAX(Id) FROM document),'" + mcbGroup.SelectedValue + "',(SELECT course FROM \"group\" WHERE Id = " + mcbGroup.SelectedValue + "),'2','" + Idprofiles + "')"); // 2 - статус ПЕРЕВЕДЕН
                Data.CreateCommand("UPDATE studentVUZ SET Id_group= "+mcbGroup.SelectedValue+" WHERE Id="+IdStatusVUZ);
                //MessageBox.Show("UPDATE studentVUZ SET Id_group= " + mcbGroup.SelectedValue + " WHERE Id_VUZ=" + IdVUZz);
                //MessageBox.Show("INSERT INTO document(name, typeDocument, number, dateDocument, dateStart, scan, \"description\") VALUES ('Приказ №" + mtbNumDoc.Text + " от " + mdtB.Text + "','Приказ', '" + mtbNumDoc.Text + "','" + strs + "','" + strb + "','" + mlScanName.Text + "','" + mtbDescription.Text + "')");
               // MessageBox.Show("INSERT INTO student(Id_person, Id_document, Id_group, course, Id_statusStudent, Id_profiles) VALUES ('" + Idperson + "',(SELECT MAX(Id) FROM document),'" + mcbGroup.SelectedValue + "','(SELECT course FROM \"group\" WHERE Id = "+mcbGroup.SelectedValue+"),'" + Idstatus + "','" + Idprofiles + "')");

                Close();
            }
            else MetroMessageBox.Show(this, "Заполните все поля данными", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
