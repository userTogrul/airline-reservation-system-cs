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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AdminManageAircrafts mac = new AdminManageAircrafts();
            this.Hide();
            mac.ShowDialog();
            this.Close();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
