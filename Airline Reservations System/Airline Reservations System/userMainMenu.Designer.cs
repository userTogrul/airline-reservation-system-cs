namespace Airline_Reservations_System
{
    partial class userMainMenu
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelReserv = new System.Windows.Forms.Button();
            this.viewTickets = new System.Windows.Forms.Button();
            this.bookFlights = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.exitToolStripMenuItem.Text = "Options";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "&Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelReserv);
            this.groupBox1.Controls.Add(this.viewTickets);
            this.groupBox1.Controls.Add(this.bookFlights);
            this.groupBox1.Location = new System.Drawing.Point(304, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 232);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cancelReserv
            // 
            this.cancelReserv.BackColor = System.Drawing.SystemColors.Window;
            this.cancelReserv.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelReserv.Location = new System.Drawing.Point(20, 147);
            this.cancelReserv.Name = "cancelReserv";
            this.cancelReserv.Size = new System.Drawing.Size(204, 53);
            this.cancelReserv.TabIndex = 0;
            this.cancelReserv.Text = "Cancellation";
            this.cancelReserv.UseVisualStyleBackColor = false;
            // 
            // viewTickets
            // 
            this.viewTickets.BackColor = System.Drawing.SystemColors.Window;
            this.viewTickets.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewTickets.Location = new System.Drawing.Point(20, 90);
            this.viewTickets.Name = "viewTickets";
            this.viewTickets.Size = new System.Drawing.Size(204, 51);
            this.viewTickets.TabIndex = 0;
            this.viewTickets.Text = "View Tickets";
            this.viewTickets.UseVisualStyleBackColor = false;
            this.viewTickets.Click += new System.EventHandler(this.ViewTickets_Click);
            // 
            // bookFlights
            // 
            this.bookFlights.BackColor = System.Drawing.SystemColors.Window;
            this.bookFlights.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookFlights.Location = new System.Drawing.Point(20, 30);
            this.bookFlights.Name = "bookFlights";
            this.bookFlights.Size = new System.Drawing.Size(204, 54);
            this.bookFlights.TabIndex = 0;
            this.bookFlights.Text = "Book Flights";
            this.bookFlights.UseVisualStyleBackColor = false;
            this.bookFlights.Click += new System.EventHandler(this.BookFlights_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(77, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernamelabel.Location = new System.Drawing.Point(180, 81);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(22, 23);
            this.usernamelabel.TabIndex = 2;
            this.usernamelabel.Text = "u";
            // 
            // userMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "userMainMenu";
            this.Text = "Airline Reservations System";
            this.Load += new System.EventHandler(this.UserMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelReserv;
        private System.Windows.Forms.Button viewTickets;
        private System.Windows.Forms.Button bookFlights;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}