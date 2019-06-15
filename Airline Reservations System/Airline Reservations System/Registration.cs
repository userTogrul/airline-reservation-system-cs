using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.ManagedDataAccess.Client;

namespace Airline_Reservations_System
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        String strcon = "Data Source = (DESCRIPTION = " +
        "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
        "(CONNECT_DATA =" +
        "(SERVER = DEDICATED)" +
        "(SERVICE_NAME = orcl)" +
        ")" +
        "); User ID=root; Password=root";

       
        private void Button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(strcon);
            string query = "INSERT INTO users VALUES(user_id_inc.nextval,:username,:password,:answer,:question)";
            if (username.Text != "" && password.Text != "" && answer.Text != "")
            {
                if ((password.Text == password2.Text))
                {
                    try
                    {
                        conn.Open();
                        OracleCommand cmd = new OracleCommand(query, conn);
                        cmd.Parameters.Add(new OracleParameter(":username", username.Text));
                        cmd.Parameters.Add(new OracleParameter(":password", password.Text));
                        cmd.Parameters.Add(new OracleParameter(":answer", answer.Text));
                        cmd.Parameters.Add(new OracleParameter(":question", questionComboBox.Text));
                        if (Convert.ToBoolean(cmd.ExecuteNonQuery()))
                        {
                            MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                } else
                {
                    MessageBox.Show("Passwords are not matching", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("Please Enter data correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            string[] arr = new string[] { "What is your Favourite movie?", "What is your Favourite book?", "What high school did you attend?", "What is the name of your first school?", "What street did you grow up on?", "What was the make of your first car?" };
            questionComboBox.Items.AddRange(arr);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            this.Close();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = checkBox1.Checked ? false : true;
        }
    }
}
