using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_01
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(AdminPassTb.Text == "")
            {
                MessageBox.Show("Enter The Admin Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if(AdminPassTb.Text == "Password")     //Admin Password
            {
                Employee Emp = new Employee();
                Emp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password..! Please contact System Admin","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AdminPassTb.Text = "";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
