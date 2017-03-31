using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;
using System.IO;

namespace Contingent_RISE
{


    public partial class MainWindow : MetroFramework.Forms.MetroForm
    {
        private int selectedIndex = -1; //для справочников
        string idStudent = ""; //id текущего студента

        public MainWindow()
        {
            /*Запуск идентификации пользователя*/
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            InitializeComponent();
            metroTabControl1.SelectedIndex = -1; //TAB'ы для справочников
            metroTabControlStudent.SelectedIndex = 0; //TAB'ы профиля студентов

          
            
        }
        
        private void MainWindow_Load(object sender, EventArgs e)
        {
            
                     
            /* try
            {
                con = new SqlConnection("Server=labit-1\\sqlexpress;Database=RISO;uid=test;pwd=test");
                con.Open();

               // MessageBox.Show("Успешное соединение!", "Соединение с БД", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Соединение с БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } */
        }


        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow ab = new AboutWindow();
            ab.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void вУЗToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* FormVPO VPO = new FormVPO();
            VPO.MdiParent = this;
           VPO.WindowState = FormWindowState.Maximized;
            VPO.BringToFront();
            
            VPO.Show(); */
        }

        private void VisiblePanels()
        {
            PanelStudent.Visible = false;
            PanelDictionary.Visible = false;
           
        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            VisiblePanels();
            PanelDictionary.Visible = true;
            metroTabControl1.SelectedIndex = 0;
        }
        
        
        private void updateDataGrid (string query)
        {
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            metroGrid1.DataSource = Data.CreateDataAdapter(query);
            metroGrid1.Columns[0].Visible = false; 
        }

        private void metroTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            
            //MessageBox.Show("" + metroTabControl1.SelectedIndex);

