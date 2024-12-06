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
    public partial class AddDetail : Form
    {
        public AddDetail()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void LoadCombobox()
        {
            List<Book> books = modify.Books();
            if (books.Count > 0)
            {
                cdbook.Items.Clear();
                cdbook.DataSource = books;
                cdbook.DisplayMember = "Title";
                cdbook.ValueMember = "BookID";
                cdbook.SelectedIndex = -1;
            }
        }

        private void AddDetail_Load(object sender, EventArgs e)
        {
            LoadCombobox();
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cdbook.SelectedValue);
            string detail = txtMota.Text.Trim();
            bool check = modify.CheckDetail(id);
            if (check)
            {
                MessageBox.Show("Sách này đã có mô tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool isUs = modify.AddDetail(id, detail);
                if (isUs)
                {
                    MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtMota.Text = string.Empty;
                    return;

                }
                else
                {
                    MessageBox.Show("Đã cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }    
            }
        }
    }
}
