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


        public TransferVUZ(string FIO, string group, string directionTrainingName,string directionTrCode, string idVUZ)
        {
            InitializeComponent();
            mcbVUZ.DataSource = Data.CreateDataAdapter("SELECT Id, name FROM VUZ");
            mlFIO.Text += "   "+FIO;
            mlGroup.Text += "   " + group;
            mlDirectionTraining.Text += "   " + directionTrCode +" "+directionTrainingName;
        }
    }
}
