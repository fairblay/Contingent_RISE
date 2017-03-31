using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contingent_RISE
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
    static class Data
    {

        static public string connection;
        public static void CreateCommand(string queryString)
            {
                    using (SqlConnection con = new SqlConnection(connection)) 
                    ///Для безопасности
                {
                    SqlCommand comm = new SqlCommand(queryString, con);
                    comm.Connection.Open();
                    comm.ExecuteNonQuery();
                }
            }
        public static SqlDataReader CreateCommandDataReader(string queryString)
        {
            using (SqlConnection con = new SqlConnection(connection))
            ///Для безопасности
            {
                SqlCommand comm = new SqlCommand(queryString, con);
                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                reader.Read();
                //MessageBox.Show(reader[0].ToString());
                return reader;
            }
        }
        public static DataTable CreateDataAdapter(string queryString)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter dat = new SqlDataAdapter("" + queryString, con);
                    DataTable dt = new DataTable();
                    dat.Fill(dt);
                    con.Close();
                    return dt;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message); 
                }
               
            }
            return null;
        }

    }
}
