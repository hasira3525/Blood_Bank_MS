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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            GetData();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-PT3JD6VE;Initial Catalog=BloodBankDb;Integrated Security=True");
        private void GetData()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from DonorTbl",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DonorLbl.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from TransferTbl", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            TransferLbl.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from EmployeeTbl", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            UserLbl.Text = dt2.Rows[0][0].ToString();

            /*SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from BloodTbl", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            int BStock = Convert.ToInt32(dt3.Rows[0][0].ToString());
            TotalLbl.Text = "" + BStock;
            TotalLbl.Text = dt3.Rows[0][0].ToString();*/
            Con.Close();
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void DonorLbl_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

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
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
