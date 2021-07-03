using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_Software
{
    public partial class Amin_login : Form
    {
        public Amin_login()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void admin_dashbard1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            panelSlider.Height = btnEmployee.Height;
            panelSlider.Top = btnEmployee.Top;
            ad_employee1.Show();
            ad_employee1.BringToFront();
            admin_dashbard1.Hide();
            ad_room1.Hide();
            adrp_Records1.Hide();
            ad_attendance1.Hide();
            
            
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            panelSlider.Height = btnRoom.Height;
            panelSlider.Top = btnRoom.Top;
            ad_room1.Show();
            ad_room1.BringToFront();
            admin_dashbard1.Hide();
            ad_employee1.Hide();
            adrp_Records1.Hide();
            ad_attendance1.Hide();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            panelSlider.Height = btnRecords.Height;
            panelSlider.Top = btnRecords.Top;
            adrp_Records1.Show();
            adrp_Records1.BringToFront();
            ad_employee1.Hide();
            ad_room1.Hide();
            admin_dashbard1.Hide();
            ad_attendance1.Hide();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            panelSlider.Height = btnAttendance.Height;
            panelSlider.Top = btnAttendance.Top;
            ad_attendance1.Show();
            ad_attendance1.BringToFront();
            admin_dashbard1.Hide();
            ad_employee1.Hide();
            ad_room1.Hide();
            adrp_Records1.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panelSlider.Height = btnLogout.Height;
            panelSlider.Top = btnLogout.Top;
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelSlider.Height = btnDashboard.Height;
            panelSlider.Top = btnDashboard.Top;
            Amin_login_Load(this, null);
            admin_dashbard1.Show();
            admin_dashbard1.BringToFront();
            ad_employee1.Hide();
            ad_room1.Hide();
            adrp_Records1.Hide();
            ad_attendance1.Hide();

        }

        private void Amin_login_Load(object sender, EventArgs e)
        {
            ad_employee1.Hide();
            ad_room1.Hide();
            ad_attendance1.Hide();
            adrp_Records1.Hide();
            admin_dashbard1.Show();
            admin_dashbard1.BringToFront();
            panelSlider.Height = btnDashboard.Height;
            panelSlider.Top = btnDashboard.Top;
            //lblwelcome.Text = "Welcome " + Form1.username;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date2 = DateTime.Now;
            String sdate = date2.ToString("dd-MM-yyyy");
            lbldate1.Text = sdate;
            DateTime time2 = DateTime.Now;
            String stime = time2.ToString("hh:mm:ss");
            lbltime.Text = stime;
        }
    }
}
