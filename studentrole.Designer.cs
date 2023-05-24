namespace online_library_mssql
{
    partial class studentrole
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bookname = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.paneldrop = new System.Windows.Forms.Panel();
            this.category = new System.Windows.Forms.Button();
            this.year = new System.Windows.Forms.Button();
            this.ISBN = new System.Windows.Forms.Button();
            this.publisher = new System.Windows.Forms.Button();
            this.titel = new System.Windows.Forms.Button();
            this.serch_by = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update_info = new System.Windows.Forms.Button();
            this.oout = new System.Windows.Forms.Button();
            this.paneldrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "welcome in fcai libarary";
            // 
            // bookname
            // 
            this.bookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.bookname.Location = new System.Drawing.Point(12, 137);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(424, 31);
            this.bookname.TabIndex = 1;
            this.bookname.TextChanged += new System.EventHandler(this.bookname_TextChanged);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.search.Location = new System.Drawing.Point(453, 126);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(147, 46);
            this.search.TabIndex = 2;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // paneldrop
            // 
            this.paneldrop.Controls.Add(this.category);
            this.paneldrop.Controls.Add(this.year);
            this.paneldrop.Controls.Add(this.ISBN);
            this.paneldrop.Controls.Add(this.publisher);
            this.paneldrop.Controls.Add(this.titel);
            this.paneldrop.Controls.Add(this.serch_by);
            this.paneldrop.Location = new System.Drawing.Point(631, 126);
            this.paneldrop.MaximumSize = new System.Drawing.Size(157, 253);
            this.paneldrop.MinimumSize = new System.Drawing.Size(157, 47);
            this.paneldrop.Name = "paneldrop";
            this.paneldrop.Size = new System.Drawing.Size(157, 47);
            this.paneldrop.TabIndex = 3;
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.category.Dock = System.Windows.Forms.DockStyle.Top;
            this.category.FlatAppearance.BorderSize = 0;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.category.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.category.Location = new System.Drawing.Point(0, 209);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(157, 41);
            this.category.TabIndex = 8;
            this.category.Text = "category";
            this.category.UseVisualStyleBackColor = false;
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.year.Dock = System.Windows.Forms.DockStyle.Top;
            this.year.FlatAppearance.BorderSize = 0;
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.year.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.year.Location = new System.Drawing.Point(0, 168);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(157, 41);
            this.year.TabIndex = 7;
            this.year.Text = "year";
            this.year.UseVisualStyleBackColor = false;
            this.year.Click += new System.EventHandler(this.year_Click);
            // 
            // ISBN
            // 
            this.ISBN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ISBN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ISBN.FlatAppearance.BorderSize = 0;
            this.ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.ISBN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ISBN.Location = new System.Drawing.Point(0, 127);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(157, 41);
            this.ISBN.TabIndex = 6;
            this.ISBN.Text = "ISBN";
            this.ISBN.UseVisualStyleBackColor = false;
            this.ISBN.Click += new System.EventHandler(this.ISBN_Click);
            // 
            // publisher
            // 
            this.publisher.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.publisher.Dock = System.Windows.Forms.DockStyle.Top;
            this.publisher.FlatAppearance.BorderSize = 0;
            this.publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.publisher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.publisher.Location = new System.Drawing.Point(0, 86);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(157, 41);
            this.publisher.TabIndex = 5;
            this.publisher.Text = "publisher";
            this.publisher.UseVisualStyleBackColor = false;
            this.publisher.Click += new System.EventHandler(this.publisher_Click);
            // 
            // titel
            // 
            this.titel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.titel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titel.Location = new System.Drawing.Point(0, 46);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(157, 40);
            this.titel.TabIndex = 4;
            this.titel.Text = "Titel";
            this.titel.UseVisualStyleBackColor = false;
            this.titel.Click += new System.EventHandler(this.titel_Click);
            // 
            // serch_by
            // 
            this.serch_by.BackColor = System.Drawing.Color.OrangeRed;
            this.serch_by.Dock = System.Windows.Forms.DockStyle.Top;
            this.serch_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.serch_by.Location = new System.Drawing.Point(0, 0);
            this.serch_by.Name = "serch_by";
            this.serch_by.Size = new System.Drawing.Size(157, 46);
            this.serch_by.TabIndex = 3;
            this.serch_by.Text = "serch by";
            this.serch_by.UseVisualStyleBackColor = false;
            this.serch_by.Click += new System.EventHandler(this.serch_by_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 171);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // update_info
            // 
            this.update_info.BackColor = System.Drawing.Color.SpringGreen;
            this.update_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.update_info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.update_info.Location = new System.Drawing.Point(438, 1);
            this.update_info.Name = "update_info";
            this.update_info.Size = new System.Drawing.Size(238, 46);
            this.update_info.TabIndex = 5;
            this.update_info.Text = "update info";
            this.update_info.UseVisualStyleBackColor = false;
            this.update_info.Click += new System.EventHandler(this.update_info_Click);
            // 
            // oout
            // 
            this.oout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.oout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.oout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oout.Location = new System.Drawing.Point(682, 1);
            this.oout.Name = "oout";
            this.oout.Size = new System.Drawing.Size(106, 46);
            this.oout.TabIndex = 6;
            this.oout.Text = "OUT";
            this.oout.UseVisualStyleBackColor = false;
            this.oout.Click += new System.EventHandler(this.oout_Click);
            // 
            // studentrole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oout);
            this.Controls.Add(this.update_info);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.paneldrop);
            this.Controls.Add(this.search);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.label1);
            this.Name = "studentrole";
            this.Text = "studentrole";
            this.paneldrop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Panel paneldrop;
        private System.Windows.Forms.Button publisher;
        private System.Windows.Forms.Button titel;
        private System.Windows.Forms.Button serch_by;
        private System.Windows.Forms.Button category;
        private System.Windows.Forms.Button year;
        private System.Windows.Forms.Button ISBN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update_info;
        private System.Windows.Forms.Button oout;
    }
}