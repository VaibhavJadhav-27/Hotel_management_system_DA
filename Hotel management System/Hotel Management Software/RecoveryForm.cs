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
    public partial class RecoveryForm : Form
    {

        String pass, cpass,username;
        function fn = new function();


        public RecoveryForm()
        {
            InitializeComponent();
        }

        private void RecoveryForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pass = txtnewpass.Text;
            cpass = txtconfirmpass.Text;
            username = txtusername.Text;
            if(username=="" || pass=="" || cpass=="")
            {
                MessageBox.Show("Please fill all the details !!");
            }
            else
            {
                if (pass == cpass)
                {
                    String query = "UPDATE Receptionist_admin SET password='" + pass + "' WHERE username='" + username + "';";
                    int i = fn.setData(query);
                    if (i != 0)
                    {
                        MessageBox.Show("Password updation successfull");
                        this.Hide();
                        Form1 fm = new Form1();
                        fm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password updation failed!");
                    }
                    //con.Close();

                }
                else
                {
                    MessageBox.Show("Password does not match !!");
                    txtconfirmpass.Text = "";
                    txtnewpass.Text = "";
                    txtusername.Text = "";
                }
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            String id = txtempid.Text;
            String name = txtempname.Text;
            if(id=="" || name=="")
            {
                MessageBox.Show("Please fill out all details !!");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                String query = "select * from Employee where emp_id='" + id + "' and emp_name='" + name + "';";
                con.Open();
                cmd.CommandText = query;
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.HasRows)
                    {
                        panel2.Show();
                        txtempid.Text = "";
                        txtempname.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Employee id and name does not match");
                        txtempid.Text = "";
                        txtempname.Text = "";

                    }
                }
                con.Close();
            }
        }
    }
}
