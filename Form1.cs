using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Contexts;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {

        Form2 loginForm = new Form2();
        public Form1() {
            InitializeComponent();
        }

        OleDbConnection connect1 = new OleDbConnection();
        Connection connect = new Connection();
        Renters rent = new Renters();
        private void Form1_Load(object sender, EventArgs e) {
            loginForm.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            rent.FullName = textBox2.Text;
            rent.EGN = textBox3.Text;
            rent.FamilyStatus = textBox4.Text;
            rent.PhoneNumber = textBox5.Text;
            rent.Type = textBox6.Text;
            rent.RoomNumber=textBox7.Text;
            rent.Payed = true;

            connect.InsertRent(rent);
            listBox1.Items.Add(rent.ToString());
        }

        private void button4_Click(object sender, EventArgs e) {
            MessageBox.Show("Renters of this room are: "+rent.FullName+" "+rent.EGN);
        }
    }

}
