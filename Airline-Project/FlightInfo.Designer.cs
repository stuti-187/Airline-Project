
namespace Airline_Project
{
    partial class Flight
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flname_txt = new System.Windows.Forms.TextBox();
            this.src_txt = new System.Windows.Forms.TextBox();
            this.dst_txt = new System.Windows.Forms.TextBox();
            this.arrival_time = new System.Windows.Forms.TextBox();
            this.departure_time = new System.Windows.Forms.TextBox();
            this.class_txt = new System.Windows.Forms.TextBox();
            this.cost_txt = new System.Windows.Forms.TextBox();
            this.seats_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arrival Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Source";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Departure Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Flight Class";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Seats";
            // 
            // flname_txt
            // 
            this.flname_txt.Location = new System.Drawing.Point(165, 71);
            this.flname_txt.Name = "flname_txt";
            this.flname_txt.Size = new System.Drawing.Size(214, 20);
            this.flname_txt.TabIndex = 8;
            // 
            // src_txt
            // 
            this.src_txt.Location = new System.Drawing.Point(165, 105);
            this.src_txt.Name = "src_txt";
            this.src_txt.Size = new System.Drawing.Size(214, 20);
            this.src_txt.TabIndex = 9;
            // 
            // dst_txt
            // 
            this.dst_txt.Location = new System.Drawing.Point(165, 136);
            this.dst_txt.Name = "dst_txt";
            this.dst_txt.Size = new System.Drawing.Size(214, 20);
            this.dst_txt.TabIndex = 10;
            // 
            // arrival_time
            // 
            this.arrival_time.Location = new System.Drawing.Point(165, 173);
            this.arrival_time.Name = "arrival_time";
            this.arrival_time.Size = new System.Drawing.Size(214, 20);
            this.arrival_time.TabIndex = 11;
            // 
            // departure_time
            // 
            this.departure_time.Location = new System.Drawing.Point(165, 210);
            this.departure_time.Name = "departure_time";
            this.departure_time.Size = new System.Drawing.Size(214, 20);
            this.departure_time.TabIndex = 12;
            // 
            // class_txt
            // 
            this.class_txt.Location = new System.Drawing.Point(165, 254);
            this.class_txt.Name = "class_txt";
            this.class_txt.Size = new System.Drawing.Size(214, 20);
            this.class_txt.TabIndex = 13;
            // 
            // cost_txt
            // 
            this.cost_txt.Location = new System.Drawing.Point(165, 295);
            this.cost_txt.Name = "cost_txt";
            this.cost_txt.Size = new System.Drawing.Size(214, 20);
            this.cost_txt.TabIndex = 14;
            // 
            // seats_txt
            // 
            this.seats_txt.Location = new System.Drawing.Point(165, 335);
            this.seats_txt.Name = "seats_txt";
            this.seats_txt.Size = new System.Drawing.Size(214, 20);
            this.seats_txt.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Flight";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seats_txt);
            this.Controls.Add(this.cost_txt);
            this.Controls.Add(this.class_txt);
            this.Controls.Add(this.departure_time);
            this.Controls.Add(this.arrival_time);
            this.Controls.Add(this.dst_txt);
            this.Controls.Add(this.src_txt);
            this.Controls.Add(this.flname_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Flight";
            this.Text = "Flight Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox flname_txt;
        private System.Windows.Forms.TextBox src_txt;
        private System.Windows.Forms.TextBox dst_txt;
        private System.Windows.Forms.TextBox arrival_time;
        private System.Windows.Forms.TextBox departure_time;
        private System.Windows.Forms.TextBox class_txt;
        private System.Windows.Forms.TextBox cost_txt;
        private System.Windows.Forms.TextBox seats_txt;
        private System.Windows.Forms.Button button1;
    }
}