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
    public partial class Timekeeper_login : Form
    {
        function fn = new function();
        String query;
        String id, at_date, checkin;

        public Timekeeper_login()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Timekeeper_login_Load(object sender, EventArgs e)
        {
            query = "select * from attendance";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            lblwelcome.Text = "Welcome " + Form1.username;
            
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            id = txtempid.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            String query1 = "select * from Employee where emp_id ='" + id + "';";
            con.Open();
            cmd.CommandText = query1;
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                if (rd.HasRows)
                {
                    con.Close();
                    String date1 = DateTime.Now.ToString("MM-dd-yyyy");
                    String checkin = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = con1;
                    String query2 = "select * from attendance where emp_id ='" + id + "' and at_date='"+date1+"';";
                    con1.Open();
                    cmd1.CommandText = query2;
                    using(SqlDataReader rd1=cmd1.ExecuteReader())
                    {
                        if(rd1.HasRows)
                        {
                            MessageBox.Show("Employee's check in already present!!");
                            con1.Close();
                        }
                        else
                        {
                            con1.Close();
                            query = "insert into attendance values('" + id + "','" + date1 + "','" + checkin + "','-','-');";
                            int i = fn.setData(query);
                            if (i != 0)
                            {
                                //MessageBox.Show("Records insertion successful!!");
                                Timekeeper_login_Load(this, null);
                            }
                            else
                            {
                                MessageBox.Show("Records insertion failed!!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Employee ID does not exist!!");
                    con.Close();
                }
            }       
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            DateTime time = DateTime.Now;
            String sdate = date.ToString("dd-MM-yyyy");
            String stime = time.ToString("hh:mm:ss");
            lbldate.Text = sdate;
            lblTime.Text = stime;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            String checkout = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
            DateTime chout = DateTime.Now;
            id = txtempid.Text;
            if(id !="" && at_date!="")
            {
                at_date = DateTime.Now.ToString("MM-dd-yyyy");
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Hotel management System\\Hotel Management Software\\Database1.mdf;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                String query1 = "select check_in from attendance where emp_id='" + id + "' and at_date='" + at_date + "';";
                con.Open();
                cmd.CommandText = query1;
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            checkin = rd.GetString(0);
                            DateTime chin = DateTime.Parse(checkin);
                            TimeSpan th = chout - chin;
                            String thr = th.Hours.ToString() + ":" + th.Minutes.ToString() + ":" + th.Seconds.ToString();
                            query = "UPDATE attendance SET check_out='" + checkout + "',total_hours='" + thr + "' WHERE emp_id='" + id + "' AND at_date='" + at_date + "';";
                            int i = fn.setData(query);
                            if (i != 0)
                            {
                                Timekeeper_login_Load(this, null);
                            }
                            else
                            {
                                MessageBox.Show("Updation failed !!");
                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("ID and date selected does not match");
                    }
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Fill the ID or select any row from table");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtempid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            at_date = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            checkin = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
