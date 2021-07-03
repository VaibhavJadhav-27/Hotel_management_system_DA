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
    public partial class rp_laundry : UserControl
    {

        String gname, type, pricet, quantityt, totalt;
        String gid;
        String query;
        int gp=0;
        int tpd;
        function fn = new function();

        public rp_laundry()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            txtGuestname.Text = "";
            lblguestid.Text = "";
            lblGrandTotal.Text = "";
            lblPrice.Text = "";
            lblTotalPrice.Text = "";
            cmdsuittype.SelectedIndex = -1;
        }

        private void rp_laundry_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            //add coulmns
            listView1.Columns.Add("Type");
            listView1.Columns.Add("Price");
            listView1.Columns.Add("Quantity");
            listView1.Columns.Add("Total Price");

        }

        private void add(String type,String price,String quantity,String total)
        {
            String[] row = { type, price, quantity, total };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }

        private void txtGuestname_TextChanged(object sender, EventArgs e)
        {
            String search = txtGuestname.Text;
            if (txtGuestname.Text == "")
            {
                lblguestid.Text = "";
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                query = "select guest_id from Records where  check_out_yn='N' and guest_name like '" + search + "%';";
                con.Open();
                cmd.CommandText = query;
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        lblguestid.Text = "";
                        lblguestid.Text = rd.GetString(0);
                    }
                }
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            gid = lblguestid.Text;
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            query = "select total_price from Records where guest_id='"+gid+"';";
            con.Open();
            cmd.CommandText = query;
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    tpd = rd.GetInt32(0);
                    //MessageBox.Show(tpd.ToString());
                }
            }
            con.Close();

            gp = gp + tpd;
            query = "update Records set total_price=" + gp + " where guest_id='" + gid + "';";
            int i = fn.setData(query);
            if (i > 0)
            {
                MessageBox.Show("Laundry Price Saved");
                clearAll();
            }
        }

        private void rp_laundry_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txtGuestname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmdsuittype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmdsuittype.SelectedIndex == 0)
            {
                lblPrice.Text = "200";
                lblTotalPrice.Text = "";
            }
            if(cmdsuittype.SelectedIndex==1)
            {
                lblPrice.Text = "200";
                lblTotalPrice.Text = "";
            }
            if (cmdsuittype.SelectedIndex == 2)
            {
                lblPrice.Text = "150";
                lblTotalPrice.Text = "";
            }
            if (cmdsuittype.SelectedIndex == 3)
            {
                lblPrice.Text = "50";
                lblTotalPrice.Text = "";
            }
            if (cmdsuittype.SelectedIndex == 4)
            {
                lblPrice.Text = "50";
                lblTotalPrice.Text = "";
            }
        }

        private void nudquantity_ValueChanged(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(Math.Round(nudquantity.Value));
            int price = Convert.ToInt32(lblPrice.Text);
            int total_p = quantity * price;
            lblTotalPrice.Text = total_p.ToString();
        }

        private void btnAddtolist_Click(object sender, EventArgs e)
        {
            gname = txtGuestname.Text;
            gid = lblguestid.Text;
            type = cmdsuittype.Text;
            pricet = lblPrice.Text;
            quantityt = nudquantity.Value.ToString();
            totalt = lblTotalPrice.Text;
            if(gname=="" || gid=="" || cmdsuittype.SelectedIndex==-1 || totalt=="" || pricet=="")
            {
                MessageBox.Show("Plese fill all details !!");
            }
            else
            {
                int tp = Convert.ToInt32(lblTotalPrice.Text);
                add(type, pricet, quantityt, totalt);
                gp = gp + tp;
                lblGrandTotal.Text = gp.ToString();
            }
        }
    }
}
