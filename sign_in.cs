﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace online_library_mssql
{
    public partial class sign_in : Form
    {
        public sign_in()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void sign_up_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = EMAIL.Text;
            string password = PASSWORD.Text;
            
            string query = "SELECT * FROM Users WHERE Email = '" + email + "' AND Password = '" + password + "'";
            DataTable dt = Form1.instance.ExcuteQuery(query);

            if(dt.Rows.Count == 1)
            {
                MessageBox.Show("Valid email and password");

                /* check if the signed in user is admin or student and navigate them */
                

                if (dt.Rows[0]["Type"].ToString() == "admin")
                {
                    this.Hide();
                    admin_panel adminPanel = new admin_panel();
                    adminPanel.Show();
                }
                else
                {
                    this.Hide();
                    studentrole strole = new studentrole(email,password);
                    strole.Show();
                }
            }
            else
            {

                MessageBox.Show("Invalid email and password");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
