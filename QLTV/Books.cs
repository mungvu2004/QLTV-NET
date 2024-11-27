using OfficeOpenXml;
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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadComboBox()
        {
            List<Categories> categories = modify.Categrory();

            if (categories.Count > 0)
            {
                cbCategrory.Items.Clear();
                cbCategrory.DataSource = categories;
                cbCategrory.DisplayMember = "CategoryName";
                cbCategrory.ValueMember = "CategoryID";
                cbCategrory.SelectedItem = 0;
                
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị trong ComboBox.");
            }
        }

        private void LoadDataGrid()
        {
            List<Book> books = modify.Books();
            if (books.Count > 0)
            {
               dgvBooks.DataSource = books;
               dgvBooks.ClearSelection();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị!");
            }
            
        }
        private void Books_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadDataGrid();
        }
        private bool CheckQuantity(string quantity)
        {
            foreach(char c in quantity)
            {
                if(!char.IsDigit(c) && !char.IsControl(c))
                {
                    return false;
                }
            }
            return true;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            List<Book> books = modify.Books();
            string bookName = txtBookName.Text.Trim();
            string auther = txtAuthor.Text.Trim();
            int nxb = (int)dateYear.Value.Year;
            string count = txtQuantity.Text.Trim();
            int quantity = 0;
            int cateID = 0;
            if(cbCategrory.SelectedValue != null)
            {
                Console.WriteLine(cbCategrory.SelectedValue.ToString());
                cateID = Convert.ToInt32(cbCategrory.SelectedValue);
            }
            if(string.IsNullOrWhiteSpace(count))
            {
                quantity = 1;
            }
            else if(!CheckQuantity(count))
            {
                MessageBox.Show(
                    "Bạn hãy nhập số lượng cho sách!!!",
                    "Thông báo",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else
            {
                quantity = Convert.ToInt32(count);
            }
            string notifi;
            modify.AddBook(bookName, auther, nxb, quantity, cateID, out notifi);
            if(notifi == null)
            {
                MessageBox.Show(
                    "Đã thêm sách thành công!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                LoadDataGrid();
                txtAuthor.Clear();
                txtBookName.Clear();
                txtQuantity.Clear();
            }
            else
            {
                MessageBox.Show(
                    "Lỗi" + notifi,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(dgvBooks.Rows.Count > 0)
            {
                DialogResult result =  MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa sách này không!!!",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    List<int> bookIDsToDelete = new List<int>();

                    foreach (DataGridViewRow row in dgvBooks.SelectedRows) // Chỉ lặp qua các hàng được chọn
                    {
                        if (row.Cells["BookId"].Value != null) // Đảm bảo giá trị không null
                        {
                            int bookID = Convert.ToInt32(row.Cells["BookId"].Value);
                            bookIDsToDelete.Add(bookID); // Thêm vào danh sách ID cần xóa
                        }
                    }

                    // Xóa từng sách theo ID
                    foreach (int bookID in bookIDsToDelete)
                    {
                        modify.DeleteBook(bookID);
                    }

                    // Cập nhật lại DataGridView
                    LoadDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên các TextBox
                txtBookName.Text = row.Cells["Title"].Value?.ToString() ?? string.Empty;
                txtAuthor.Text = row.Cells["Author"].Value?.ToString() ?? string.Empty;
                txtQuantity.Text = row.Cells["Quantity"].Value?.ToString() ?? "0";

                // Hiển thị dữ liệu lên ComboBox
                var tl = row.Cells["CategoryID"].Value;
                if (tl != null)
                {
                    cbCategrory.SelectedValue = tl;
                }

                // Hiển thị dữ liệu lên DateTimePicker
                var nxb = row.Cells["Year"].Value;
                if (nxb != null && int.TryParse(nxb.ToString(), out int year))
                {
                    // Tạo DateTime từ năm
                    dateYear.Value = new DateTime(year, 1, 1); // Gán ngày mặc định là 1/1
                }
                else
                {
                    dateYear.Value = DateTime.Now; // Giá trị mặc định
                }
            }
            else
            {
                // Làm sạch các điều khiển khi không chọn hàng
                txtBookName.Text = string.Empty;
                txtAuthor.Text = string.Empty;
                txtQuantity.Text = "0";
                cbCategrory.SelectedIndex = -1;
                dateYear.Value = DateTime.Now;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn một hàng để cập nhật thông tin sách.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvBooks.CurrentRow;
            int bookID = (int)row.Cells["BookID"].Value;
            string bookName = txtBookName.Text.Trim();
            string author = txtAuthor.Text.Trim();
            int nxb = (int)dateYear.Value.Year;

          
            string count = txtQuantity.Text.Trim();
            int quantity;
            if (string.IsNullOrWhiteSpace(count))
            {
                quantity = 1; 
            }
            else if (!CheckQuantity(count))
            {
                MessageBox.Show(
                    "Bạn hãy nhập số lượng hợp lệ cho sách (chỉ chấp nhận số).",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; 
            }
            else
            {
                quantity = Convert.ToInt32(count);
            }

            // Kiểm tra danh mục
            int cateID = 0;
            if (cbCategrory.SelectedValue != null)
            {
                cateID = Convert.ToInt32(cbCategrory.SelectedValue);
            }

           
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn cập nhật thông tin sách này?",
                "Xác nhận cập nhật",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                bool isUpdated = modify.UpdateBook(bookID, bookName, author, nxb, quantity, cateID);

           
                if (isUpdated)
                {
                    MessageBox.Show(
                        "Cập nhật thông tin sách thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    
                    LoadDataGrid();
                    txtAuthor.Clear();
                    txtBookName.Clear();
                    txtQuantity.Clear();
                   
                }
                else
                {
                    MessageBox.Show(
                        "Cập nhật thông tin sách thất bại. Vui lòng thử lại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                DataTable resultTable = modify.SearchBook(keyword);
                dgvBooks.ClearSelection();
                dgvBooks.DataSource = resultTable;
            }
            else
            {
                dgvBooks.DataSource = null; // Xóa kết quả khi không có từ khóa }
                LoadDataGrid();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                openFileDialog.Filter = "Excel Files (*.xlsx;*.xls)|*.xlsx;*.xls";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    // Gọi phương thức AddExeclBooks từ Modify class
                    modify.AddExcelBooks(filePath);
                    LoadDataGrid();
                }
            }
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
