using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeePayrollSystemFinal
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startpos = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            myprogressbar.Value = startpos;
            if (myprogressbar.Value == 100)
            {
                myprogressbar.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();


            }
        }

        private void myprogressbar_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
