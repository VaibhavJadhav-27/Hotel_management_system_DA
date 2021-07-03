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
    public partial class rp_addguest : UserControl
    {

        function fn = new function();
        String query;
        String gid, reid;
        String name, nationality, idprooftype, idproofno, rno, cno;
        String roomid;
        String checkin;

        private void cmbroomno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbroomno.SelectedIndex!=-1)
            {
                rno = cmbroomno.Text;
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                String query1 = "select * from Room where room_no='" + rno + "';";
                con1.Open();
                cmd1.CommandText = query1;
                using (SqlDataReader rd1 = cmd1.ExecuteReader())
                {
                    while (rd1.Read())
                    {
                        roomid = rd1.GetString(0);
                        price = rd1.GetInt32(4);
                        lblprice.Text = price.ToString();
                    }
                }
            }
        }

        public void clearAll()
        {
            txtname.Text = "";
            txtidproofnumber.Text = "";
            txtcontactno.Text = "";
            cmbidprooftype.SelectedIndex = -1;
            cmbNationality.SelectedIndex = -1;
            cmbroombed.SelectedIndex = -1;
            cmbroomno.SelectedIndex = -1;
            cmbroomtype.SelectedIndex = -1;
            lblprice.Text = "";
            lbltotalprice.Text = "";
        }

        private void nudnoofdays_ValueChanged(object sender, EventArgs e)
        {
            nod = Convert.ToInt32(Math.Round(nudnoofdays.Value));
            if(cmbroomno.SelectedIndex==-1)
            {
                MessageBox.Show("Select Room no first");
            }
            else
            {
                totalprice = nod * price;
                lbltotalprice.Text = totalprice.ToString();
            }
        }

        int noa, noc, nod, price, totalprice;

        private void rp_addguest_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void cmbroombed_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbroomno.Items.Clear();
            if(cmbroombed.SelectedIndex==-1 | cmbroomtype.SelectedIndex==-1)
            {
            }
            else
            {
                query = "select room_no from Room where room_type='" + cmbroomtype.Text + "' and room_bed='" + cmbroombed.Text + "' and booked='NO'";
                setComboBox(query, cmbroomno);
            }
            
        }

        

        public rp_addguest()
        {
            InitializeComponent();
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtcontactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtroomno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAlloteRoom_Click(object sender, EventArgs e)
        {
            name = txtname.Text;
            cno = txtcontactno.Text;
            nationality = cmbNationality.Text;
            idprooftype = cmbidprooftype.Text;
            idproofno = txtidproofnumber.Text;
            int count1;
            if(cno.Length!=10)
            {
                MessageBox.Show("Contact number must contain 13 digits");
                return;
            }
            noa = Convert.ToInt32(Math.Round(nudnoofadults.Value));
            noc = Convert.ToInt32(Math.Round(nudnoofchildren.Value));
            rno = cmbroomno.Text;
            nod = Convert.ToInt32(Math.Round(nudnoofdays.Value));
            checkin = DateTime.Now.ToString();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            String query = "SELECT COUNT(*) from Guest;";
            con.Open();
            cmd.CommandText = query;
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    count1 = rd.GetInt32(0);
                    count1 = count1 + 1;
                    gid = "G000" + count1.ToString();
                }
            }
            con.Close();
            if (name == "" || cno == "" || cmbNationality.SelectedIndex == -1 || idproofno == "" || cmbidprooftype.SelectedIndex == -1 || cmbroomtype.SelectedIndex == -1 || cmbroombed.SelectedIndex == -1 || cmbroomno.SelectedIndex == -1 || nod < 1)
            {
                MessageBox.Show("Please fill the details !!");
            }
            else
            {
                String query1 = "insert into Guest values('" + gid + "','" + name + "','" + cno + "','" + nationality + "','" + idprooftype + "','" + idproofno + "'," + noa + "," + noc + ");";
                int i = fn.setData(query1);
                String query2 = "update Room set booked='YES' where room_no='" + rno + "';";
                int j = fn.setData(query2);
                SqlConnection con3 = new SqlConnection();
                con3.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                SqlCommand cmd3 = new SqlCommand();
                cmd3.Connection = con3;
                String query3 = "SELECT COUNT(*) from Records;";
                con3.Open();
                cmd3.CommandText = query3;
                using (SqlDataReader rd3 = cmd3.ExecuteReader())
                {
                    while (rd3.Read())
                    {
                        int count2 = rd3.GetInt32(0);
                        count2 = count2 + 1;
                        reid = "RC00" + count2.ToString();
                    }
                }
                con3.Close();
                String query4 = "insert into Records values('" + reid + "','" + gid + "','" + name + "','" + cno + "'," + noa + "," + noc + ",'" + roomid + "','" + rno + "'," + nod + ",'" + totalprice + "','" + checkin + "','-','N');";
                int k = fn.setData(query4);
                if (i > 0 && j > 0 && k > 0)
                {
                    MessageBox.Show("Room Alloted");
                }
                clearAll();
            }
            
        }

        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }
    }
}
