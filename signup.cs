using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_library_mssql
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            
            string insertUser = "INSERT INTO Users ( Name , Email , Password ,Type) VALUES('" + name.Text + "','" + email.Text + "','" + pass.Text + "','" + type.Text + "');";
            DataTable dt = Form1.instance.ExcuteQuery(insertUser);
            if (type.Text == "student")
            {
                this.Hide();
                studentrole s1= new studentrole(email.Text,pass.Text);
                s1.Show();
            }
        }
    }
}
