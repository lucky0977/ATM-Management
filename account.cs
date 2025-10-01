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

namespace ATMTuto
{
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lakhan\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button11_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNametb.Text == "" || AccNumTb.Text == "" || FanameTb.Text == "" || PhoneTb.Text == "" || Addresstb.Text == "" || occupationtb.Text == "" || pintb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into AccountTb1 values(@AccNum, @AccName, @FName, @DOB, @Phone, @Address, @Education, @Occupation, @PIN, @Balance)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@AccNum", AccNumTb.Text);
                    cmd.Parameters.AddWithValue("@AccName", AccNametb.Text);
                    cmd.Parameters.AddWithValue("@FName", FanameTb.Text);
                    cmd.Parameters.AddWithValue("@DOB", dobdate.Value.Date);
                    cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Address", Addresstb.Text);
                    cmd.Parameters.AddWithValue("@Education", educationcb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Occupation", occupationtb.Text);
                    cmd.Parameters.AddWithValue("@PIN", System.Text.Encoding.UTF8.GetBytes(pintb.Text));
                    cmd.Parameters.AddWithValue("@Balance", bal);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
