namespace Airline_Reservations_System
{
    partial class buyTicket
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.postal = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateofbirth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.expiryDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cardCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cardNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dfsdfsfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buying tickets";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genderComboBox);
            this.groupBox1.Controls.Add(this.postal);
            this.groupBox1.Controls.Add(this.city);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.country);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateofbirth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.surname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(67, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 462);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer details";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Location = new System.Drawing.Point(140, 220);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(197, 25);
            this.genderComboBox.TabIndex = 4;
            // 
            // postal
            // 
            this.postal.Location = new System.Drawing.Point(140, 411);
            this.postal.Name = "postal";
            this.postal.Size = new System.Drawing.Size(197, 25);
            this.postal.TabIndex = 3;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(140, 367);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(197, 25);
            this.city.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Postal code";
            this.label9.Click += new System.EventHandler(this.Label4_Click);
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(140, 322);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(197, 25);
            this.country.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "City";
            this.label8.Click += new System.EventHandler(this.Label4_Click);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(140, 275);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(197, 25);
            this.phone.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Country";
            this.label7.Click += new System.EventHandler(this.Label4_Click);
            // 
            // dateofbirth
            // 
            this.dateofbirth.Location = new System.Drawing.Point(140, 166);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(197, 25);
            this.dateofbirth.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Phone number";
            this.label6.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Gender";
            this.label5.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date of birth";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(140, 112);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(197, 25);
            this.surname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(140, 56);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(197, 25);
            this.name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.expiryDate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cardCode);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cardNumber);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(492, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 237);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Details";
            // 
            // expiryDate
            // 
            this.expiryDate.Location = new System.Drawing.Point(108, 161);
            this.expiryDate.Name = "expiryDate";
            this.expiryDate.Size = new System.Drawing.Size(179, 25);
            this.expiryDate.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Expiry Date";
            // 
            // cardCode
            // 
            this.cardCode.Location = new System.Drawing.Point(108, 107);
            this.cardCode.Name = "cardCode";
            this.cardCode.Size = new System.Drawing.Size(179, 25);
            this.cardCode.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Card Code";
            // 
            // cardNumber
            // 
            this.cardNumber.Location = new System.Drawing.Point(108, 51);
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.Size = new System.Drawing.Size(179, 25);
            this.cardNumber.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Card Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(517, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 90);
            this.label13.TabIndex = 3;
            this.label13.Text = "VISA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(87, 580);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Select Class";
            this.label14.Click += new System.EventHandler(this.Label4_Click);
            // 
            // classComboBox
            // 
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.Location = new System.Drawing.Point(207, 580);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(107, 21);
            this.classComboBox.TabIndex = 4;
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassComboBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(90, 623);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Price";
            this.label15.Click += new System.EventHandler(this.Label4_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(204, 623);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(30, 13);
            this.price.TabIndex = 2;
            this.price.Text = "price";
            this.price.Click += new System.EventHandler(this.Label4_Click);
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.SystemColors.Window;
            this.buyButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyButton.Location = new System.Drawing.Point(634, 580);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(92, 41);
            this.buyButton.TabIndex = 5;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfsdfsfToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dfsdfsfToolStripMenuItem
            // 
            this.dfsdfsfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToSearchToolStripMenuItem});
            this.dfsdfsfToolStripMenuItem.Name = "dfsdfsfToolStripMenuItem";
            this.dfsdfsfToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.dfsdfsfToolStripMenuItem.Text = "Option";
            // 
            // backToSearchToolStripMenuItem
            // 
            this.backToSearchToolStripMenuItem.Name = "backToSearchToolStripMenuItem";
            this.backToSearchToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.backToSearchToolStripMenuItem.Text = "Back to search";
            this.backToSearchToolStripMenuItem.Click += new System.EventHandler(this.BackToSearchToolStripMenuItem_Click);
            // 
            // buyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(828, 681);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "buyTicket";
            this.Text = "Airline Reservations System";
            this.Load += new System.EventHandler(this.BuyTicket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dateofbirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox postal;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cardNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox expiryDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cardCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dfsdfsfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToSearchToolStripMenuItem;
    }
}