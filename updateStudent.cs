using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_library_mssql
{
    public partial class updateStudent : Form
    {
        public string emai;
        private string password;
        public updateStudent(string email, string password)
        {
            this.password= password;
            this.emai = email;
            InitializeComponent();
            this.password = password;
        }

        private void updatt_Click(object sender, EventArgs e)
        {
            string q="update Users set Name='"+name.Text+"',Email='"+email.Text+"',Password='"+pass.Text+"' where Email='"+emai+"';";
       
            DataTable dt = Form1.instance.ExcuteQuery(q);
            MessageBox.Show("data updated successfully");
        }
        
        private void updateStudent_Load(object sender, EventArgs e)
        {
            string q1 = "select Name from Users where Email='" + this.emai+ "'";
            DataTable dt = Form1.instance.ExcuteQuery(q1);
            name.Text = dt.Rows[0]["Name"].ToString();
            email.Text = emai;
            pass.Text=password;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentrole s1=new studentrole(email.Text, pass.Text);
            s1.Show();
        }
    }
}
