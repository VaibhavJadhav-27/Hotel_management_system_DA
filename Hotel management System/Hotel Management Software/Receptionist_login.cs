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
    public partial class Receptionist_login : Form
    {
        public Receptionist_login()
        {
            InitializeComponent();
            timer1.Start();
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

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            panelSlider1.Height = btnAddGuest.Height;
            panelSlider1.Top = btnAddGuest.Top;
            rp_addguest1.Show();
            rp_addguest1.BringToFront();
            adrp_Records1.Hide();
            rp_checkout1.Hide();
            rp_laundry1.Hide();
            rp_package1.Hide();
            
            
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            panelSlider1.Height = btnPackages.Height;
            panelSlider1.Top = btnPackages.Top;
            rp_package1.Show();
            rp_package1.BringToFront();
            rp_laundry1.Hide();
            adrp_Records1.Hide();
            rp_checkout1.Hide();
            rp_addguest1.Hide();
        }

        private void btnOLuxuries_Click(object sender, EventArgs e)
        {
            panelSlider1.Height = btnOLuxuries.Height;
            panelSlider1.Top = btnOLuxuries.Top;
            rp_laundry1.Show();
            rp_laundry1.BringToFront();
            rp_checkout1.Hide();
            rp_package1.Hide();
            adrp_Records1.Hide();
            rp_addguest1.Hide();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            panelSlider1.Height = btnCheckout.Height;
            panelSlider1.Top = btnCheckout.Top;
            rp_checkout1.Show();
            rp_checkout1.BringToFront();
            adrp_Records1.Hide();
            rp_addguest1.Hide();
            rp_laundry1.Hide();
            rp_package1.Hide();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            panelSlider1.Height = btnRecords.Height;
            panelSlider1.Top = btnRecords.Top;
            adrp_Records1.Show();
            adrp_Records1.BringToFront();
            rp_checkout1.Hide();
            rp_package1.Hide();
            rp_laundry1.Hide();
            rp_addguest1.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panelSlider1.Height = btnLogout.Height;
            panelSlider1.Top = btnLogout.Top;
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void Receptionist_login_Load(object sender, EventArgs e)
        {
            panelSlider1.Height = btnAddGuest.Height;
            panelSlider1.Top = btnAddGuest.Top;
            rp_addguest1.Show();
            rp_addguest1.BringToFront();
            adrp_Records1.Hide();
            rp_checkout1.Hide();
            rp_laundry1.Hide();
            rp_package1.Hide();
        }
    }
}
