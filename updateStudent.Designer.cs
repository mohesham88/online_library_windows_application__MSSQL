namespace online_library_mssql
{
    partial class updateStudent
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
            this.updatt = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updatt
            // 
            this.updatt.BackColor = System.Drawing.Color.OrangeRed;
            this.updatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.updatt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updatt.Location = new System.Drawing.Point(270, 310);
            this.updatt.Name = "updatt";
            this.updatt.Size = new System.Drawing.Size(393, 51);
            this.updatt.TabIndex = 19;
            this.updatt.Text = "update";
            this.updatt.UseVisualStyleBackColor = false;
            this.updatt.Click += new System.EventHandler(this.updatt_Click);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.email.Location = new System.Drawing.Point(272, 181);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(393, 26);
            this.email.TabIndex = 18;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.pass.Location = new System.Drawing.Point(270, 225);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(393, 26);
            this.pass.TabIndex = 16;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.name.Location = new System.Drawing.Point(270, 135);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(393, 26);
            this.name.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(135, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(135, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(135, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "name";
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.update.ForeColor = System.Drawing.Color.Tomato;
            this.update.Location = new System.Drawing.Point(123, 9);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(97, 31);
            this.update.TabIndex = 10;
            this.update.Text = "update";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Location = new System.Drawing.Point(657, 9);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(108, 51);
            this.back.TabIndex = 20;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // updateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.updatt);
            this.Controls.Add(this.email);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update);
            this.Name = "updateStudent";
            this.Text = "updateStudent";
            this.Load += new System.EventHandler(this.updateStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatt;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label update;
        private System.Windows.Forms.Button back;
    }
}