using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class CheckUser
    {
        OleDbConnection connect;
        OleDbCommand command;

        public void UserValidation(String username, String password) {
            connect=new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = C:\uni\3ti kurs\2ri semestyr\TSP\SchoolDormApp\SutdentDormApp\DormsDatabase.accdb");
            connect.Open();
            //command=connect.CreateCommand();
            command = new OleDbCommand("SELECT Username AND Password FROM Admin WHERE Username = '"+username+"' AND Password = '"+password +"';",connect);
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read()) {       
                Form1 form1 = new Form1();
                Form2 form2 = new Form2();
                form1.WindowState=FormWindowState.Normal;     
                form1.Show();
                
            }
            else {
                MessageBox.Show("Incorrect user, try again", "Error", MessageBoxButtons.OKCancel);
            }
        }
    }
}
