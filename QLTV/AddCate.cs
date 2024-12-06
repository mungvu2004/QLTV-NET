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
    public partial class AddCate : Form
    {
        public AddCate()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void btnCate_Click(object sender, EventArgs e)
        {
            string mess;
            string tenTL = txtCate.Text.Trim();
            if(string.IsNullOrWhiteSpace(tenTL))
            {
                MessageBox.Show("Bạn hãy nhập thể loại để thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                bool isUs = modify.AddCate(tenTL, out mess);
                if(isUs)
                {
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCate.Clear();
                }
                else
                {
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    
                }
            }
        }
    }
}
