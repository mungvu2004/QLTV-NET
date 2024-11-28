using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class Detailbook : Form
    {
        public Detailbook(int bookID , DataTable dt)
        {
            InitializeComponent();
            dgvdetail.DataSource = dt;
            if (dgvdetail.Rows.Count > 0 )
            {
                DataGridViewRow row = dgvdetail.Rows[0];
                lbnamebook.Text = lbnamebook.Text + row.Cells["Title"].Value.ToString() ?? string.Empty;
                lbtg.Text = lbtg.Text + row.Cells["Author"].Value.ToString() ?? string.Empty;
                lbttct.Text = lbttct.Text + row.Cells["Detail"].Value.ToString() ?? string.Empty;
            }
            else
            {
                MessageBox.Show("Khong the hien thi ");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvdetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