            switch (metroTabControl1.SelectedIndex)
            {
                case 0:
                    updateDataGrid("SELECT VUZ.Id, VUZ.name as 'ВПО', VUZ.phone as 'Телефон', city.name as 'Город' FROM VUZ INNER JOIN city ON VUZ.Id_city=city.Id");
                    break;
                case 1:
                    updateDataGrid("SELECT Id, Name as 'Название' FROM city");
                    break; 
                case 2:
                    updateDataGrid("SELECT Id, name as 'Название' FROM qulifyLevel");
                    break;
                case 3:
                    updateDataGrid("SELECT Id, name as 'Название', code as 'Код' FROM directionTraining");
                    break;
                case 4:
                    updateDataGrid("SELECT Id, name as 'Название' FROM form");
                    break;
            }
        }

        private void mbAdd_Click(object sender, EventArgs e)
        {
            switch (metroTabControl1.SelectedIndex)
            {
                case 0:
                    EditFormVPO add = new EditFormVPO();
                    add.ShowDialog();
                    updateDataGrid("SELECT VUZ.Id, VUZ.name as 'ВПО', VUZ.phone as 'Телефон', city.name as 'Город' FROM VUZ INNER JOIN city ON VUZ.Id_city=city.Id");
                    break;
                case 1:
                    EditFormCity efc = new EditFormCity();
                    efc.ShowDialog();
                    updateDataGrid("SELECT Id, Name as 'Название' FROM city");
                    break;
                case 2:
                    EditFormQulifyLevel efql = new EditFormQulifyLevel();
                    efql.ShowDialog();
                    updateDataGrid("SELECT Id, name as 'Название' FROM qulifyLevel");
                    break;
                case 3:
                    EditFormDirectionTraining efdt = new EditFormDirectionTraining();
                    efdt.ShowDialog();
                    updateDataGrid("SELECT Id, name as 'Название', code as 'Код' FROM directionTraining");
                    break;
                case 4:
                    EditFormForm eff = new EditFormForm();
                    eff.ShowDialog();
                    updateDataGrid("SELECT Id, name as 'Название' FROM form");
                    break;
            }
            
        }

        private void mbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroMessageBox.Show(this,"Вы уверены?", "Удалить данные", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataGridViewRow row = metroGrid1.Rows[selectedIndex];
                    switch (metroTabControl1.SelectedIndex)
                    {
                        case 0:
                            Data.CreateCommand("DELETE FROM VUZ WHERE Id=" + row.Cells["id"].Value.ToString());
                            updateDataGrid("SELECT VUZ.Id, VUZ.name as 'ВПО', VUZ.phone as 'Телефон', city.name as 'Город' FROM VUZ INNER JOIN city ON VUZ.Id_city=city.Id");
                            break;
                        case 1:
                            Data.CreateCommand("DELETE FROM city WHERE Id=" + row.Cells["id"].Value.ToString());
                            updateDataGrid("SELECT Id, Name as 'Название' FROM city");
                            break;
                        case 2:
                            Data.CreateCommand("DELETE FROM qulifyLevel WHERE Id=" + row.Cells["id"].Value.ToString());
                            updateDataGrid("SELECT Id, name as 'Название' FROM qulifyLevel");
                            break;
                        case 3:
                            Data.CreateCommand("DELETE FROM directionTraining WHERE Id=" + row.Cells["id"].Value.ToString());
                            updateDataGrid("SELECT Id, name as 'Название', code as 'Код' FROM directionTraining");
                            break;
                        case 4:
                            Data.CreateCommand("DELETE FROM form WHERE Id=" + row.Cells["id"].Value.ToString());
                            updateDataGrid("SELECT Id, name as 'Название' FROM form");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,ex.Message, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroGrid1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

        private void mbEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = metroGrid1.Rows[selectedIndex];
            switch (metroTabControl1.SelectedIndex)
            {
                case 0:
                    EditFormVPO ef = new EditFormVPO("" + row.Cells[0].Value, "" + row.Cells[1].Value, "" + row.Cells[2].Value, "" + row.Cells[3].Value);
                    ef.ShowDialog();
                    updateDataGrid("SELECT VUZ.Id, VUZ.name as 'ВПО', VUZ.phone as 'Телефон', city.name as 'Город' FROM VUZ INNER JOIN city ON VUZ.Id_city=city.Id");
                    break;
                case 1:
                    EditFormCity efc = new EditFormCity("" + row.Cells[1].Value, "" + row.Cells[0].Value);
                    efc.ShowDialog();
                    updateDataGrid("SELECT Id, Name as 'Название' FROM city");
                    break;
                case 2:
                    EditFormQulifyLevel efql = new EditFormQulifyLevel("" + row.Cells[1].Value, "" + row.Cells[0].Value);
                    efql.ShowDialog();
                    updateDataGrid("SELECT Id, name as 'Название' FROM qulifyLevel");
                    break;
                case 3:
                    EditFormDirectionTraining efdt = new EditFormDirectionTraining("" + row.Cells[1].Value, "" + row.Cells[0].Value, "" + row.Cells[2].Value);
                    efdt.ShowDialog();
                    updateDataGrid("SELECT Id, name as 'Название', code as 'Код' FROM directionTraining");
                    break;
                case 4:
                    EditFormForm eff = new EditFormForm("" + row.Cells[1].Value, "" + row.Cells[0].Value);
                    eff.ShowDialog();
                    updateDataGrid("SELECT Id, name as 'Название' FROM form");
                    break;
            }
        }

        private void mbSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < metroGrid1.RowCount; i++)
            {
                metroGrid1.Rows[i].Selected = false;
                for (int j = 0; j < metroGrid1.ColumnCount; j++)
                    if (metroGrid1.Rows[i].Cells[j].Value != null)
                        if (metroGrid1.Rows[i].Cells[j].Value.ToString().Contains(mtbSearch.Text))
                        {
                            metroGrid1.Rows[i].Selected = true;
                            break;
                        }
                
            }

        }

        private void mtbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
                mbSearch_Click(new object(), new EventArgs());

        }

        private void mtbSearch_Click(object sender, EventArgs e)
        {
            metroGrid1.ClearSelection();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisiblePanels();

            PanelStudent.Visible = true;

            metroGridStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            mgHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //metroGridStudent.DataSource = Data.CreateDataAdapter("SELECT t1.Id, t1.FIO as ФИО, t1.INN as ИНН, t1.course as Курс,t1.namegroup as Группа, t1.name as Статус, t1.Photo, t2.da as 'Дата документа' FROM (SELECT Person.Id, Person.FIO, Person.INN, student.course, \"group\".name as namegroup, statusStudent.name, Person.AvarageScore, Person.Pasport, Person.Photo, document.scan, document.dateStart, student.Id as idstud FROM Person INNER JOIN student ON student.Id_person = Person.Id INNER JOIN document ON document.Id = student.Id_document INNER JOIN \"group\" ON \"group\".Id = student.Id_group INNER JOIN statusStudent ON statusStudent.Id = student.Id_statusStudent) t1 RIGHT JOIN (SELECT student.Id_person, MAX(document.dateStart) as da FROM student INNER JOIN document ON document.Id = student.Id_document GROUP BY student.Id_person) t2 ON t1.Id = t2.Id_person AND t1.dateStart = t2.da");
            metroGridStudent.DataSource = Data.CreateDataAdapter("SELECT Id, FIO as 'ФИО', INN as 'ИНН' FROM Person");
            metroGridStudent.Focus();
            metroGridStudent.ReadOnly = true;
            mgHistory.ReadOnly = true;
            //historyStudent();
            //mbOutsideTr.Visible = false;
            //mbInsideTr.Visible = false;

            //MessageBox.Show(metroGridStudent.CurrentRow.Index.ToString());
            //string str = metroGridStudent.CurrentRow.Index.ToString();
            //personData("0");
        }
        /*Выборка данных по текущему студенту 
         *Убирает id из datagrid
         */
        private void personData(string row)
        {
            
            int x = Int32.Parse(row);
      
               idStudent  = metroGridStudent[0, x].Value.ToString();
               // MessageBox.Show("" + metroGridStudent[0,x].Value.ToString());
                metroGridStudent.Columns[0].Visible = false;



            using (SqlConnection con = new SqlConnection(Data.connection))
                ///Для безопасности
                {
                    SqlCommand comm = new SqlCommand("SELECT FIO, INN, Pasport, AvarageScore, photo FROM Person WHERE Id=" + idStudent, con);
                    comm.Connection.Open();
                    SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read() || metroTabControl1.SelectedIndex == 1)
                {

                    historyStudent();
                    

                    //MessageBox.Show(reader[0].ToString());
                    string path = Directory.GetCurrentDirectory();
                    LabelFIO.Text = reader[0].ToString();
                    LabelINN.Text = reader[1].ToString();
                    LabelPasport.Text = reader[2].ToString();
                    LabelAvarage.Text = reader[3].ToString();
                    metroLabelFIO.Text = reader[0].ToString();
                    
                    try
                    {
                        pictureBox2.Image = Image.FromFile(path + "\\Images\\" + reader[4]);
                    }
                    catch (Exception ex)
                    {
                        pictureBox2.Image = Properties.Resources.b5cdab07;
                    }
                }
            }
           
            

        } 
      

        private void metroGridStudent_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string str;
            DataGridView d = (DataGridView)sender;
            if (e.RowIndex + 1 < d.RowCount)

            {
                // MessageBox.Show(d.RowCount.ToString() + " " + e.RowIndex.ToString());
                str = e.RowIndex.ToString();
                personData(str);
            }

        }

        private void metroTabControlStudent_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void metroTabControlStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControlStudent.SelectedIndex == 1)
            {
                historyStudent();
                //mbOutsideTr.Visible = true;
                //mbInsideTr.Visible = true;
            }
        
        }
        private void historyStudent()
        {
            mgHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //  mgHistory.DataSource = Data.CreateDataAdapter("SELECT Person.Id, Person.FIO as ФИО, Person.INN as ИНН,student.course as Курс, \"group\".name as Группа, statusStudent.name as Статус, Person.photo FROM student INNER JOIN Person ON student.Id_person=Person.Id INNER JOIN \"group\" ON student.Id_group=\"group\".Id INNER JOIN statusStudent ON student.Id_statusStudent=statusStudent.Id");
            mgHistory.DataSource = Data.CreateDataAdapter("SELECT Person.Id, student.Id,document.dateStart as 'Дата вступления документа', VUZ.name as ВУЗ, directionTraining.name as 'Направление в ВУЗе',qulifyLevel.name as 'Квалификационный уровень',\"form\".name as 'Форма обучения',profiles.name as 'Профиль', \"group\".name as Группа,student.course as Курс, statusStudent.name as 'Статус студента', profiles.Id as 'PRO', student.Id_document as 'Iddoc', student.Id_statusStudent as 'IdSS', student.Id_group as 'IdGR', directionTraining.code, VUZ.Id as 'IdVUZ', \"group\".Id_VUZ as 'IDV', document.description as 'Заметки' FROM student INNER JOIN Person ON student.Id_person = Person.Id INNER JOIN \"group\" ON student.Id_group = \"group\".Id INNER JOIN profiles ON \"group\".Id_profiles = profiles.Id INNER JOIN VUZ ON \"group\".Id_VUZ = VUZ.Id INNER JOIN statusStudent ON student.Id_statusStudent = statusStudent.Id INNER JOIN document ON student.Id_document = document.Id INNER JOIN direction ON profiles.Id_direction = direction.Id INNER JOIN directionTraining ON directionTraining.Id = direction.Id_directionTraining INNER JOIN qulifyLevel ON profiles.Id_qulifyLevel = qulifyLevel.Id INNER JOIN \"form\" ON profiles.Id_form = \"form\".Id WHERE Person.Id = "+idStudent+ " ORDER BY document.Id DESC");
            
            mgHistory.Columns[0].Visible = false;
            mgHistory.Columns[1].Visible = false;
            for(int i=11; i<18; ++i)
                 mgHistory.Columns[i].Visible = false;
           
        }



        private void mbSearchForStudents_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < metroGridStudent.RowCount; i++)
            {
                metroGridStudent.Rows[i].Selected = false;
                for (int j = 0; j < metroGridStudent.ColumnCount; j++)
                    if (metroGridStudent.Rows[i].Cells[j].Value != null)
                        if (metroGridStudent.Rows[i].Cells[j].Value.ToString().Contains(metroTextBoxFind.Text))
                        {
                            metroGridStudent.Rows[i].Selected = true;
                            historyStudent();
                            metroGridStudent.Focus();

                            break;
                        }
                

            }
        }

        private void пЕСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TransferCouse tc = new TransferCouse();
                tc.ShowDialog();
                historyStudent();
                metroGridStudent.DataSource = Data.CreateDataAdapter("SELECT Id, FIO as 'ФИО', INN as 'ИНН' FROM Person");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void преводВГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                TransferGroup tg = new TransferGroup(LabelFIO.Text, metroGridStudent[0, metroGridStudent.CurrentCell.RowIndex].Value.ToString(), mgHistory[11, 0].Value.ToString(), mgHistory[12, 0].Value.ToString(), mgHistory[9, 0].Value.ToString(), mgHistory[17, 0].Value.ToString(), idStudent);
                tg.ShowDialog();
                historyStudent();
                metroGridStudent.DataSource = Data.CreateDataAdapter("SELECT Id, FIO as 'ФИО', INN as 'ИНН' FROM Person");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void переводВВУЗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                using (TransferVUZ tv = new TransferVUZ(LabelFIO.Text, mgHistory[4, 0].Value.ToString(), mgHistory[15, 0].Value.ToString(), mgHistory[16, 0].Value.ToString(), metroGridStudent[0, metroGridStudent.CurrentCell.RowIndex].Value.ToString(), mgHistory[11,0].Value.ToString(), mgHistory[12, 0].Value.ToString(), mgHistory[9, 0].Value.ToString(), mgHistory[14, 0].Value.ToString(), mgHistory[17, 0].Value.ToString(), idStudent))
                {
                    tv.ShowDialog();
                    historyStudent();
                    metroGridStudent.DataSource = Data.CreateDataAdapter("SELECT Id, FIO as 'ФИО', INN as 'ИНН' FROM Person");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void академическийОтпускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                using (Academ ac = new Academ(LabelFIO.Text, metroGridStudent[0, metroGridStudent.CurrentCell.RowIndex].Value.ToString(), mgHistory[11, 0].Value.ToString(), mgHistory[12, 0].Value.ToString(), mgHistory[13, 0].Value.ToString(), mgHistory[9, 0].Value.ToString(), mgHistory[17, 0].Value.ToString(), mgHistory[14, 0].Value.ToString(), idStudent))
                {
                    ac.ShowDialog();
                    historyStudent();
                    metroGridStudent.DataSource = Data.CreateDataAdapter("SELECT Id, FIO as 'ФИО', INN as 'ИНН' FROM Person");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void отчислениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteStudents ds = new DeleteStudents(LabelFIO.Text, metroGridStudent[0, metroGridStudent.CurrentCell.RowIndex].Value.ToString(), mgHistory[11, 0].Value.ToString(), mgHistory[12,0].Value.ToString(), mgHistory[9, 0].Value.ToString(), mgHistory[14, 0].Value.ToString(), idStudent);
                ds.ShowDialog();
                historyStudent();
                metroGridStudent.DataSource = Data.CreateDataAdapter("SELECT Id, FIO as 'ФИО', INN as 'ИНН' FROM Person");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void сменаФИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                using (Rename rn = new Rename(LabelFIO.Text, metroGridStudent[0, metroGridStudent.CurrentCell.RowIndex].Value.ToString(), mgHistory[11, 0].Value.ToString(), mgHistory[12, 0].Value.ToString(), mgHistory[9, 0].Value.ToString(), mgHistory[14, 0].Value.ToString(), idStudent))
                {
                    rn.ShowDialog();
                    historyStudent();
                    metroGridStudent.DataSource = Data.CreateDataAdapter("SELECT Id, FIO as 'ФИО', INN as 'ИНН' FROM Person");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroTextBoxFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                mbSearchForStudents_Click(new object(), new EventArgs());
        }
    }
}
