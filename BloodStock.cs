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
using System.Data;

namespace Test_01
{
    public partial class BloodStock : Form
    {
        public BloodStock()
        {
            InitializeComponent();
            bloodStock();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-PT3JD6VE;Initial Catalog=BloodBankDb;Integrated Security=True");
        
        private void bloodStock()
        {
            Con.Open();
            string Query = "select * From BloodTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
           // SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataTable();
            sda.Fill(ds);
            BloodStockDGV.DataSource = ds;
            Con.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BloodStock_Load(object sender, EventArgs e)
        {

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

        private void BloodStockDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
