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
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Contexts;
using ZadachaTSP;

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
        private void Form1_Load(object sender, EventArgs e) {
            loginForm.ShowDialog();
            listBox1.BorderStyle=BorderStyle.FixedSingle; listBox1.SelectedIndex = 0;
        }


        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Renters rent = new Renters();
            rent.FullName = textBox2.Text;
            rent.EGN = textBox3.Text;
            rent.RoomNumber = textBox4.Text;
            rent.FamilyStatus = textBox5.Text;
            rent.PhoneNumber = textBox6.Text;
            rent.Type = textBox7.Text;
            rent.Payed = true;
            connect.InsertRent(rent);
        }
    }

}
