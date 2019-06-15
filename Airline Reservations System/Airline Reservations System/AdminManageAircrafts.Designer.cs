namespace Airline_Reservations_System
{
    partial class AdminManageAircrafts
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.aiName = new System.Windows.Forms.TextBox();
            this.nbSeats = new System.Windows.Forms.TextBox();
            this.mnCompany = new System.Windows.Forms.TextBox();
            this.mnDate = new System.Windows.Forms.TextBox();
            this.acName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToAdminPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(17, 91);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "aircraftId";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "aircraftName";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "aircraftSeats";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "manufacturerCompany";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "manufacturingDate";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "aircraft ID";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // aiName
            // 
            this.aiName.Location = new System.Drawing.Point(279, 400);
            this.aiName.Name = "aiName";
            this.aiName.Size = new System.Drawing.Size(100, 20);
            this.aiName.TabIndex = 2;
            this.aiName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // nbSeats
            // 
            this.nbSeats.Location = new System.Drawing.Point(453, 400);
            this.nbSeats.Name = "nbSeats";
            this.nbSeats.Size = new System.Drawing.Size(100, 20);
            this.nbSeats.TabIndex = 2;
            this.nbSeats.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // mnCompany
            // 
            this.mnCompany.Location = new System.Drawing.Point(626, 400);
            this.mnCompany.Name = "mnCompany";
            this.mnCompany.Size = new System.Drawing.Size(100, 20);
            this.mnCompany.TabIndex = 2;
            this.mnCompany.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // mnDate
            // 
            this.mnDate.Location = new System.Drawing.Point(279, 463);
            this.mnDate.Name = "mnDate";
            this.mnDate.Size = new System.Drawing.Size(100, 20);
            this.mnDate.TabIndex = 2;
            this.mnDate.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // acName
            // 
            this.acName.AutoSize = true;
            this.acName.Location = new System.Drawing.Point(276, 372);
            this.acName.Name = "acName";
            this.acName.Size = new System.Drawing.Size(71, 13);
            this.acName.TabIndex = 1;
            this.acName.Text = "Aircraft Name";
            this.acName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number of seats";
            this.label3.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Manufacturer Company";
            this.label4.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Manufacturing Date";
            this.label5.Click += new System.EventHandler(this.Label1_Click);
            // 
            // showButton
            // 
            this.showButton.FlatAppearance.BorderSize = 2;
            this.showButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showButton.Location = new System.Drawing.Point(344, 500);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(91, 38);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "SHOW";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.FlatAppearance.BorderSize = 2;
            this.updateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(538, 500);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(91, 38);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatAppearance.BorderSize = 2;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(635, 500);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(91, 38);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.FlatAppearance.BorderSize = 2;
            this.insertButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertButton.Location = new System.Drawing.Point(441, 500);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(91, 38);
            this.insertButton.TabIndex = 3;
            this.insertButton.Text = "INSERT";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(50, 400);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 2;
            this.id.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Manage aircrafts";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToAdminPanelToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // backToAdminPanelToolStripMenuItem
            // 
            this.backToAdminPanelToolStripMenuItem.Name = "backToAdminPanelToolStripMenuItem";
            this.backToAdminPanelToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.backToAdminPanelToolStripMenuItem.Text = "Back to Admin Panel";
            this.backToAdminPanelToolStripMenuItem.Click += new System.EventHandler(this.BackToAdminPanelToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 61);
            this.panel1.TabIndex = 6;
            // 
            // AdminManageAircrafts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(805, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.mnDate);
            this.Controls.Add(this.mnCompany);
            this.Controls.Add(this.id);
            this.Controls.Add(this.nbSeats);
            this.Controls.Add(this.aiName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.acName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminManageAircrafts";
            this.Text = "Airline Reservations System";
            this.Load += new System.EventHandler(this.AdminManageAircrafts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aiName;
        private System.Windows.Forms.TextBox nbSeats;
        private System.Windows.Forms.TextBox mnCompany;
        private System.Windows.Forms.TextBox mnDate;
        private System.Windows.Forms.Label acName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToAdminPanelToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}