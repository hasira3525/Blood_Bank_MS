using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_01
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-PT3JD6VE;Initial Catalog=BloodBankDb;Integrated Security=True");
        private void label4_Click(object sender, EventArgs e)
        {
            AdminLogin Adm = new AdminLogin();
            Adm.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            // Login Button

            if (!(EmpIdTb.Text.All(char.IsLetterOrDigit)))
            {
                MessageBox.Show("Username cannot have Symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from EmployeeTbl where EmpId = '" + EmpIdTb.Text + "' and EmpPass ='" + EmpPassTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Mainform Main = new Mainform();
                    Main.Show();
                    this.Hide();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Con.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmpPassTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
