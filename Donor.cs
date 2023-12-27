using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Test_01
{
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-PT3JD6VE;Initial Catalog=BloodBankDb;Integrated Security=True");

        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            DNameTb.Text = "";
            DAgeTb.Text = "";
            DPhoneTb.Text = "";
            DGenCb.SelectedIndex = -1;
            DBGroupCb.SelectedIndex = -1;
            DAddressTb.Text = "";
        }
        private void bt_save_Click(object sender, EventArgs e)
            //Sava Button
        {
            if (DNameTb.Text == "" || DAgeTb.Text == "" || DPhoneTb.Text == "" || DGenCb.SelectedIndex == -1 || DBGroupCb.SelectedIndex == -1 || DAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DNameTb.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name cannot have Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!(DNameTb.Text.All(char.IsLetterOrDigit)))
            {
                MessageBox.Show("Name cannot have Symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DAgeTb.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Age cannot have Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(DAgeTb.Text.Length > 2)
            {
                MessageBox.Show("Please Enter the Correct Age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!(Regex.IsMatch(DPhoneTb.Text, @"^(?:7 |0| (?:\+94))[0-9]{8,9}$")))
            {
                MessageBox.Show("Tp must have 10 Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(DPhoneTb.Text.All(char.IsLetterOrDigit)))
            {
                MessageBox.Show("TP cannot have Symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DPhoneTb.Text.Any(char.IsLetter))
            {
                MessageBox.Show("TP cannot have Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int x = 0;
                    x += 1;

                    string query = "insert into DonorTbl values('" + DNameTb.Text + "', '" + DAgeTb.Text + "','" + DGenCb.SelectedItem.ToString() + "','" + DPhoneTb.Text + "', '" + DAddressTb.Text + "','" + DBGroupCb.SelectedItem.ToString() + "')";
                    string query1 = "Update BloodTbl set  Bstock='" + x + "' where Bgroup='" + DBGroupCb.SelectedItem + "' ";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    SqlCommand cm = new SqlCommand(query1, Con);
                    cmd.ExecuteNonQuery();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Donor Successfully Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                
            }         
        }

        private bool NumberDigitValidation(string text)
        {
            throw new NotImplementedException();
        }

        private void Donor_Load(object sender, EventArgs e)
        {
            DNameTb.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewDonors viewdonor = new ViewDonors();
            viewdonor.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewPatients viewpatient = new ViewPatients();
            viewpatient.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BloodStock Bs = new BloodStock();
            Bs.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfert Bt = new BloodTransfert();
            Bt.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            dash.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
