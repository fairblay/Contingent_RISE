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
    public partial class TransferCouse  : MetroFramework.Forms.MetroForm
    {
        string filename = "";
        string Idperson;
        string Idprofiles;
        string Iddoc;
        string coursee, IdVUZ, Idgroup;


        public TransferCouse()
        {
            InitializeComponent();



            mcbVUZ.DataSource = Data.CreateDataAdapter("SELECT Id, name FROM VUZ");
            
        }


        private void mbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void mcbVUZ_SelectedValueChanged(object sender, EventArgs e)
        {
            mcbGroup.DataSource = Data.CreateDataAdapter("SELECT Id, name FROM \"group\" WHERE Id_VUZ=" + mcbVUZ.SelectedValue);
        }

        private void mcbGroup_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void mbOk_Click(object sender, EventArgs e)
        {

            string strb = String.Format("{0: yyyy-MM-dd}", mdtB.Value);
            string strs = String.Format("{0: yyyy-MM-dd}", mdtSign.Value);



            Data.CreateCommand("INSERT INTO document(name, typeDocument, number, dateDocument, dateStart, scan, \"description\") VALUES ('Приказ №" + mtbNumDoc.Text + " от " + mdtB.Text + "','Приказ', '" + mtbNumDoc.Text + "','" + strs + "','" + strb + "','" + mlScanName.Text + "','" + mtbDescription.Text + "')");
            Data.CreateCommand("UPDATE student SET course = (SELECT DISTINCT course FROM student WHERE Id_group=2)+1 WHERE Id_group="+mcbGroup.SelectedValue);
        

            Close();
        }

        private void mbOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.SafeFileName;
            mlScanName.Text = filename;
        }
    }
}
