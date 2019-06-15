using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Reservations_System
{
    public partial class userMainMenu : Form
    {
        public userMainMenu(string username, int id)
        {
            InitializeComponent();
            usernamelabel.Text = username;
            u_user = username;
            u_id = id;
        }

        string u_user;
        int u_id;

        private void UserMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void BookFlights_Click(object sender, EventArgs e)
        {
            userBookFlight ubf = new userBookFlight(u_id);
            userBookFlight.username = usernamelabel.Text;
            this.Hide();
            ubf.ShowDialog();
            this.Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            u_user = "";
            u_id = 0;

            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();

        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewTickets_Click(object sender, EventArgs e)
        {
            viewTickets vt = new viewTickets();
            vt.u_id = u_id;
            this.Hide();
            vt.ShowDialog();
            this.Close();
        }
    }
}
