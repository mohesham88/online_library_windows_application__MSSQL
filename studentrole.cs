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
    public partial class studentrole : Form
    {   private string pass;
        public string email;
        public studentrole(string email ,string pass)
        {
            this.email = email;
            this.pass = pass;
            InitializeComponent();
        }

        private bool iscollpased;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (iscollpased)
            {
                paneldrop.Height += 50;
                if(paneldrop.Size==paneldrop.MaximumSize)
                {
                    timer1.Stop();
                    iscollpased = false;
                }
            }
            else
            {
                paneldrop.Height -= 50;
                if (paneldrop.Size == paneldrop.MinimumSize)
                {
                    timer1.Stop();
                    iscollpased = true;
                }
            }
        }

        private void serch_by_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private string choose;
        
        
        private void titel_Click(object sender, EventArgs e)
        {
            timer1.Start();
            choose = "Title";
            MessageBox.Show(choose);
            paneldrop.Height -= 50;
            if (paneldrop.Size == paneldrop.MinimumSize)
            {
                timer1.Stop();
                iscollpased = true;
            }
        }

        private void publisher_Click(object sender, EventArgs e)
        {
            timer1.Start();
            choose = "PubName";
            //MessageBox.Show(choose);
            paneldrop.Height -= 50;
            if (paneldrop.Size == paneldrop.MinimumSize)
            {
                timer1.Stop();
                iscollpased = true;
            }
        }

        private void ISBN_Click(object sender, EventArgs e)
        {   
            timer1.Start();
            choose = "ISBN";
            //MessageBox.Show(choose);
            paneldrop.Height -= 50;
            if (paneldrop.Size == paneldrop.MinimumSize)
            {
                timer1.Stop();
                iscollpased = true;
            }
        }

        private void year_Click(object sender, EventArgs e)
        {   
            timer1.Start();
            choose = "Year";
            paneldrop.Height -= 50;
            if (paneldrop.Size == paneldrop.MinimumSize)
            {
                timer1.Stop();
                iscollpased = true;
            }
        }

        private void category_Click(object sender, EventArgs e)
        {
            timer1.Start();
            choose = "Genre";
            //MessageBox.Show(choose);
            paneldrop.Height -= 100;
            if (paneldrop.Size == paneldrop.MinimumSize)
            {
                timer1.Stop();
                iscollpased = true;
            }
        }
        private void search_Click(object sender, EventArgs e)
        {
            string q="";
            if (choose == "Title")
            {
                q = "select *from Book where "+choose+"='" + bookname.Text + "';";
            }else if(choose== "ISBN")
            {
                q = "select *from Book where "+choose+"='" + bookname.Text + "';";
            }
            else if (choose == "Year")
            {
                q = "select *from Book where "+choose+"='" + bookname.Text + "';";
            }
            else if (choose == "Genre")
            {
                q = "select *from Book where " + choose + "='" + bookname.Text + "';";
            }
            else if (choose == "Genre")
            {
                q = "select *from Book where " + choose + "='" + bookname.Text + "';";
            }
            else if (choose == "PubName")
            {
                q = "select ISBN ,Title,Book.PubID,PubName,Year,Genre from Book,Publisher where Book.PubID = Publisher.PubID and Publisher.PubName = '"+bookname.Text+"'; ";
            }


            DataTable dt = Form1.instance.ExcuteQuery(q);

            /*DataGridView dataGridView = new DataGridView();
            dataGridView.Location = new Point(77, 199);
            dataGridView.Size = new Size(424, 141);
            this.Controls.Add(dataGridView);
            dataGridView.DataSource = dt;*/
            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookname_TextChanged(object sender, EventArgs e)
        {

        }

        private void oout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void update_info_Click(object sender, EventArgs e)
        {
            this.Close();
            updateStudent update=new updateStudent(email,pass);
            update.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
