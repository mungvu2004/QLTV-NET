using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace QLTV
{
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();

        private void LoadBorrow()
        {
            DataTable dataTable = modify.GetBorrow();
            if (dataTable != null)
            {

                dgvBorrow.DataSource = dataTable;
                Application.DoEvents();
                dgvBorrow.CurrentCell = null;
                dgvBorrow.ClearSelection();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void Borrow_Load(object sender, EventArgs e)
        {

            dtpReturn.Value = DateTime.Now.AddDays(7);
            LoadBorrow();
            dgvBorrow.DataBindingComplete += (s, ev) =>
            {
                dgvBorrow.ClearSelection();
                dgvBorrow.CurrentCell = null;
            };
            LoadComboBox();
            SetPlaceholder(cbStatus, PlaceholderText);
            dgvBorrow.DataBindingComplete += dgvBorrow_DataBindingComplete;
        }

        private void dgvBorrow_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvBorrow.Columns["StudentID"].HeaderText = "Mã Sinh Viên";
            dgvBorrow.Columns["StudentName"].HeaderText = "Tên Sinh Viên";
            dgvBorrow.Columns["BookTitle"].HeaderText = "Tên Sách";
            dgvBorrow.Columns["NameUser"].HeaderText = "Tên Người Tạo";
            dgvBorrow.Columns["BorrowDate"].HeaderText = "Ngày Mượn";
            dgvBorrow.Columns["ReturnDate"].HeaderText = "Ngày Trả";
            dgvBorrow.Columns["Quantity"].HeaderText = "Số Lượng";
            dgvBorrow.Columns["Status"].HeaderText = "Trạng Thái";
        }


        private void LoadComboBox()
        {
            DataTable dtStudent = modify.GetStudent();
            if (dtStudent != null)
            {
                cbStudent.Items.Clear();
                cbStudent.DataSource = dtStudent;
                cbStudent.DisplayMember = "StudentID";
                cbStudent.SelectedIndex = -1;
            }
            List<Book> books = modify.Books();
            if (books.Count > 0)
            {
                cbBook.Items.Clear();
                cbBook.DataSource = books;
                cbBook.DisplayMember = "Title";
                cbBook.ValueMember = "BookID";
                cbBook.SelectedIndex = -1;
            }
            DataTable dtStatus = new DataTable();
            dtStatus.Columns.Add("Display", typeof(string));
            dtStatus.Columns.Add("Value", typeof(string));
            dtStatus.Rows.Add("Đang mượn", "Borrowed");
            dtStatus.Rows.Add("Đã trả", "Returned");
            dtStatus.Rows.Add("Đã mất", "Lost");
            cbStatus.Items.Clear();
            cbStatus.DataSource = dtStatus;
            cbStatus.DisplayMember = "Display";
            cbStatus.ValueMember = "Value";
            cbStatus.SelectedIndex = -1;
        }


        string PlaceholderText = "Nhập trạng thái";
        string PlaceholderCount = "Nhập số lượng";
        private void SetPlaceholder(ComboBox comboBox, string placeholder)
        {
            comboBox.ForeColor = System.Drawing.Color.Gray;
            comboBox.Text = placeholder;
        }
        private void RemovePlaceholder(ComboBox comboBox, string placeholder)
        {
            if (comboBox.Text == placeholder)
            {
                comboBox.Text = "";
                comboBox.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void cbStatus_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(cbStatus, PlaceholderText);
        }
        private void cbStatus_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbStatus.Text))
            {
                SetPlaceholder(cbStatus, PlaceholderText);
            }
        }
        private bool IsNumber(string input)
        {
            if (int.TryParse(input, out _)) return true;
            return false;
        }
        private void btnThêm_Click(object sender, EventArgs e)
        {
            string message;
            string studentID = cbStudent.Text.Trim();
            int bookID = Convert.ToInt32(cbBook.SelectedValue);
            DateTime returnBook = dtpReturn.Value;
            int coutBook = 0;
            if (string.IsNullOrWhiteSpace(txtCount.Text.Trim()))
            {
                coutBook = 1;
            }
            else
            {
                if (IsNumber(txtCount.Text.Trim()))
                {
                    coutBook = int.Parse(txtCount.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Bạn hãy nhập đúng định dạng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(studentID))
            {
                MessageBox.Show(
                    "Hãy chọn sinh viên để tạo phiếu?",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else if (string.IsNullOrWhiteSpace(cbBook.Text.Trim()))
            {
                MessageBox.Show(
                    "Hãy chọn sách để tạo phiếu?",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            bool isUs = modify.UpdateBorrow(studentID, bookID, returnBook, coutBook, out message);
            if(isUs)
            {
                MessageBox.Show(
                message,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                LoadBorrow();
                cbBook.Text = string.Empty;
                cbStatus.Text = string.Empty;
                cbStudent.Text = string.Empty;
                txtCount.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(
                    $"Lỗi!!! Thêm thất bại: {message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cbBook.Text = string.Empty;
                cbStatus.Text = string.Empty;
                cbStudent.Text = string.Empty;
                txtCount.Text = string.Empty;
            }
            
        }

        private void btnXóa_Click(object sender, EventArgs e)
        {
            bool isUs = modify.CheckRole();
            if (!isUs)
            {
                MessageBox.Show(
                    $"Bạn không có quyền để xóa!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            if (dgvBorrow.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvBorrow.CurrentRow;
                int borrowID = int.Parse(row.Cells["BorrowID"].Value.ToString());
                string status = row.Cells["Status"].Value.ToString();
                bool isUS = modify.DeleteBorrow(borrowID, status);
                if (isUS)
                {
                    MessageBox.Show(
                        $"Đã xóa thành công!!!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadBorrow();
                }
                else
                {
                    MessageBox.Show(
                        $"Lỗi!!! Xóa thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    $"Bạn hãy chọn phiếu để xóa!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void dgvBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBorrow.Rows[e.RowIndex];
                cbStudent.Text = row.Cells["StudentID"].Value.ToString() ?? string.Empty;
                cbBook.Text = row.Cells["BookTitle"].Value.ToString() ?? string.Empty;
                string statusValue = row.Cells["Status"].Value?.ToString() ?? string.Empty;
                foreach (DataRowView item in cbStatus.Items)
                {
                    if (item["Value"].ToString() == statusValue)
                    {
                        cbStatus.SelectedItem = item;
                        break;
                    }
                }
                txtCount.Text = Convert.ToString(row.Cells["Quantity"].Value);
                var returnDate = row.Cells["ReturnDate"].Value;
                if (returnDate != null && int.TryParse(returnDate.ToString(), out int year))
                {
                    dtpReturn.Value = new DateTime(year, 1, 1);
                }
                else
                {
                    dtpReturn.Value = DateTime.Now;
                }
            }
            else
            {
                cbBook.Text = string.Empty;
                cbStatus.Text = string.Empty;
                cbStudent.Text = string.Empty;
                txtCount.Text = string.Empty;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvBorrow.SelectedRows.Count > 0)
            {
                string studentID = cbStudent.Text.Trim();
                int bookID = Convert.ToInt32(cbBook.SelectedValue);
                DateTime returnBook = dtpReturn.Value;
                string status = cbStatus.SelectedValue.ToString();
                DataGridViewRow row = dgvBorrow.CurrentRow;
                int borrowID = int.Parse(row.Cells["BorrowID"].Value.ToString());
                int quantity;
                if (!int.TryParse(txtCount.Text.Trim(), out quantity) || quantity <= 0)
                {
                    MessageBox.Show("Số lượng phải là số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(string.IsNullOrWhiteSpace(studentID) || string.IsNullOrWhiteSpace(cbBook.Text.Trim()))
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    modify.EditBorrow(studentID, bookID, borrowID, returnBook, quantity, status);
                    MessageBox.Show(
                        "Đã sửa thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadBorrow();
                    cbBook.Text = string.Empty;
                    cbStatus.Text = string.Empty;
                    cbStudent.Text = string.Empty;
                    txtCount.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn phiếu cần sửa!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            string check = rbtnSv.Checked ? "Student" : "Book";
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                DataTable data = modify.SearchBorrow(keyword, check);
                dgvBorrow.DataSource = data;
                dgvBorrow.ClearSelection();
            }
            else
            {
                dgvBorrow.DataSource = null;
                LoadBorrow();
            }
        }

        private void btnXemCT_Click(object sender, EventArgs e)
        {

            string id = cbStudent.Text.Trim();
            DataTable dt = modify.DetailBorrow(id);
            DetailBorrow detailBorrow = new DetailBorrow(id, dt);
            detailBorrow.Show();
        }

        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
