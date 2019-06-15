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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        static String strcon = "Data Source = (DESCRIPTION = " +
        "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
        "(CONNECT_DATA =" +
        "(SERVER = DEDICATED)" +
        "(SERVICE_NAME = orcl)" +
        ")" +
        "); User ID=root; Password=root";

        OracleConnection conn = new OracleConnection(strcon);

        private void Button1_Click(object sender, EventArgs e)
        {
            string query = "select * from administrator where username = '" + username.Text +"' and password = '" + password.Text + "'";
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter oda = new OracleDataAdapter(query, conn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    AdminPanel ap = new AdminPanel();
                    this.Hide();
                    ap.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter username and password correctly", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
