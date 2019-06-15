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
    public partial class AdminManageAircrafts : Form
    {
        public AdminManageAircrafts()
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


        private void AdminManageAircrafts_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Id_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            showData();
        }

       
        void showData()
        {
            dataGridView1.Rows.Clear();
            try
            {
                string query = "select * from aircrafts";
                OracleCommand cmd = new OracleCommand(query, conn);
                conn.Open();
                OracleDataAdapter oda = new OracleDataAdapter(query, conn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    fillGrid(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        void insertData()
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("insert into aircrafts values(:ai_id,:ai_name,:ai_seats,:ai_company,:ai_date)", conn);
                cmd.Parameters.Add(new OracleParameter(":ai_id", Convert.ToInt32(id.Text)));
                cmd.Parameters.Add(new OracleParameter(":ai_name", aiName.Text));
                cmd.Parameters.Add(new OracleParameter(":ai_seats", Convert.ToInt32(nbSeats.Text)));
                cmd.Parameters.Add(new OracleParameter(":ai_company", mnCompany.Text));
                cmd.Parameters.Add(new OracleParameter(":ai_date", mnDate.Text));

                cmd.ExecuteNonQuery();
                conn.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            showData();
        }

        void updateData() {
            string query = "update aircrafts set plane_name = '" + acName.Text + "', seats=" + Convert.ToInt32(nbSeats.Text) + ", MF_COMPANY='" + mnCompany.Text + "',MF_DT='" + mnDate.Text + "' where aircr_id=" + Convert.ToInt32(id.Text);
            
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            showData();

        }

        void deleteData()
        {
            string query = "delete from AIRCRAFTS where AIRCR_ID = " + Convert.ToInt32(id.Text);
            try
            {

                conn.Open();
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();


            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            showData();
        }


        void fillGrid(string aircraftID, string aircraftName, string aircraftSeats, string manufacturerCompany, string manufacturingDate)
        {
            dataGridView1.Rows.Add(aircraftID, aircraftName, aircraftSeats, manufacturerCompany, manufacturingDate);
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            aiName.Text =  dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            nbSeats.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            mnCompany.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            mnDate.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Substring(0,11);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void BackToAdminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            this.Hide();
            ap.ShowDialog();
            this.Close();
        }
    }
}
