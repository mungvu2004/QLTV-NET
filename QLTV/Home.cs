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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void Home_Load(object sender, EventArgs e)
        {
            btnData.Controls.Clear();
            Books books = new Books();
            books.TopLevel = false;
            books.Dock = DockStyle.Fill;
            btnData.Controls.Add(books);

            books.Show();
            btnBook.Click += new EventHandler(panel5_Click);
            pictureBox2.Click += new EventHandler(panel5_Click);
            label1.Click += new EventHandler(panel5_Click);

            btnAccount.Click += new EventHandler(panel6_Click);
            pictureBox3.Click += new EventHandler(panel6_Click);
            label2.Click += new EventHandler(panel6_Click);

            pictureBox1.Click += new EventHandler(panel5_Click);

            btnStudent.Click += new EventHandler(btnStudent_Click);
            pictureBox4.Click += new EventHandler(btnStudent_Click);
            label3.Click += new EventHandler(btnStudent_Click);

            btnBorrow.Click += new EventHandler(panel8_Click);
            pictureBox5.Click += new EventHandler(panel8_Click);
            label4.Click += new EventHandler(panel8_Click);
            
        }
        
        
        
        private void panel5_Click(object sender, EventArgs e)
        {
            btnData.Controls.Clear();
            Books books = new Books();
            books.TopLevel = false;
            books.Dock = DockStyle.Fill;
            btnData.Controls.Add(books);
            books.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (modify.CheckRole())
            {
                btnData.Controls.Clear();
                Account account = new Account();
                account.TopLevel = false;
                account.Dock = DockStyle.Fill;
                btnData.Controls.Add(account);
                account.Show();
            }
            else
            {
                MessageBox.Show(
                    "Vai trò của bạn không đc truy cập chức năng này!!!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Dừng toàn bộ tiến trình của ứng dụng
                Application.Exit();  // Dừng ứng dụng khi đóng form
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            btnData.Controls.Clear();
            Student student = new Student();
            student.TopLevel = false;
            student.Dock = DockStyle.Fill;
            btnData.Controls.Add(student);
            student.Show();
        }

        private void btnBook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.TopLevel = false;
            borrow.Dock = DockStyle.Fill;
            btnData.Controls.Add(borrow);
            borrow.Show();
        }

        private void btnData_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
