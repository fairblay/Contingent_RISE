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
        string coursee, Idgroup, oldfio;

        public Rename(string FIO, string group, string Id_person, string Id_profiles, string Id_doc, string Course, string Id_group)
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
            string strb = String.Format("{0: yyyy-MM-dd}", mdtB.Value);
            string strs = String.Format("{0: yyyy-MM-dd}", mdtSign.Value);
            Data.CreateCommand("INSERT INTO document(name, typeDocument, number, dateDocument, dateStart, scan, \"description\") VALUES ('Приказ №" + mtbNumDoc.Text + " от " + mdtB.Text + "','Приказ', '" + mtbNumDoc.Text + "','" + strs + "','" + strb + "','" + mlScanName.Text + "','" + oldfio + "')");
           Data.CreateCommand("INSERT INTO student(Id_person, Id_document, Id_group, course, Id_statusStudent, Id_profiles) VALUES ('" + Idperson + "',(SELECT MAX(Id) FROM document),'" + Idgroup + "','" + coursee + "','7','" + Idprofiles + "')");
            Data.CreateCommand("UPDATE Person SET FIO='"+mtbNewFIO.Text+"' WHERE FIO='"+oldfio+"'");
            //MessageBox.Show(coursee);
            Close();
        }
    }
}
