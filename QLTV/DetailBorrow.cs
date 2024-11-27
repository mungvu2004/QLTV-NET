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
    public partial class DetailBorrow : Form
    {
        public DetailBorrow(string id, DataTable dt)
        {
            InitializeComponent();
            dgv1.DataSource = dt;
            Console.WriteLine(dt);
            if (dgv1.Rows.Count >= 0)
            {
                // Lấy dòng đầu tiên từ DataGridView
                DataGridViewRow row = dgv1.Rows[0]; // Thay vì sử dụng CurrentRow

                // Cập nhật Label với dữ liệu từ dòng đầu tiên
                label1.Text = label1.Text + $"{row.Cells["BorrowID"].Value?.ToString() ?? string.Empty}";
                label2.Text = label2.Text + $"{row.Cells["StudentName"].Value?.ToString() ?? string.Empty}";
                label3.Text = label3.Text + $"{row.Cells["StudentID"].Value?.ToString() ?? string.Empty}";
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        
        private void DetailBorrow_Load(object sender, EventArgs e)
        {

        }
    }
}
