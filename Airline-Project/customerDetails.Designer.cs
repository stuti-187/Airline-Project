
namespace Airline_Project
{
    partial class customerDetails
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
            this.cstmr_username = new System.Windows.Forms.Label();
            this.cstmr_password = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phn_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.addr_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.birthdate_picker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usrnametxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cstmr_username
            // 
            this.cstmr_username.AutoSize = true;
            this.cstmr_username.Location = new System.Drawing.Point(70, 54);
            this.cstmr_username.Name = "cstmr_username";
            this.cstmr_username.Size = new System.Drawing.Size(35, 13);
            this.cstmr_username.TabIndex = 0;
            this.cstmr_username.Text = "Name";
            this.cstmr_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // cstmr_password
            // 
            this.cstmr_password.AutoSize = true;
            this.cstmr_password.Location = new System.Drawing.Point(72, 101);
            this.cstmr_password.Name = "cstmr_password";
            this.cstmr_password.Size = new System.Drawing.Size(45, 13);
            this.cstmr_password.TabIndex = 1;
            this.cstmr_password.Text = "Birthday";
            this.cstmr_password.Click += new System.EventHandler(this.cstmr_password_Click);
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(158, 51);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(197, 20);
            this.name_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // phn_txt
            // 
            this.phn_txt.Location = new System.Drawing.Point(158, 141);
            this.phn_txt.Name = "phn_txt";
            this.phn_txt.Size = new System.Drawing.Size(197, 20);
            this.phn_txt.TabIndex = 7;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(158, 183);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(197, 20);
            this.email_txt.TabIndex = 8;
            // 
            // addr_txt
            // 
            this.addr_txt.Location = new System.Drawing.Point(158, 225);
            this.addr_txt.Multiline = true;
            this.addr_txt.Name = "addr_txt";
            this.addr_txt.Size = new System.Drawing.Size(197, 70);
            this.addr_txt.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // birthdate_picker
            // 
            this.birthdate_picker.Location = new System.Drawing.Point(158, 95);
            this.birthdate_picker.Name = "birthdate_picker";
            this.birthdate_picker.Size = new System.Drawing.Size(197, 20);
            this.birthdate_picker.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password";
            // 
            // usrnametxt
            // 
            this.usrnametxt.Location = new System.Drawing.Point(158, 322);
            this.usrnametxt.Name = "usrnametxt";
            this.usrnametxt.Size = new System.Drawing.Size(197, 20);
            this.usrnametxt.TabIndex = 14;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(158, 363);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(197, 20);
            this.passtxt.TabIndex = 15;
            // 
            // customerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 481);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usrnametxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.birthdate_picker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addr_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.phn_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.cstmr_password);
            this.Controls.Add(this.cstmr_username);
            this.Name = "customerDetails";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cstmr_username;
        private System.Windows.Forms.Label cstmr_password;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phn_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox addr_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker birthdate_picker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usrnametxt;
        private System.Windows.Forms.TextBox passtxt;
    }
}