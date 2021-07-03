using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_Software
{
    public partial class admin_dashbard : UserControl
    {

        function fn = new function();
        String query;
        String uname, pass, id, desig;

        public void clearAll()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtempid.Text = "";
            txtDesgination.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uname = txtUsername.Text;
            pass = txtPassword.Text;
            id = txtempid.Text;
            desig = txtDesgination.Text;
            if (uname != "" && pass != "" && id != "" && desig != "")
            {
                SqlConnection con1 = new SqlConnection();           //checking the employee
                con1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                String query2 = "select * from Employee where emp_id='" + id + "';";
                con1.Open();
                cmd1.CommandText = query2;
                using (SqlDataReader rd1 = cmd1.ExecuteReader())
                {
                    if (rd1.HasRows)
                    {
                        con1.Close();
                        SqlCommand cmd2 = new SqlCommand();         //checking if record is present or not
                        cmd2.Connection = con1;
                        query = "select * from Receptionist_admin where emp_id='" + id + "';";
                        con1.Open();
                        cmd2.CommandText = query;
                        using (SqlDataReader rd = cmd2.ExecuteReader())
                        {
                            if (rd.HasRows)
                            {
                                con1.Close();
                                String query1 = "UPDATE Receptionist_admin SET password='" + pass + "',emp_designation='" + desig + "' WHERE emp_id='" + id + "' AND username='"+uname+"';";
                                int j = fn.setData(query1);
                                if (j != 0)
                                {
                                    MessageBox.Show("Updation Successful");
                                    admin_dashbard_Load(this, null);
                                }
                                else
                                {
                                    MessageBox.Show("Username and Employee ID does not belong to same person");
                                }
                            }
                            else
                            {
                                con1.Close();
                                MessageBox.Show("Record Not Present !!\n Please click on Add");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Employee ID does not exist");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
            clearAll();
        }

        public admin_dashbard()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPassword.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtempid.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDesgination.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            uname = txtUsername.Text;
            pass = txtPassword.Text;
            id = txtempid.Text;
            desig = txtDesgination.Text;
            if (uname != "" && pass != "" && id != "" && desig != "")
            {
                SqlConnection con1 = new SqlConnection();           
                con1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                SqlCommand cmd2 = new SqlCommand();         //checking if record is present or not
                cmd2.Connection = con1;
                query = "select * from Receptionist_admin where emp_id='" + id + "';";
                con1.Open();
                cmd2.CommandText = query;
                using (SqlDataReader rd = cmd2.ExecuteReader())
                {
                    if (rd.HasRows)
                    {
                        con1.Close();
                        String query1 = "delete from Receptionist_admin where username='" + uname + "' and emp_id='" + id + "';";
                        int j = fn.setData(query1);
                        if (j != 0)
                        {
                            admin_dashbard_Load(this, null);
                        }
                        else
                        {
                            MessageBox.Show("Record deletion failed!!");
                        }
                    }
                    else
                    {
                        con1.Close();
                        MessageBox.Show("Record Not Present !!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
            clearAll();
        }

        private void admin_dashbard_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txtDesgination_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtempid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void admin_dashbard_Load(object sender, EventArgs e)
        {
            query = "select * from Receptionist_admin";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            admin_dashbard_Load(this, null);
            uname = txtUsername.Text;
            pass = txtPassword.Text;
            id = txtempid.Text;
            desig = txtDesgination.Text;
            if(uname !="" && pass!="" && id!="" && desig!="")
            {
                SqlConnection con1 = new SqlConnection();           //checking the employee
                con1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                String query2 = "select * from Employee where emp_id='" + id + "';";
                con1.Open();
                cmd1.CommandText = query2;
                using (SqlDataReader rd1 = cmd1.ExecuteReader())
                {
                    if (rd1.HasRows)
                    {
                        con1.Close();
                        SqlCommand cmd2 = new SqlCommand();         //checking if record is present or not
                        cmd2.Connection = con1;
                        query = "select * from Receptionist_admin where emp_id='" + id + "';";
                        con1.Open();
                        cmd2.CommandText = query;
                        using (SqlDataReader rd = cmd2.ExecuteReader())
                        {
                            if (rd.HasRows)
                            {
                                MessageBox.Show("Record present !!! \n Please click on update");
                                con1.Close();
                            }
                            else
                            {
                                con1.Close();
                                int count = countunique();
                                if(count==1)
                                {
                                    MessageBox.Show("Username already taken");
                                }
                                else
                                {
                                    String query1 = "insert into Receptionist_admin values('" + uname + "','" + pass + "','" + id + "','" + desig + "');";
                                    int j = fn.setData(query1);
                                    if (j != 0)
                                    {
                                        admin_dashbard_Load(this, null);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Record insertion failed");
                                    }
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Employee ID does not exist");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
            clearAll();
        }

        private int countunique()
        {
            uname = txtUsername.Text;
            SqlConnection con1 = new SqlConnection();           //checking the employee
            con1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con1;
            String query2 = "select * from Receptionist_admin where username='" + uname + "';";
            con1.Open();
            cmd1.CommandText = query2;
            int i;
            using (SqlDataReader rd = cmd1.ExecuteReader())
            {
                if(rd.HasRows)
                {
                    i = 1;
                    return i;
                }
                else
                {
                    i = 0;
                    return i;
                }
            }
        }
    }
}
