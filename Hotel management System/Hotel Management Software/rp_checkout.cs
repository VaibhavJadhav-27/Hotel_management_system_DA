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
    public partial class rp_checkout : UserControl
    {

        function fn = new function();
        String query;
        String gid, gname;
        String roomid;
        String check_out_yn;

        public rp_checkout()
        {
            InitializeComponent();
        }


        public void clearAll()
        {
            txtguestid.Text = "";
            txtguestname.Text = "";
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String search = txtSearch.Text;
            query = "select * from Guest where guest_name like '" + search + "%';";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtguestname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtguestid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtguestname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void rp_checkout_Load(object sender, EventArgs e)
        {
            query = "select * from Guest";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void rp_checkout_Leave(object sender, EventArgs e)
        {
            clearAll();
            rp_checkout_Load(this, null);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            gid = txtguestid.Text;
            gname = txtguestname.Text;
            if(gid=="" || gname=="")
            {
                MessageBox.Show("Please fill all the details !!");
            }
            else
            {
                int i;
                String checkout = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                SqlConnection con2 = new SqlConnection();
                con2.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con2;
                String query2 = "select check_out_yn from Records where guest_id='" + gid + "';";
                con2.Open();
                cmd2.CommandText = query2;
                using (SqlDataReader rd2 = cmd2.ExecuteReader())
                {
                    while (rd2.Read())
                    {
                        check_out_yn = rd2.GetString(0);
                    }
                }
                con2.Close();
                if (check_out_yn == "Y")
                {
                    MessageBox.Show("Guest Already Checked Out");
                }
                else
                {
                    query = "Update Records set check_out='" + checkout + "',check_out_yn='Y' where guest_id='" + gid + "';";
                    i = fn.setData(query);
                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = con1;
                    String query1 = "select room_id from Records where guest_id='" + gid + "';";
                    con1.Open();
                    cmd1.CommandText = query1;
                    using (SqlDataReader rd1 = cmd1.ExecuteReader())
                    {
                        while (rd1.Read())
                        {
                            roomid = rd1.GetString(0);
                        }
                    }
                    String query3 = "Update Room set booked='NO' where room_id='" + roomid + "';";
                    int j = fn.setData(query3);
                    if (i > 0 && j > 0)
                    {
                        MessageBox.Show("Guest Check OUT succeded");
                        clearAll();
                    }
                }
            }
        }
    }
}
