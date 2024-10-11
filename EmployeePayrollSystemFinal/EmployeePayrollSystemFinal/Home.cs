using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePayrollSystemFinal
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Employee Mainform = new Employee();
            this.Hide();
            Mainform.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Salary Mainform = new Salary();
            //this.Hide();
            //Mainform.Show();
        }
    }
}
