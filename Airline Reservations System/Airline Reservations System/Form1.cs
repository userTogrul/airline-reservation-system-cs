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
    public partial class Form1 : Form
    {
        public Form1()
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
            string query = "select * from users where u_username = '" + username.Text.Trim() + "' and u_password = '" + password.Text.Trim() + "'";
            try { 
            conn.Open();
            OracleCommand cmd = new OracleCommand(query,conn);
            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            oda.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0) {
                    string username = ds.Tables[0].Rows[0]["U_USERNAME"].ToString();
                    int id = Convert.ToInt32(ds.Tables[0].Rows[0]["USER_ID"]);
                    userMainMenu umm = new userMainMenu(username, id);
                    this.Hide();
                    umm.ShowDialog();
                    this.Close();
                } 
                else {
                    MessageBox.Show("Please enter username and password correctly", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());    
            }

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
                password.UseSystemPasswordChar = false;
            else
                password.UseSystemPasswordChar = true;
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration rg = new Registration();
            rg.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LoginAsAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            this.Hide();
            al.ShowDialog();
            this.Close();
        }
    }
}
