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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-PT3JD6VE;Initial Catalog=BloodBankDb;Integrated Security=True");

        private void Reset()
        {
            PNameTb.Text = "";
            PAgeTb.Text = "";
            PPhoneTb.Text = "";
            PGenCb.SelectedIndex = -1;
            PBGroupCb.SelectedIndex = -1;
            PAddressTb.Text = "";
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {             //Save Button
            if (PNameTb.Text == "" || PAgeTb.Text == "" || PPhoneTb.Text == "" || PGenCb.SelectedIndex == -1 || PBGroupCb.SelectedIndex == -1 || PAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PNameTb.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name cannot have Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(PNameTb.Text.All(char.IsLetterOrDigit)))
            {
                MessageBox.Show("Name cannot have Symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PAgeTb.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Age cannot have Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PAgeTb.Text.Length > 2)
            {
                MessageBox.Show("Please Enter the Correct Age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Regex.IsMatch(PPhoneTb.Text, @"^(?:7 |0| (?:\+94))[0-9]{8,9}$")))
            {
                MessageBox.Show("Tp must have 10 Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(PPhoneTb.Text.All(char.IsLetterOrDigit)))
            {
                MessageBox.Show("TP cannot have Symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PPhoneTb.Text.Any(char.IsLetter))
            {
                MessageBox.Show("TP cannot have Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   
                    try
                    {
                        string query = "insert into PatientTbl values('" + PNameTb.Text + "', '" + PAgeTb.Text + "','" + PPhoneTb.Text + "','" + PGenCb.SelectedItem.ToString() + "', '" + PBGroupCb.SelectedItem.ToString() + "','" + PAddressTb.Text + "')";
                        Con.Open();
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Patient Successfully Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Con.Close();
                        Reset();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewPatients viewpatient = new ViewPatients();
            viewpatient.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfert Bt = new BloodTransfert();
            Bt.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewDonors viewdonor = new ViewDonors();
            viewdonor.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BloodStock Bs = new BloodStock();
            Bs.Show();
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

        private void PAgeTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
