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
    public partial class ad_attendance : UserControl
    {

        function fn = new function();
        String query;

        private void dpfrom_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dpto_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query="select * from attendance where at_date BETWEEN CONVERT(date,'"+dpfrom.Value.ToString("dd-MM-yyyy")+"',105) AND CONVERT(date,'"+dpto.Value.ToString("dd-MM-yyyy")+"',105);";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public ad_attendance()
        {
            InitializeComponent();
        }
    }
}
