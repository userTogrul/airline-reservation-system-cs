namespace Airline_Reservations_System
{
    partial class userBookFlight
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
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getTheTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.departure = new System.Windows.Forms.TextBox();
            this.returnBack = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.viewTickets = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getTheTicketToolStripMenuItem,
            this.mainMenuToolStripMenuItem1});
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.mainMenuToolStripMenuItem.Text = "Options";
            // 
            // getTheTicketToolStripMenuItem
            // 
            this.getTheTicketToolStripMenuItem.Name = "getTheTicketToolStripMenuItem";
            this.getTheTicketToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.getTheTicketToolStripMenuItem.Text = "Get the ticket";
            this.getTheTicketToolStripMenuItem.Click += new System.EventHandler(this.GetTheTicketToolStripMenuItem_Click);
            // 
            // mainMenuToolStripMenuItem1
            // 
            this.mainMenuToolStripMenuItem1.Name = "mainMenuToolStripMenuItem1";
            this.mainMenuToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.mainMenuToolStripMenuItem1.Text = "Main menu";
            this.mainMenuToolStripMenuItem1.Click += new System.EventHandler(this.MainMenuToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flights: search for flight";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(6, 45);
            this.from.Multiline = true;
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(230, 42);
            this.from.TabIndex = 2;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(339, 45);
            this.to.Multiline = true;
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(230, 42);
            this.to.TabIndex = 2;
            // 
            // departure
            // 
            this.departure.Location = new System.Drawing.Point(6, 143);
            this.departure.Multiline = true;
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(230, 42);
            this.departure.TabIndex = 2;
            // 
            // returnBack
            // 
            this.returnBack.Location = new System.Drawing.Point(339, 143);
            this.returnBack.Multiline = true;
            this.returnBack.Name = "returnBack";
            this.returnBack.Size = new System.Drawing.Size(230, 42);
            this.returnBack.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(104, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price from:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(190, 379);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(40, 17);
            this.price.TabIndex = 1;
            this.price.Text = "price";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.to);
            this.groupBox1.Controls.Add(this.from);
            this.groupBox1.Controls.Add(this.returnBack);
            this.groupBox1.Controls.Add(this.departure);
            this.groupBox1.Location = new System.Drawing.Point(122, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 199);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label6.Location = new System.Drawing.Point(336, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Return";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label5.Location = new System.Drawing.Point(7, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Departure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label4.Location = new System.Drawing.Point(336, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "From";
            // 
            // viewTickets
            // 
            this.viewTickets.BackColor = System.Drawing.SystemColors.Window;
            this.viewTickets.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewTickets.Location = new System.Drawing.Point(578, 367);
            this.viewTickets.Name = "viewTickets";
            this.viewTickets.Size = new System.Drawing.Size(92, 41);
            this.viewTickets.TabIndex = 3;
            this.viewTickets.Text = "Search";
            this.viewTickets.UseVisualStyleBackColor = false;
            this.viewTickets.Click += new System.EventHandler(this.ViewTickets_Click);
            // 
            // userBookFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewTickets);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "userBookFlight";
            this.Text = " Airline Reservations System";
            this.Load += new System.EventHandler(this.UserBookFlight_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox departure;
        private System.Windows.Forms.TextBox returnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.ToolStripMenuItem getTheTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button viewTickets;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}