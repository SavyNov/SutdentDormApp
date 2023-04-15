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

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        Form2 loginForm = new Form2();
        public Form1() {
            InitializeComponent();
        }

        OleDbConnection connect1 = new OleDbConnection();
        private void Form1_Load(object sender, EventArgs e) {
            loginForm.ShowDialog();
            button1.Text = "OK"; 
            button2.Text = "Exit";
            button3.Text = "Edit";
            button4.Text = "Show renters";
            button5.Text = "Search";
            button6.Text = "Insert";
            listBox1.Items.Add("Haha hui");
            listBox1.BorderStyle=BorderStyle.FixedSingle; listBox1.SelectedIndex = 0;
        }


        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }

}
