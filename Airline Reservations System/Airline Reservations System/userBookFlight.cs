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
    public partial class userBookFlight : Form
    {
        public userBookFlight(int id)
        {
            InitializeComponent();
            u_id = id;
            
        }
        static public string username;
        int u_id;
        int fl_id;
        

        static String strcon = "Data Source = (DESCRIPTION = " +
        "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
        "(CONNECT_DATA =" +
        "(SERVER = DEDICATED)" +
        "(SERVICE_NAME = orcl)" +
        ")" +
        "); User ID=root; Password=root";

        OracleConnection conn = new OracleConnection(strcon);
        
        private void ViewTickets_Click(object sender, EventArgs e)
        {
            string query = "select * from flights where (begining = '" + from.Text + "' and destination = '" + to.Text + "')and(dept_time = '" + departure.Text + "' and ret_time = '" + returnBack.Text + "')";
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter oda = new OracleDataAdapter(query, conn);

                DataSet ds = new DataSet();

                oda.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    fl_id = Convert.ToInt32(ds.Tables[0].Rows[0]["fl_id"]);
                    string str = ds.Tables[0].Rows[0]["LF_PRICE_ECO"].ToString();
                    price.Text = str;
                }
                else
                {
                    price.Text = "Not Found";
                }
                conn.Close();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void UserBookFlight_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GetTheTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buyTicket bt = new buyTicket(u_id, fl_id);
            this.Hide();
            bt.ShowDialog();
            this.Close();
        }

        private void MainMenuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            userMainMenu umm = new userMainMenu(username,u_id);
            this.Hide();
            umm.ShowDialog();
            this.Close();
        }
    }
}
