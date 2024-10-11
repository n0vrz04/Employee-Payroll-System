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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;

            if (logincheck(userName, password))
            {
                Home Mainform = new Home();
                this.Hide();
                Mainform.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool logincheck(string userName, string password)
        {

            return userName == "admin" && password == "admin";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearText();
        }
        public void clearText()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }


}

