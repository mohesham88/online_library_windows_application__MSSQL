namespace online_library_mssql
{
    partial class admin_panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TABLE = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.TITLE = new System.Windows.Forms.TextBox();
            this.YEAR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PUBLISHER_NAME = new System.Windows.Forms.TextBox();
            this.AUTHOR_NAME = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CATEGORY = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.NUMBER_OF_COPIES = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE)).BeginInit();
            this.SuspendLayout();
            // 
            // TABLE
            // 
            this.TABLE.AllowUserToAddRows = false;
            this.TABLE.AllowUserToDeleteRows = false;
            this.TABLE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TABLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE.Location = new System.Drawing.Point(33, 286);
            this.TABLE.MultiSelect = false;
            this.TABLE.Name = "TABLE";
            this.TABLE.ReadOnly = true;
            this.TABLE.RowHeadersWidth = 51;
            this.TABLE.RowTemplate.Height = 24;
            this.TABLE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TABLE.Size = new System.Drawing.Size(561, 254);
            this.TABLE.TabIndex = 0;
            this.TABLE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(673, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(673, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(673, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 80);
            this.button3.TabIndex = 3;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ISBN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year:";
            // 
            // ISBN
            // 
            this.ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN.Location = new System.Drawing.Point(103, 21);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(177, 34);
            this.ISBN.TabIndex = 7;
            // 
            // TITLE
            // 
            this.TITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE.Location = new System.Drawing.Point(103, 66);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(177, 34);
            this.TITLE.TabIndex = 8;
            // 
            // YEAR
            // 
            this.YEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YEAR.Location = new System.Drawing.Point(103, 111);
            this.YEAR.Name = "YEAR";
            this.YEAR.Size = new System.Drawing.Size(177, 34);
            this.YEAR.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Publisher Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Author Name:";
            // 
            // PUBLISHER_NAME
            // 
            this.PUBLISHER_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PUBLISHER_NAME.Location = new System.Drawing.Point(459, 21);
            this.PUBLISHER_NAME.Name = "PUBLISHER_NAME";
            this.PUBLISHER_NAME.Size = new System.Drawing.Size(177, 34);
            this.PUBLISHER_NAME.TabIndex = 12;
            // 
            // AUTHOR_NAME
            // 
            this.AUTHOR_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AUTHOR_NAME.Location = new System.Drawing.Point(459, 63);
            this.AUTHOR_NAME.Name = "AUTHOR_NAME";
            this.AUTHOR_NAME.Size = new System.Drawing.Size(177, 34);
            this.AUTHOR_NAME.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Category NAME:";
            // 
            // CATEGORY
            // 
            this.CATEGORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CATEGORY.Location = new System.Drawing.Point(459, 105);
            this.CATEGORY.Name = "CATEGORY";
            this.CATEGORY.Size = new System.Drawing.Size(177, 34);
            this.CATEGORY.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(626, 487);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 53);
            this.button4.TabIndex = 16;
            this.button4.Text = "Other Tables";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Number of copies:";
            // 
            // NUMBER_OF_COPIES
            // 
            this.NUMBER_OF_COPIES.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUMBER_OF_COPIES.Location = new System.Drawing.Point(292, 199);
            this.NUMBER_OF_COPIES.Name = "NUMBER_OF_COPIES";
            this.NUMBER_OF_COPIES.Size = new System.Drawing.Size(177, 34);
            this.NUMBER_OF_COPIES.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(715, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 52);
            this.button5.TabIndex = 19;
            this.button5.Text = "LOG OUT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.NUMBER_OF_COPIES);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CATEGORY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AUTHOR_NAME);
            this.Controls.Add(this.PUBLISHER_NAME);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.YEAR);
            this.Controls.Add(this.TITLE);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TABLE);
            this.Name = "admin_panel";
            this.Text = "admin_panel";
            this.Load += new System.EventHandler(this.admin_panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TABLE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.TextBox TITLE;
        private System.Windows.Forms.TextBox YEAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PUBLISHER_NAME;
        private System.Windows.Forms.TextBox AUTHOR_NAME;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CATEGORY;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NUMBER_OF_COPIES;
        private System.Windows.Forms.Button button5;
    }
}