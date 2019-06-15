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
    public partial class buyTicket : Form
    {
        public buyTicket(int u_id, int fl_id)
        {
            InitializeComponent();
            this.u_id = u_id;
            this.fl_id = fl_id;
        }

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

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void BuyTicket_Load(object sender, EventArgs e)
        {
            string[] ticketClass = new string[] {"economy","business"};
            string[] gender = new string[] { "Male", "Female" };
            classComboBox.Items.AddRange(ticketClass);
            genderComboBox.Items.AddRange(gender);
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if(
                    name.Text != "" &&
                    surname.Text !="" &&
                    dateofbirth.Text != ""&&
                    genderComboBox.Text != "" &&
                    phone.Text != "" &&
                    country.Text != ""&&
                    city.Text != "" &&
                    postal.Text != "" &&
                    cardNumber.Text != "" &&
                    cardCode.Text != ""&&
                    expiryDate.Text !=""
                    )
                {

                    //passengers
                    OracleCommand cmd = new OracleCommand("INSERT INTO passengers VALUES(ps_id_inc.nextval,'" + name.Text +
                        "','" + surname.Text + "','" + dateofbirth.Text + "','"
                        + genderComboBox.Text +
                        "',"
                        + phone.Text +
                        ",'"
                        + country.Text +
                        "','"
                        + city.Text +
                        "','"
                        + postal.Text +
                        "',"
                        + u_id +
                        ")", conn);
                    cmd.ExecuteNonQuery();

                    //payments table

                    OracleCommand cmd2 = new OracleCommand("INSERT INTO payment_details VALUES(pym_id_inc.nextval,ps_id_inc.currval,'"
                        + cardNumber.Text +
                        "','"
                        + cardCode.Text +
                        "','"
                        + expiryDate.Text +
                        "')", conn);

                    cmd2.ExecuteNonQuery();

                    //tickets table

                    OracleCommand cmd3 = new OracleCommand("INSERT INTO tickets VALUES(tk_id_inc.nextval," + fl_id + ","
                        + price.Text +
                        ",PS_ID_INC.currval)", conn);

                    cmd3.ExecuteNonQuery();

                    //business econom

                    string query = "";

                    if (classComboBox.Text == "business")
                    {
                        query = "INSERT INTO business_class VALUES(bs_id_inc.nextval,ps_id_inc.currval)";
                    }
                    else if (classComboBox.Text == "economy")
                    {
                        query = "INSERT INTO economy_class VALUES(ec_id_inc.nextval,ps_id_inc.currval)";
                    }
                    OracleCommand cmd4 = new OracleCommand(query, conn);

                    if(cmd4.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Ticket Purchased", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userBookFlight ubf = new userBookFlight(u_id);
                        this.Hide();
                        ubf.ShowDialog();
                        this.Close();
                    } else
                    {
                        MessageBox.Show("Error occured");
                    }
                    conn.Close();

                } else
                {
                    MessageBox.Show("Please fill all boxes","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BackToSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userBookFlight ubf = new userBookFlight(u_id);
            this.Hide();
            ubf.ShowDialog();
            this.Close();
        }

        private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                string row = "";
                conn.Open();
                if(classComboBox.Text == "business")
                {
                    query = "SELECT lf_price_bsn FROM flights where fl_id = " + fl_id;
                    row = "lf_price_bsn";
                } else if(classComboBox.Text == "economy")
                {
                    query = "SELECT lf_price_eco FROM flights where fl_id = " + fl_id;
                    row = "lf_price_eco";
                }
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter oda = new OracleDataAdapter(query, conn);

                DataSet ds = new DataSet();

                oda.Fill(ds);

                price.Text = ds.Tables[0].Rows[0][row].ToString();
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
