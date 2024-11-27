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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        private void LoadStudent()
        {
            DataTable students = modify.GetStudent();
            if (students.Rows.Count > 0)
            {
                dgvStudents.DataSource = students;
                dgvStudents.ClearSelection();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void Student_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private bool checkId(string studentID)
        {
            return studentID.Length > 9 && studentID.Length < 12 && studentID.All(char.IsDigit);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = "";
            if (checkId(txtID.Text.Trim()))
            {
                id = txtID.Text.Trim();
            }
            else
            {
                MessageBox.Show("Bạn hãy nhập đúng mã sinh viên!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                return;
            }
            string name = txtName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string phone = txtPhone.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Bạn hãy nhập tên sinh viên!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                return;
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Bạn không được để trống địa chỉ!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                return;
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Bạn không đc để trống số điện thoại!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                return;
            }
            try
            {
                modify.InsertStudent(id, name, address, phone);
                MessageBox.Show("Thêm sinh viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadStudent();
                txtID.Clear();
                txtName.Clear();
                txtAddress.Clear();
                txtPhone.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sinh viên: {ex.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                txtName.Text = row.Cells["Name"].Value.ToString() ?? string.Empty;
                txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString() ?? string.Empty;
                txtAddress.Text = row.Cells["Address"].Value.ToString() ?? string.Empty;
            }
            else
            {
                txtAddress.Text = string.Empty;
                txtID.Text = string.Empty;
                txtName.Text = string.Empty;
                txtAddress.Text = string.Empty;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn sinh viên bạn muốn thay đổi thông tin!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow row = dgvStudents.CurrentRow;
            string id = row.Cells["StudentID"].Value.ToString() ?? string.Empty;
            string name = txtName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string phone = txtPhone.Text.Trim();
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn sửa?",
                "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                bool isUs = modify.EditStudent(id, name, address, phone);
                if (isUs)
                {
                    MessageBox.Show("sửa thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    LoadStudent();
                    txtID.Clear();
                    txtName.Clear();
                    txtAddress.Clear();
                    txtPhone.Clear();
                }
                else
                {
                    MessageBox.Show("Lỗi!!!");
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa?",
                    "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    List<string> ints = new List<string>();
                    foreach(DataGridViewRow row in dgvStudents.SelectedRows)
                    {
                        if (row.Cells["StudentID"].Value != null)
                        {
                            string id = row.Cells["StudentID"].Value.ToString();
                            ints.Add(id);
                        }
                    }
                    foreach(string id in ints)
                    {
                        modify.DeleteStudent(id);
                    }
                    MessageBox.Show(
                        "Bạn đã xóa thành công!!!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadStudent();
                }
                else
                {
                    MessageBox.Show(
                            "Vui lòng chọn sinh viên để xóa?",
                            "Thông báo",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Information);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            if(!string.IsNullOrEmpty(search))
            {
                DataTable dt = modify.SearchStudent(search);
                dgvStudents.ClearSelection();
                dgvStudents.DataSource = dt;
            }
            else
            {
                dgvStudents.DataSource = null;
                LoadStudent();
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(search))
            {
                DataTable dt = modify.SearchStudent(search);
                dgvStudents.ClearSelection();
                dgvStudents.DataSource = dt;
            }
            else
            {
                dgvStudents.DataSource = null;
                LoadStudent();
            }
        }

    }
}
