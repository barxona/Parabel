using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2.Datenbank
{
    class Datenbankverbindung
    {
        public static string ConnectionString =
    "SERVER=" + "sql11.freemysqlhosting.net" + "; DATABASE=" + "sql11198551" + "; UID=" + "	sql11198551" +
    "; PASSWORD=" + "tEaJcgq2qh";

        public static long Query(string Query)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    var cmd = conn.CreateCommand();
                    cmd.CommandText = Query;
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    return cmd.LastInsertedId;
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("[MySQL][Error]" + e);
                    return -1;
                }
            }
        }

        public static DataTable QueryResult(string Query)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = Query;
                    var reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        conn.Close();
                        return null;
                    }
                    var reslut = new DataTable();
                    reslut.Load(reader);
                    reader.Close();

                    conn.Close();

                    return reslut;
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("[MySQL][Error]" + e);
                    return null;
                }
            }
        }
    }
}
