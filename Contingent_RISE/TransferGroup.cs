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

        public TransferGroup(string FIO, string group, string Id_person, string Id_profiles, string Id_doc)
        {
            InitializeComponent();
            mlFIO.Text +=FIO;
            mlGroup.Text += group;
            mcbGroup.DataSource = Data.CreateDataAdapter("SELECT Id, name FROM \"group\"");
            Idperson = Id_person;
            Idprofiles = Id_profiles;
            Iddoc = Id_doc;
        }

        private void TransferGroup_Load(object sender, EventArgs e)
        {
            
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
            //Data.CreateCommand("INSERT INTO document(name, typeDocument, number, dateDocument, dateStart, scan, \"description\") VALUES ('Приказ №" + mtbNumDoc.Text + " от " + mdtB.Text + "','Приказ', '" + mtbNumDoc.Text + "','" + strs + "','" + strb + "','" + mlScanName.Text + "','" + mtbDescription.Text + "')");
            // Data.CreateCommand("INSERT INTO student(Id_person, Id_document, Id_group, course, Id_statusStudent, Id_profiles) VALUES ('"+Idperson+ "')");  

            //MessageBox.Show("INSERT INTO document(name, typeDocument, number, dateDocument, dateStart, scan, \"description\") VALUES ('Приказ №" + mtbNumDoc.Text + " от " + mdtB.Text + "','Приказ', '" + mtbNumDoc.Text + "','" + strs + "','" + strb + "','" + mlScanName.Text + "','" + mtbDescription.Text + "')");
            MessageBox.Show("INSERT INTO student(Id_person, Id_document, Id_group, course, Id_statusStudent, Id_profiles) VALUES ('" + Idperson + "','" + Iddoc + "')");

            //Дописать 2ой createcommand(С помощью запроса в mgHistory+скрыть). Чтобы вставить последний Id_document в табл. student. 
            Close();
        }
    }
}
