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
using WindowsFormsApplication2.Datenbank;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sql()
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.ToString();
            label2.Text = textBox2.Text.ToString();
            var hasUser =
           Datenbankverbindung.QueryResult(
               $"SELECT * FROM Account WHERE Name='{textBox1.Text}' AND Passwort='{textBox2.Text}'");

            if (hasUser != null)
                foreach (DataRow Row in hasUser.Rows)
                {
                    string AccountID = Convert.ToString(Row["Acc_ID"]);
                    label3.Text = AccountID;
                }

            else MessageBox.Show("Your password is wrong.");
        }
    }
}
