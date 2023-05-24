using System;
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
    public partial class admin_tables : Form
    {
        public admin_tables()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        // add category button
        private void button1_Click(object sender, EventArgs e)
        {
            int category_id = int.Parse(CATEGORY_ID.Text);
            string category_name = CATEGORY_NAME.Text;

            string query = "INSERT INTO Category (CatID,CatName) VALUES(" + category_id + ",'" + category_name + "');";

            Form1.instance.ExcuteQuery(query);

            MessageBox.Show("Successfully added to table");
        }


        // add publisher button
        private void button2_Click(object sender, EventArgs e)
        {
            int publisher_id = int.Parse(PUBLISHER_ID.Text);
            string publisher_name = PUBLISHER_NAME.Text;
            string publisher_phone = PUBLISHER_PHONE.Text;
            string publisher_address = PUBLISHER_ADDRESS.Text;

            string query = "INSERT INTO Publisher(PubID,PubName,Address,Phone) VALUES(" + publisher_id + ",'" + publisher_name + "','" + publisher_address + "','" + publisher_phone + "');";
            Form1.instance.ExcuteQuery(query);
            MessageBox.Show("Successfully added to table");
        }


        /* ADD AUTHOR BUTTON */
        private void button3_Click(object sender, EventArgs e)
        {
            int author_id = int.Parse(AUTHOR_ID.Text);
            string author_name = AUTHOR_NAME.Text;


            string query = "INSERT INTO Author (AuthorID,Name) VALUES(" + author_id + ",'" + author_name + "');";

            Form1.instance.ExcuteQuery(query);
            MessageBox.Show("Successfully added to table");

        }



        /* SHOW Category table */
        private void button4_Click(object sender, EventArgs e)
        {
            string q = "SELECT * FROM Category";
            dataGridView1.DataSource = Form1.instance.ExcuteQuery(q);
        }

        /* Show publisher table */
        private void button5_Click(object sender, EventArgs e)
        {
            string q = "SELECT * FROM Publisher";
            dataGridView1.DataSource = Form1.instance.ExcuteQuery(q);

        }

        // show Author table
        private void button6_Click(object sender, EventArgs e)
        {
            string q = "SELECT * FROM Author";
            dataGridView1.DataSource = Form1.instance.ExcuteQuery(q);
        }
    }
}
