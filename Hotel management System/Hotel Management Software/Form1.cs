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

namespace Hotel_Management_Software
{
    public partial class Form1 : Form
    {
        public static string username;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0,0);
            metroSetLabel1.ForeColor = Color.Yellow;
        }

        private void metroSetLink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecoveryForm rf = new RecoveryForm();
            this.Hide();
            rf.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            username = txtusername.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            String query = "select emp_designation from Receptionist_admin where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "';";
            con.Open();
            cmd.CommandText = query;

            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                if (rd.HasRows)
                {
                    //MessageBox.Show("Login successful!!!!!!");
                    while(rd.Read())
                    {
                        String designation = rd.GetString(0);
                        if(designation=="admin")
                        {
                            Amin_login ad = new Amin_login();
                            this.Hide();
                            ad.Show();
                        }
                        if(designation=="receptionist")
                        {
                            Receptionist_login rl = new Receptionist_login();
                            this.Hide();
                            rl.Show();
                        }
                        if(designation=="timekeeper")
                        {
                            Timekeeper_login tl = new Timekeeper_login();
                            this.Hide();
                            tl.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Login Unsuccessful!!!  \nPlease try again");
                    txtusername.Text = "";
                    txtpassword.Text = "";
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            
            //Application.Exit();
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
