﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2: Form
    {

        public Form2() {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e) {
            label1.Text="Username";
            label2.Text="Password";
            button1.Text="Login";
           
        }

        private void button1_Click(object sender, EventArgs e) {
            String username = textBox1.Text;
            String password = textBox2.Text;
            CheckUser check = new CheckUser();
            check.UserValidation(username, password);
            this.Hide();
        }
    }
}
