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
    public partial class rp_package : UserControl
    {

        function fn = new function();
        String query;
        String type, gid;
        String packageinfo;
        int price, quantity, total;
        int total_pr;
        int noofdays;

        public rp_package()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            txtGuestname.Text = "";
            lblTotalPrice.Text = "";
            lblPrice.Text = "";
            lblguestid.Text = "";
            lblpackageinfo.Text = "";
            cmdpackagetype.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmdpackagetype.SelectedIndex==-1 || txtGuestname.Text=="")
            {
                MessageBox.Show("Please fill all details !!");
            }
            else
            {
                type = cmdpackagetype.Text;
                price = Convert.ToInt32(lblPrice.Text);
                quantity = Convert.ToInt32(Math.Round(nudquantity.Value));
                total = Convert.ToInt32(lblTotalPrice.Text);
                gid = lblguestid.Text;
                if (gid == "" || cmdpackagetype.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill all details !!");
                }
                else
                {
                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = con1;
                    String query1 = "select total_price,no_of_days from Records where guest_id='" + gid + "';";
                    con1.Open();
                    cmd1.CommandText = query1;
                    using (SqlDataReader rd1 = cmd1.ExecuteReader())
                    {
                        while (rd1.Read())
                        {
                            total_pr = rd1.GetInt32(0);
                            //MessageBox.Show(total_pr.ToString());
                            noofdays = rd1.GetInt32(1);
                        }
                    }
                    con1.Close();
                    total_pr = total_pr + (total * noofdays);
                    query = "update Records set total_price=" + total_pr + " where guest_id='" + gid + "';";
                    int i = fn.setData(query);
                    if (i > 0)
                    {
                        MessageBox.Show("Total Price Updated");
                        clearAll();
                    }
                }
            }
            
            
        }

        private void nudquantity_Click(object sender, EventArgs e)
        {
            price = Convert.ToInt32(lblPrice.Text);
            quantity = Convert.ToInt32(Math.Round(nudquantity.Value));
            total = price * quantity;
            lblTotalPrice.Text = total.ToString();
            
        }

        private void nudquantity_ValueChanged(object sender, EventArgs e)
        {
            price = Convert.ToInt32(lblPrice.Text);
            quantity = Convert.ToInt32(Math.Round(nudquantity.Value));
            total = price * quantity;
            lblTotalPrice.Text = total.ToString();
        }

        private void rp_package_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void cmdpackagetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmdpackagetype.SelectedIndex==0)
            {
                lblPrice.Text = "900";
                packageinfo = "*******************************************************************\n";
                packageinfo += "                                          American Package                   \n\n\n\n\n\n\n";
                packageinfo += "This Package will include : ";
                packageinfo += "\n    1.Breakfast\n    2.Lunch\n    3.Supper\n     4.Dinner";
                packageinfo += "\n\n\n[Note: This package will we applicable to the number of days the guest stays]";
                packageinfo += "\n\n\n                                            Thank You !!!";
                lblpackageinfo.Text = packageinfo;

            }
            if(cmdpackagetype.SelectedIndex==1)
            {
                lblPrice.Text = "800";
                packageinfo = "*******************************************************************\n";
                packageinfo += "                                 Monodraft American Package                   \n\n\n\n\n\n\n";
                packageinfo += "This Package will include : ";
                packageinfo += "\n    1.Breakfast\n    2.Lunch\n    3.Dinner\n";
                packageinfo += "\n\n\n[Note: This package will we applicable to the number of days the guest stays]";
                packageinfo += "\n\n\n                                            Thank You !!!";
                lblpackageinfo.Text = packageinfo;
            }
            if(cmdpackagetype.SelectedIndex==2)
            {
                lblPrice.Text = "500";
                packageinfo = "*******************************************************************\n";
                packageinfo += "                                             Day Package                   \n\n\n\n\n\n\n";
                packageinfo += "This Package will include : ";
                packageinfo += "\n    1.Breakfast\n    2.Lunch\n\n\n";
                packageinfo += "\n\n\n[Note: This package will we applicable to the number of days the guest stays]";
                packageinfo += "\n\n\n                                            Thank You !!!";
                lblpackageinfo.Text = packageinfo;
            }
            if (cmdpackagetype.SelectedIndex == 3)
            {
                lblPrice.Text = "500";
                packageinfo = "*******************************************************************\n";
                packageinfo += "                                             Evening Package                   \n\n\n\n\n\n\n";
                packageinfo += "This Package will include : ";
                packageinfo += "\n    1.Breakfast\n    2.Dinner\n\n\n";
                packageinfo += "\n\n\n[Note: This package will we applicable to the number of days the guest stays]";
                packageinfo += "\n\n\n                                            Thank You !!!";
                lblpackageinfo.Text = packageinfo;
            }
            if (cmdpackagetype.SelectedIndex == 4)
            {
                lblPrice.Text = "1000";
                packageinfo = "*******************************************************************\n";
                packageinfo += "                                             Seasonal Package                   \n\n\n\n\n\n\n";
                packageinfo += "This Package will include : ";
                packageinfo += "\n    1.Breakfast\n    2.Lunch\n     3.Dinner\n     4.Seasonal items\n\n\n";
                packageinfo += "\n\n\n[Note: This package will we applicable to the number of days the guest stays]";
                packageinfo += "\n\n\n                                            Thank You !!!";
                lblpackageinfo.Text = packageinfo;
            }
        }

        private void txtGuestname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGuestname_TextChanged(object sender, EventArgs e)
        {
            String search = txtGuestname.Text;
            if(txtGuestname.Text=="")
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
    }
}
