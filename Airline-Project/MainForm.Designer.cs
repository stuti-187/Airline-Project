
namespace Airline_Project
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFlightDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFlightInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAdminToolStripMenuItem,
            this.addFlightDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addAdminToolStripMenuItem
            // 
            this.addAdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAdminToolStripMenuItem});
            this.addAdminToolStripMenuItem.Name = "addAdminToolStripMenuItem";
            this.addAdminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.addAdminToolStripMenuItem.Text = "Admin";
            // 
            // addFlightDetailsToolStripMenuItem
            // 
            this.addFlightDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFlightInfoToolStripMenuItem});
            this.addFlightDetailsToolStripMenuItem.Name = "addFlightDetailsToolStripMenuItem";
            this.addFlightDetailsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.addFlightDetailsToolStripMenuItem.Text = "Flight Details";
            // 
            // addFlightInfoToolStripMenuItem
            // 
            this.addFlightInfoToolStripMenuItem.Name = "addFlightInfoToolStripMenuItem";
            this.addFlightInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addFlightInfoToolStripMenuItem.Text = "Add Flight Info";
            this.addFlightInfoToolStripMenuItem.Click += new System.EventHandler(this.addFlightInfoToolStripMenuItem_Click);
            // 
            // addNewAdminToolStripMenuItem
            // 
            this.addNewAdminToolStripMenuItem.Name = "addNewAdminToolStripMenuItem";
            this.addNewAdminToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewAdminToolStripMenuItem.Text = "Add New Admin";
            this.addNewAdminToolStripMenuItem.Click += new System.EventHandler(this.addNewAdminToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 660);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFlightDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFlightInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAdminToolStripMenuItem;
    }
}