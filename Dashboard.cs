using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Blood
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            GetData();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\SDP_2\BloodBakDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        //public object OPlusProgress { get; private set; }
        private System.Windows.Forms.ProgressBar OPlusProgress;




        private void GetData()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from DonorTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DonorLbl.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("Select count(*) from TransferTbl", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            TransferLbl.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("Select count(*) from EmployeeTbl", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            EmployeeLbl.Text = dt2.Rows[0][0].ToString();
            SqlDataAdapter sda3 = new SqlDataAdapter("Select count(*) from BloodTbl", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);

            int BStock = Convert.ToInt32(dt3.Rows[0][0].ToString());
            //TotalLbl.Text = "" + BStock;



            SqlDataAdapter sda6 = new SqlDataAdapter("Select BStock from BloodTbl where Bgroup='" + "A+" + "'", Con);
            DataTable dt6 = new DataTable();
            sda6.Fill(dt6);

            APlusNumLbl.Text = dt6.Rows[0][0].ToString();

            double APlusPercentage = (Convert.ToDouble(dt6.Rows[0][0].ToString()) / BStock) * 100;
            APlusProgress2.Value = Convert.ToInt32(APlusPercentage);




            SqlDataAdapter sda7 = new SqlDataAdapter("Select BStock from BloodTbl where Bgroup='" + "A-" + "'", Con);
            DataTable dt7 = new DataTable();
            sda7.Fill(dt7);

            AminusNumLbl.Text = dt7.Rows[0][0].ToString();

            double AMinusPercentage = (Convert.ToDouble(dt7.Rows[0][0].ToString()) / BStock) * 100;
            AMinusProgress.Value = Convert.ToInt32(AMinusPercentage);








            SqlDataAdapter sda8 = new SqlDataAdapter("Select BStock from BloodTbl where Bgroup='" + "B+" + "'", Con);
            DataTable dt8 = new DataTable();
            sda8.Fill(dt8);

            BplusNumLbl.Text = dt8.Rows[0][0].ToString();

            double BPlusPercentage = (Convert.ToDouble(dt8.Rows[0][0].ToString()) / BStock) * 100;
            BPlusProgress.Value = Convert.ToInt32(BPlusPercentage);




            SqlDataAdapter sda9 = new SqlDataAdapter("Select BStock from BloodTbl where Bgroup='" + "B-" + "'", Con);
            DataTable dt9 = new DataTable();
            sda9.Fill(dt9);

            BminusNumLbl.Text = dt9.Rows[0][0].ToString();

            double BMinusPercentage = (Convert.ToDouble(dt9.Rows[0][0].ToString()) / BStock) * 100;
            BMinusProgress.Value = Convert.ToInt32(BMinusPercentage);








            SqlDataAdapter sda4 = new SqlDataAdapter("Select BStock from BloodTbl where Bgroup='" + "O+" + "'", Con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            OplusNumLbl2.Text = dt4.Rows[0][0].ToString();

            double OPlusPercentage = (Convert.ToDouble(dt4.Rows[0][0].ToString()) / BStock) * 100;
            OPlusProgress2.Value = Convert.ToInt32(OPlusPercentage);



            SqlDataAdapter sda10 = new SqlDataAdapter("Select BStock from BloodTbl where Bgroup='" + "O-" + "'", Con);
            DataTable dt10 = new DataTable();
            sda10.Fill(dt10);
            OminusNumLbl.Text = dt10.Rows[0][0].ToString();

            double OMinusPercentage = (Convert.ToDouble(dt10.Rows[0][0].ToString()) / BStock) * 100;
            OMinusProgress.Value = Convert.ToInt32(OMinusPercentage);




            SqlDataAdapter sda5 = new SqlDataAdapter("Select BStock from BloodTbl where Bgroup='" + "AB+" + "'", Con);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            ABplusNumLbl2.Text = dt5.Rows[0][0].ToString();

            double ABPlusPercentage = (Convert.ToDouble(dt5.Rows[0][0].ToString()) / BStock) * 100;
            ABPlusProgress2.Value = Convert.ToInt32(ABPlusPercentage);



            SqlDataAdapter sda11 = new SqlDataAdapter("Select BStock from BloodTbl where Bgroup='" + "AB-" + "'", Con);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            ABminusNumLbl2.Text = dt11.Rows[0][0].ToString();

            double ABMinusPercentage = (Convert.ToDouble(dt11.Rows[0][0].ToString()) / BStock) * 100;
            ABMinusProgress.Value = Convert.ToInt32(ABMinusPercentage);



            Con.Close();
        }

        private void NewMethod()
        {
            //MessageBox.Show("" + OplusPercentage);
            Con.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void TotalLbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor Ob = new Donor();
            Ob.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            DonateBlood Ob = new DonateBlood();
            Ob.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            View_Donor Ob = new View_Donor();
            Ob.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Patient Ob = new Patient();
            Ob.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewPatient Ob = new ViewPatient();
            Ob.Show();
            this.Hide();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Blood_Stock Ob = new Blood_Stock();
            Ob.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfert Ob = new BloodTransfert();
            Ob.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            login2 Ob = new login2();
            Ob.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
