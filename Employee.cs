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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-PT3JD6VE;Initial Catalog=BloodBankDb;Integrated Security=True");
        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        private void Reset()
        {
            EmpNameTb.Text = "";
            EmpPassTb.Text = "";
            key = 0;
        }
        private void populate()
        {
            Con.Open();
            string Query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {       // Employee Save Button

            if (EmpNameTb.Text == "" || EmpPassTb.Text == "" )
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (EmpNameTb.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name cannot have Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(EmpNameTb.Text.All(char.IsLetterOrDigit)))
            {
                MessageBox.Show("Name cannot have Symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "insert into EmployeeTbl values('" + EmpNameTb.Text + "', '" + EmpPassTb.Text + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {       // Employee Data Grid View

            EmpNameTb.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpPassTb.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
           
            if (EmpNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmpDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {       // Employee Delete Button

            if (key == 0)
            {
                MessageBox.Show("Select the Employee to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "Delete from EmployeeTbl where EmpNum = " + key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {       // Employee Edit Button

            if (EmpNameTb.Text == "" || EmpPassTb.Text == "" )
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (EmpNameTb.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name cannot have Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(EmpNameTb.Text.All(char.IsLetterOrDigit)))
            {
                MessageBox.Show("Name cannot have Symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "update EmployeeTbl set EmpId = '" + EmpNameTb.Text + "',EmpPass = '" + EmpPassTb.Text + "' where EmpNum = " + key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
    }
}
