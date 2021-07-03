using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_Software
{
    public partial class adrp_Records : UserControl
    {

        function fn = new function();
        String query;

        public adrp_Records()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            cmbsearchtype.SelectedIndex = -1;
            adrp_Records_Load(this, null);
        }

        private void adrp_Records_Load(object sender, EventArgs e)
        {
            /*query = "select * from Records";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];*/
        }

        private void cmbsearchtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbsearchtype.SelectedIndex==0)
            {
                query = "select * from Records";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if(cmbsearchtype.SelectedIndex==1)
            {
                query = "select * from Records where check_out_yn='N'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            if(cmbsearchtype.SelectedIndex==2)
            {
                query = "select * from Records where check_out_yn='Y'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void adrp_Records_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
