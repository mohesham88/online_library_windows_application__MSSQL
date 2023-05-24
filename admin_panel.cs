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
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int isbn = int.Parse(ISBN.Text);
            string title = TITLE.Text;
            string PublisherName = PUBLISHER_NAME.Text;
            string AuthorName = AUTHOR_NAME.Text;
            string category = CATEGORY.Text;
            int year = int.Parse(YEAR.Text);
            string authorName = AUTHOR_NAME.Text;
            string publisherName = PUBLISHER_NAME.Text;
            int number_of_copies = int.Parse(NUMBER_OF_COPIES.Text);


            string getCategoryIDQuery = "SELECT CatID From Category WHERE CatName = '" + category + "';";
            string getAuthorIDQuery = "SELECT AuthorID From Author WHERE Name = '" + authorName + "';";
            string getPublisherIDQuery = "SELECT PubID FROM Publisher WHERE PubName = '" + publisherName + "';";

            int category_id = int.Parse(Form1.instance.ExcuteQuery(getCategoryIDQuery).Rows[0]["CatID"].ToString());
            int author_id = int.Parse(Form1.instance.ExcuteQuery(getAuthorIDQuery).Rows[0]["AuthorID"].ToString());
            int publisher_id = int.Parse(Form1.instance.ExcuteQuery(getPublisherIDQuery).Rows[0]["PubID"].ToString());


            string query = "INSERT INTO Book (ISBN, Title, Year, Genre,PubID,category_id) VALUES (" + isbn + ",'" + title + "'," + year + ",'" + category + "'," + publisher_id +"," + category_id +  ");";
            /*Excute the query on the database */
            Form1.instance.ExcuteQuery(query);


            /* ADD AUTHOR and ISBN to Book_Author book */

            string addAuthorQuery = "INSERT INTO BookAuthor(BookISBN,AuthorID) VALUES(" + isbn +  "," + author_id + ");";
            Form1.instance.ExcuteQuery(addAuthorQuery);


            // ADD the book isbn and number of copies to the book copies table
            string bookCopies = "INSERT INTO Book_Copies(ISBN,number_of_copy) VALUES (" + isbn + "," + number_of_copies + ");" ;
            Form1.instance.ExcuteQuery(bookCopies);


            // load the table again 
            UpdateTable();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dg = TABLE.CurrentRow;
            /* There is a selected row */
            if(dg != null)
            {
               
                ISBN.Text = dg.Cells["ISBN"].Value.ToString();
                TITLE.Text = dg.Cells["Title"].Value.ToString();
                YEAR.Text = dg.Cells["Year"].Value.ToString();
                int category_id = int.Parse(dg.Cells["category_id"].Value.ToString());
                int publisher_id = int.Parse(dg.Cells["PubID"].Value.ToString());


                /* publiser name, category name , author name , number of copies */
                string getCategoryNameQuery = "SELECT CatName From Category WHERE CatID = " + category_id + ";" ;
                string category_name = Form1.instance.ExcuteQuery(getCategoryNameQuery).Rows[0]["CatName"].ToString();
                CATEGORY.Text = category_name;

                string getPublisherNameQuery = "SELECT PubName FROM Publisher WHERE PubID = " + publisher_id + ";";
                string publisher_name = Form1.instance.ExcuteQuery(getPublisherNameQuery).Rows[0]["PubName"].ToString();
                PUBLISHER_NAME.Text = publisher_name;

                // join to get the author name
                int isbn = int.Parse(dg.Cells["ISBN"].Value.ToString());
                string getAuthorNameQuery = "SELECT Name From BookAuthor, Author WHERE BookAuthor.AuthorID = Author.AuthorID AND BookISBN = " + isbn;
                string author_name = Form1.instance.ExcuteQuery(getAuthorNameQuery).Rows[0]["Name"].ToString();
                AUTHOR_NAME.Text = author_name;


                // get the number of copies
                string getNumberOfCopiesQuery = "SELECT number_of_copy FROM Book_Copies WHERE ISBN = " + isbn + ";";
                string number_of_copies = Form1.instance.ExcuteQuery(getNumberOfCopiesQuery).Rows[0]["number_of_copy"].ToString();
                NUMBER_OF_COPIES.Text = number_of_copies;


            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void admin_panel_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }


        /* Delete Btn */
        private void button3_Click(object sender, EventArgs e)
        {
            /*Get the selected book id*/
            string selectedISBN_Str = TABLE.CurrentRow.Cells["ISBN"].Value.ToString();

            
            int selectedISBN = int.Parse(selectedISBN_Str);

            string query = "  DELETE FROM Book WHERE ISBN =" + selectedISBN + ";";
            Form1.instance.ExcuteQuery(query);
            MessageBox.Show("The book with ISBN = " + selectedISBN + " has been deleted Successfully");
            
            // show the table after removing the record
            UpdateTable();
        }


        public void UpdateTable()
        {
            string q = "SELECT * FROM Book";
            TABLE.DataSource = Form1.instance.ExcuteQuery(q);

        }

        /* Update Btn */

        private void button2_Click(object sender, EventArgs e)
        {
            /* Get the user input  */ 
            int isbn = int.Parse(ISBN.Text);
            string title = TITLE.Text;
            string PublisherName = PUBLISHER_NAME.Text;
            string AuthorName = AUTHOR_NAME.Text;
            string category = CATEGORY.Text;
            int year = int.Parse(YEAR.Text);
            int number_of_copies = int.Parse(NUMBER_OF_COPIES.Text);

            /* get the selected row isbn */
            string selectedISBN_Str = TABLE.CurrentRow.Cells["ISBN"].Value.ToString();
            int selectedISBN = int.Parse(selectedISBN_Str);

            string isbn_query = "UPDATE Book SET ISBN = "+ selectedISBN + "WHERE isbn = " + selectedISBN + ";";
            string title_query = "UPDATE Book SET Title = '"+ title + "' WHERE isbn = " + isbn + ";";
            string category_query = "UPDATE Book SET Genre = '"+ category + "' WHERE isbn = " + isbn + ";";
            string Year_query = "UPDATE Book SET Year = "+ year + " WHERE isbn = " + isbn + ";";

            Form1.instance.ExcuteQuery(isbn_query);
            Form1.instance.ExcuteQuery(title_query);
            Form1.instance.ExcuteQuery(category_query);
            Form1.instance.ExcuteQuery(Year_query);


            // updaet book copies (ISBN,number_of_copy)

            string bookCopies = "UPDATE Book_Copies SET number_of_copy =" +  number_of_copies + " WHERE ISBN = " + isbn + ";";
            Form1.instance.ExcuteQuery(bookCopies);






            UpdateTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            admin_tables ad = new admin_tables();
            ad.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
