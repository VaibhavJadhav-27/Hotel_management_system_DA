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
    public partial class ad_employee : UserControl
    {

        function fn = new function();
        String query;
        String id, name, cnum, dept, desig, gen;
        int sal;

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public void claerAll()
        {
            txtempid.Text = "";
            txtempname.Text = "";
            txtSearch.Text = "";
            txtsalary.Text = "";
            txtdesignation.Text = "";
            txtcontactno.Text = "";
            cmbgender.SelectedIndex = -1;
            cmbdepartment.SelectedIndex = -1;
        }

        private void metroTextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)  && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            id = txtempid.Text;
            name = txtempname.Text;
            cnum = txtcontactno.Text;
            desig = txtdesignation.Text;
            String sal1 = txtsalary.Text;
            if (id == "" || name == "" || cnum == "" || desig == "" || sal1 == "" || cmbgender.SelectedIndex.Equals(-1) || cmbdepartment.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Please Fill all the textboxes");
            }
            else
            {
                if (cnum.Length != 10)
                {
                    MessageBox.Show("Contact number should be of 10 digits");
                    return;
                }
                sal = Int32.Parse(txtsalary.Text);
                gen = cmbgender.SelectedItem.ToString();
                dept = cmbdepartment.SelectedItem.ToString();
                SqlConnection con1 = new SqlConnection();           //checking the employee
                con1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                String query2 = "select * from Employee where emp_id='" + id + "' and emp_name='" + name + "';";
                con1.Open();
                cmd1.CommandText = query2;
                using (SqlDataReader rd1 = cmd1.ExecuteReader())
                {
                    if (rd1.HasRows)
                    {
                        query = "UPDATE Employee SET emp_contact_no='" + cnum + "',emp_dept='" + dept + "',emp_designation='" + desig + "',emp_salary=" + sal + " WHERE emp_id='" + id + "' and emp_name='" + name + "';";
                        int i = fn.setData(query);
                        if (i != 0)
                        {
                            ad_employee_Load(this, null);
                        }
                        else
                        {
                            MessageBox.Show("Record Updation Failed!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee ID does not exist !! \nPlease Click on Add");
                        return;
                    }
                }
            }
            claerAll();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            id = txtempid.Text;
            name = txtempname.Text;
            cnum = txtcontactno.Text;
            desig = txtdesignation.Text;
            String sal1 = txtsalary.Text;
            if (id == "" || name == "" || cnum == "" || desig == "" || sal1 == "" || cmbgender.SelectedIndex.Equals(-1) || cmbdepartment.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Please Fill all the textboxes");
            }
            else
            {
                SqlConnection con1 = new SqlConnection();           //checking the employee
                con1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                String query2 = "select * from Employee where emp_id='" + id + "' and emp_name='" + name + "';";
                con1.Open();
                cmd1.CommandText = query2;
                using (SqlDataReader rd1 = cmd1.ExecuteReader())
                {
                    if (rd1.HasRows)
                    {
                        query = "delete from Employee where emp_id='" + id + "' and emp_name='" + name + "';";
                        int i = fn.setData(query);
                        if (i != 0)
                        {
                            ad_employee_Load(this, null);
                        }
                        else
                        {
                            MessageBox.Show("Record Deletion Failed!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee ID does not exist !! \nPlease Click on Add");
                        return;
                    }
                }
            }
            claerAll();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String search = txtSearch.Text;
            String query2 = "select * from Employee where emp_name like '" + search + "%';";
            DataSet ds = fn.getData(query2);
            dataGridView1.DataSource = ds.Tables[0];
           
        }

        private void ad_employee_Leave(object sender, EventArgs e)
        {
            claerAll();
        }

        private void txtcontactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            id = txtempid.Text;
            name = txtempname.Text;
            cnum = txtcontactno.Text;
            desig = txtdesignation.Text;
            String sal1 = txtsalary.Text;
            if (id == "" || name == "" || cnum == "" || desig == "" || sal1 == "" || cmbgender.SelectedIndex.Equals(-1) || cmbdepartment.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Please Fill all the textboxes");

            }
            else
            {
                if(cnum.Length!=10)
                {
                    MessageBox.Show("Contact number should be of 10 digits");
                    return;
                }
                sal = Int32.Parse(txtsalary.Text);
                gen = cmbgender.SelectedItem.ToString();
                dept = cmbdepartment.SelectedItem.ToString();
                SqlConnection con1 = new SqlConnection();           //checking the employee
                con1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                String query2 = "select * from Employee where emp_id='" + id + "' and emp_name='"+name+"';";
                con1.Open();
                cmd1.CommandText = query2;
                using (SqlDataReader rd1 = cmd1.ExecuteReader())
                {
                    if (rd1.HasRows)
                    {
                        MessageBox.Show("Employee ID already exist !! \nPlease Click on Update");
                        return;
                    }
                    else
                    {
                        query = "insert into Employee values('" + id + "','" + name + "','" + cnum + "','" + gen + "','" + dept + "','" + desig + "'," + sal + ");";
                        int i= fn.setData(query);
                        if(i!=0)
                        {
                            ad_employee_Load(this, null);
                        }
                        else
                        {
                            MessageBox.Show("Record Insertion Failed!!");
                        }
                    }
                }
            }
            claerAll();
        }


        public ad_employee()
        {
            InitializeComponent();
        }

        private void ad_employee_Load(object sender, EventArgs e)
        {
            query = "select * from Employee";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtempid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtempname.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcontactno.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdesignation.Text=dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtsalary.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbgender.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbdepartment.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
