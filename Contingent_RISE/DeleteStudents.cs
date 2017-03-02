﻿using System;
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
        string coursee, Idstatus;

        public DeleteStudents(string FIO, string group, string Id_person, string Id_profiles, string Id_doc, string Course, string Id_status)
        {
            InitializeComponent();
            mlFIO.Text += FIO;
            mlGroup.Text += group;
            Idperson = Id_person;
            Idprofiles = Id_profiles;
            Iddoc = Id_doc;
            coursee = Course;
            Idstatus = Id_status;
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
            string strb = String.Format("{0: yyyy-MM-dd}", mdtB.Value);
            string strs = String.Format("{0: yyyy-MM-dd}", mdtSign.Value);

            Close();
        }

        private void mbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}