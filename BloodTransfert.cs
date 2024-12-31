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
    public partial class BloodTransfert : Form
    {
        public BloodTransfert()
        {
            InitializeComponent();
            fillPatientCb();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\SDP_2\BloodBakDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        private void fillPatientCb()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PNum from PatientTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PName", typeof(string));
            dt.Load(rdr);
            PatientIdCb.ValueMember = "PNum";
            PatientIdCb.DataSource = dt;

            Con.Close();
        }
        private void GetData()
        {
            Con.Open();
            string query = "select * from PatientTbl where PNum='" + PatientIdCb.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatNameTb.Text = dr["PName"].ToString();
                BloodGroup.Text = dr["PBGroup"].ToString();
            }
            Con.Close();

        }
        int stock = 0;
        private void GetStock(string BGroup)
        {
            Con.Open();
            string query = "select * from BloodTbl where Bgroup='" + BGroup + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                stock = Convert.ToInt32(dr["BStock"].ToString());
            }
            Con.Close();

        }
        private void BloodTransfert_Load(object sender, EventArgs e)
        {

        }
        /*int oldstock;
        private void GetStock(string BGroup)
        {
            Con.Open();
            string query = "select * from BloodTbl where Bgroup='" + BGroup + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                oldstock = Convert.ToInt32(dr["BStock"].ToString());
            }
            Con.Close();

        }*/
        private void PatientIdCb_SelectionChangeComitted(object sender, EventArgs e)
        {
            GetData();
            GetStock(BloodGroup.Text);
            if (stock > 0)
            {
                TransferBtn.Visible = true;
                AvailableLbl.Text = "Available STock";
                AvailableLbl.Visible = true;
            }
            else
            {
                TransferBtn.Visible = false;
                AvailableLbl.Text = "STock not Available";
                AvailableLbl.Visible = true;

            }
        }
        private void Reset()
        {
            PatNameTb.Text = "";
            //PatientIdCb.SelectedIndex = -1;
            BloodGroup.Text = "";
            AvailableLbl.Visible = false;
            TransferBtn.Visible = false;
        }
        //private void updateStock()
        //{
        //    int newstock = stock - 1;
        //    try
        //    {
        //        string query = "update BloodTbl set BStock=" + newstock + " where PNum=" + BloodGroup.Text + ";";
        //        Con.Open();
        //        SqlCommand cmd = new SqlCommand(query, Con);
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Patient Successfully Deleted");
        //        Con.Close();
        //    }
        //    catch (Exception Ex)
        //    {
        //        MessageBox.Show(Ex.Message);
        //    }
        //}
        private void updateStock()
        {
            int newstock = stock - 1;
            try
            {
                // Corrected query with proper column name and quotes for string values
                string query = "update BloodTbl set BStock=" + newstock + " where BGroup='" + BloodGroup.Text + "';";
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Stock Updated Successfully");
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (PatNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "insert into TransferTbl values('" + PatNameTb.Text + "','" + BloodGroup.Text + "');";

                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfull Transfer");
                    Con.Close();
                    GetStock(BloodGroup.Text);
                    updateStock();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Patient Pat = new Patient();
            Pat.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Blood_Stock Bstock = new Blood_Stock();
            Bstock.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor Ob = new Donor();
            Ob.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            DonateBlood Blood = new DonateBlood();
            Blood.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            View_Donor Ob = new View_Donor();
            Ob.Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewPatient Ob = new ViewPatient();
            Ob.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Dashboard Ob = new Dashboard();
            Ob.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            login2 Ob = new login2();
            Ob.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
