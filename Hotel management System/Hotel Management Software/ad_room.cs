using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Management_Software
{
    public partial class ad_room : UserControl
    {

        function fn = new function();
        String query;
        String rid, rno, type, bed, price1, booked;
        int price;

        public ad_room()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            txtroomid.Text = "";
            txtroonno.Text = "";
            txtSearch.Text = "";
            txtprice.Text = "";
            cmbbed.SelectedIndex = -1;
            cmbtype.SelectedIndex = -1;
        }

        private void btnUpdateroom_Click(object sender, EventArgs e)
        {
            rid = txtroomid.Text;
            rno = txtroonno.Text;
            price1 = txtprice.Text;
            if (rdbYES.Checked)
            {
                booked = "YES";
            }
            else
            {
                booked = "NO";
            }
            if (rid == "" || rno == "" || cmbtype.SelectedIndex.Equals(-1) || cmbbed.SelectedIndex.Equals(-1) || price1 == "")
            {
                MessageBox.Show("Please Fill all the details!!");
            }
            else
            {
                type = cmbtype.SelectedItem.ToString();
                bed = cmbbed.SelectedItem.ToString();
                price = Int32.Parse(price1);
                SqlConnection con1 = new SqlConnection();           //checking the employee
                con1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                String query2 = "select * from Room where room_id='" + rid + "' and room_no='" + rno + "';";
                con1.Open();
                cmd1.CommandText = query2;
                using (SqlDataReader rd1 = cmd1.ExecuteReader())
                {
                    if (rd1.HasRows)
                    {
                        query = "UPDATE Room SET room_type='" + type + "',room_bed='" + bed + "',room_price=" + price + ",booked='" + booked + "' WHERE room_id='" + rid + "' and room_no='" + rno + "';";
                        int i = fn.setData(query);
                        if (i != 0)
                        {
                            ad_room_Load(this, null);
                        }
                        else
                        {
                            MessageBox.Show("Record Updation Failed!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Room does not exist !! \nPlease Click on Add");
                        return;
                    }
                }
                clearAll();
            }
        }

        private void btnremoveroom_Click(object sender, EventArgs e)
        {
            rid = txtroomid.Text;
            rno = txtroonno.Text;
            if (rid == "" || rno == "" || cmbtype.SelectedIndex.Equals(-1) || cmbbed.SelectedIndex.Equals(-1) || price1 == "")
            {
                MessageBox.Show("Please Fill all the details!!");
            }
            else
            {
                SqlConnection con1 = new SqlConnection();           //checking the employee
                con1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                String query2 = "select booked from Room where room_id='" + rid + "' and room_no='" + rno + "';";
                con1.Open();
                cmd1.CommandText = query2;
                using (SqlDataReader rd1 = cmd1.ExecuteReader())
                {
                    if (rd1.HasRows)
                    {
                        while(rd1.Read())
                        {
                            booked = rd1.GetString(0);
                            if(booked=="NO")
                            {
                                query = "delete from Room where room_id='" + rid + "' and room_no='" + rno + "';";
                                int i = fn.setData(query);
                                if (i != 0)
                                {
                                    ad_room_Load(this, null);
                                }
                                else
                                {
                                    MessageBox.Show("Record Deletion Failed!!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Unable to Remove Room when it is Booked");
                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Room does not exist !! \nPlease Click on Add");
                        return;
                    }
                }
                clearAll();
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String search = txtSearch.Text;
            query = "select * from Room where room_no like'" + search + "%';";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ad_room_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void ad_room_Load(object sender, EventArgs e)
        {
            query = "select * from Room";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtroonno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtroomid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtroonno.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbtype.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbbed.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtprice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            rid = txtroomid.Text;
            rno = txtroonno.Text;
            price1 = txtprice.Text;
            if(rdbYES.Checked)
            {
                booked = "YES";
            }
            else
            {
                booked = "NO";
            }
            if(rid=="" || rno =="" || cmbtype.SelectedIndex.Equals(-1) || cmbbed.SelectedIndex.Equals(-1) || price1 =="")
            {
                MessageBox.Show("Please Fill all the details!!");
            }
            else
            {
                type = cmbtype.SelectedItem.ToString();
                bed = cmbbed.SelectedItem.ToString();
                price = Int32.Parse(price1);
                SqlConnection con1 = new SqlConnection();           //checking the employee
                con1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                String query2 = "select * from Room where room_id='" + rid + "' and room_no='" + rno + "';";
                con1.Open();
                cmd1.CommandText = query2;
                using (SqlDataReader rd1 = cmd1.ExecuteReader())
                {
                    if (rd1.HasRows)
                    {
                        MessageBox.Show("Room already exist !! \nPlease Click on Update");
                        return;
                    }
                    else
                    {
                        query = "insert into Room values('" + rid + "','" + rno + "','" + type + "','" + bed + "'," + price + ",'" + booked + "');";
                        int i = fn.setData(query);
                        if (i != 0)
                        {
                            ad_room_Load(this, null);
                        }
                        else
                        {
                            MessageBox.Show("Record Insertion Failed!!");
                        }
                    }
                }
                clearAll();
            }
        }
    }
}
