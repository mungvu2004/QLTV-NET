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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void LoadAccount()
        {
            List<Data> datas = modify.ShowUser();
            if(datas.Count > 0 )
            {
                dgvAccount.DataSource = datas;
                dgvAccount.ClearSelection();
            }
            else
            {
                MessageBox.Show(
                    "Không có tài khoản nào cả!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }
        private void Account_Load(object sender, EventArgs e)
        {
           LoadAccount();
            dgvAccount.DataBindingComplete += (s, ev) =>
            {
                dgvAccount.ClearSelection();
                dgvAccount.CurrentCell = null;
            };
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count >= 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa tài khoản này không!!!",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    List<int> accountToDelete = new List<int>();

                    foreach (DataGridViewRow row in dgvAccount.SelectedRows) // Chỉ lặp qua các hàng được chọn
                    {
                        if (row.Cells["UserID"].Value != null) // Đảm bảo giá trị không null
                        {
                            int userID = Convert.ToInt32(row.Cells["UserID"].Value);
                            accountToDelete.Add(userID); // Thêm vào danh sách ID cần xóa
                        }
                    }

                    // Xóa từng sách theo ID
                    foreach (int userID in accountToDelete)
                    {
                        modify.DeleteAccount(userID);
                    }

                    // Cập nhật lại DataGridView
                    LoadAccount();
                }
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn ít nhất một hàng để xóa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAccount.Rows[e.RowIndex];
                string role = row.Cells["Role"].Value?.ToString() ?? string.Empty;
                if(role.Equals("User"))
                {
                    rbtnUser.Checked = true;
                }
                else
                {
                    rbtnAdmin.Checked = true;
                }
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(dgvAccount.CurrentRow == null)
            {
                MessageBox.Show(
                    "Chọn một hàng để sửa quyền truy cập!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            DataGridViewRow row = dgvAccount.CurrentRow;
            int userID = (int)row.Cells["UserID"].Value;
            string role;
            if(rbtnAdmin.Checked)
            {
                role = rbtnAdmin.Text;
            }
            else
            {
                role = rbtnUser.Text;
            }
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đổi quyền truy cập của tài khoản này!!!",
                "Xác nhận cập nhật",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                bool isUpdate = modify.UpdateRole(userID, role);
                if(isUpdate)
                {
                    MessageBox.Show(
                    "Đã thay đổi quyền truy cập!!!",
                    "Xác nhận cập nhật",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    LoadAccount();
                }
                else
                {
                    MessageBox.Show(
                        "Thay đổi quyền truy cập thất bại. Vui lòng thử lại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
