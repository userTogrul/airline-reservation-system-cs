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
    public partial class viewTickets : Form
    {
        public viewTickets()
        {
            InitializeComponent();

        }

        public int u_id;

        static String strcon = "Data Source = (DESCRIPTION = " +
        "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
        "(CONNECT_DATA =" +
        "(SERVER = DEDICATED)" +
        "(SERVICE_NAME = orcl)" +
        ")" +
        "); User ID=root; Password=root";
        OracleConnection conn = new OracleConnection(strcon);

        private void ViewTickets_Load(object sender, EventArgs e)
        {
            string query = "select tk_id as \"Ticket ID\",ps_id as \"Passenger ID\",tk_price as \"Price\",begining as \"From\",destination as \"To\",dept_time as \"Departure time\",ret_time as \"Return time\" from tickets t inner join flights f on t.fl_id = f.fl_id where t.ps_id in (select ps_id from passengers where user_id = " +  u_id + ")"; 
           try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter oda = new OracleDataAdapter(query, conn);
                DataTable dt = new DataTable();

                oda.Fill(dt);
                ticketsGridView.DataSource = dt;
                conn.Close();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
