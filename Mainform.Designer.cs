
namespace Test_01
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewd_lb = new System.Windows.Forms.Label();
            this.patient_lb = new System.Windows.Forms.Label();
            this.vp_lb = new System.Windows.Forms.Label();
            this.bldstk_lb = new System.Windows.Forms.Label();
            this.bldtrns_lb = new System.Windows.Forms.Label();
            this.db_lb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(207, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 46);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Blood Bank Management System";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 100;
            this.guna2PictureBox1.Image = global::Test_01.Properties.Resources.image_01_shutterstock_232287598_angellodeco;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(387, 179);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(637, 403);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Donor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // viewd_lb
            // 
            this.viewd_lb.AutoSize = true;
            this.viewd_lb.BackColor = System.Drawing.Color.Red;
            this.viewd_lb.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewd_lb.ForeColor = System.Drawing.Color.White;
            this.viewd_lb.Location = new System.Drawing.Point(28, 194);
            this.viewd_lb.Name = "viewd_lb";
            this.viewd_lb.Size = new System.Drawing.Size(145, 31);
            this.viewd_lb.TabIndex = 5;
            this.viewd_lb.Text = "View Donors";
            this.viewd_lb.Click += new System.EventHandler(this.label3_Click);
            // 
            // patient_lb
            // 
            this.patient_lb.AutoSize = true;
            this.patient_lb.BackColor = System.Drawing.Color.Red;
            this.patient_lb.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_lb.ForeColor = System.Drawing.Color.White;
            this.patient_lb.Location = new System.Drawing.Point(28, 261);
            this.patient_lb.Name = "patient_lb";
            this.patient_lb.Size = new System.Drawing.Size(85, 31);
            this.patient_lb.TabIndex = 7;
            this.patient_lb.Text = "Patient";
            this.patient_lb.Click += new System.EventHandler(this.patient_lb_Click);
            // 
            // vp_lb
            // 
            this.vp_lb.AutoSize = true;
            this.vp_lb.BackColor = System.Drawing.Color.Red;
            this.vp_lb.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vp_lb.ForeColor = System.Drawing.Color.White;
            this.vp_lb.Location = new System.Drawing.Point(28, 328);
            this.vp_lb.Name = "vp_lb";
            this.vp_lb.Size = new System.Drawing.Size(144, 31);
            this.vp_lb.TabIndex = 9;
            this.vp_lb.Text = "View Patient";
            this.vp_lb.Click += new System.EventHandler(this.vp_lb_Click);
            // 
            // bldstk_lb
            // 
            this.bldstk_lb.AutoSize = true;
            this.bldstk_lb.BackColor = System.Drawing.Color.Red;
            this.bldstk_lb.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bldstk_lb.ForeColor = System.Drawing.Color.White;
            this.bldstk_lb.Location = new System.Drawing.Point(28, 395);
            this.bldstk_lb.Name = "bldstk_lb";
            this.bldstk_lb.Size = new System.Drawing.Size(133, 31);
            this.bldstk_lb.TabIndex = 11;
            this.bldstk_lb.Text = "Blood Stock";
            this.bldstk_lb.Click += new System.EventHandler(this.bldstk_lb_Click);
            // 
            // bldtrns_lb
            // 
            this.bldtrns_lb.AutoSize = true;
            this.bldtrns_lb.BackColor = System.Drawing.Color.Red;
            this.bldtrns_lb.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bldtrns_lb.ForeColor = System.Drawing.Color.White;
            this.bldtrns_lb.Location = new System.Drawing.Point(28, 462);
            this.bldtrns_lb.Name = "bldtrns_lb";
            this.bldtrns_lb.Size = new System.Drawing.Size(169, 31);
            this.bldtrns_lb.TabIndex = 13;
            this.bldtrns_lb.Text = "Blood Transfert";
            this.bldtrns_lb.Click += new System.EventHandler(this.bldtrns_lb_Click);
            // 
            // db_lb
            // 
            this.db_lb.AutoSize = true;
            this.db_lb.BackColor = System.Drawing.Color.Red;
            this.db_lb.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_lb.ForeColor = System.Drawing.Color.White;
            this.db_lb.Location = new System.Drawing.Point(28, 526);
            this.db_lb.Name = "db_lb";
            this.db_lb.Size = new System.Drawing.Size(122, 31);
            this.db_lb.TabIndex = 15;
            this.db_lb.Text = "Dashboard";
            this.db_lb.Click += new System.EventHandler(this.db_lb_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(67, 696);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 31);
            this.label9.TabIndex = 16;
            this.label9.Text = "Logout";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.db_lb);
            this.panel1.Controls.Add(this.bldtrns_lb);
            this.panel1.Controls.Add(this.bldstk_lb);
            this.panel1.Controls.Add(this.vp_lb);
            this.panel1.Controls.Add(this.patient_lb);
            this.panel1.Controls.Add(this.viewd_lb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 763);
            this.panel1.TabIndex = 0;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 763);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label viewd_lb;
        private System.Windows.Forms.Label patient_lb;
        private System.Windows.Forms.Label vp_lb;
        private System.Windows.Forms.Label bldstk_lb;
        private System.Windows.Forms.Label bldtrns_lb;
        private System.Windows.Forms.Label db_lb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
    }
}