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
    public partial class AboutWindow : MetroFramework.Forms.MetroForm
    {
        public AboutWindow()
        {
            InitializeComponent();
            metroTextBox1.Text = "Программа для обеспечения передвижения студентов в системе РИСО. \r\nАвторы:  Залунин А.С. и Соколянский А.В. \r\nv 1.0";
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
