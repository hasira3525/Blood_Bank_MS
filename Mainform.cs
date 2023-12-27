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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewDonors viewdonor = new ViewDonors();
            viewdonor.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void patient_lb_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Hide();

        }

        private void vp_lb_Click(object sender, EventArgs e)
        {
             ViewPatients viewpatient = new ViewPatients();
            viewpatient.Show();
            this.Hide();
        }

        private void bldstk_lb_Click(object sender, EventArgs e)
        {
            BloodStock Bs = new BloodStock();
            Bs.Show();
            this.Hide();
        }

        private void bldtrns_lb_Click(object sender, EventArgs e)
        {
            BloodTransfert Bt = new BloodTransfert();
            Bt.Show();
            this.Hide();

        }

        private void db_lb_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            dash.Show();
            this.Hide();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
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
