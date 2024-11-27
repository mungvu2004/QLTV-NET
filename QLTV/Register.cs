using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();
        private bool checkEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; 
            return Regex.IsMatch(email, pattern);
        }
        private bool checkPass(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(password, pattern);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string ex;
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string comfim = txtComfim.Text.Trim();
            string fullname = txtFullname.Text.Trim();
            string[] check = {email, password, comfim, fullname};

            if(check.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show(
                    "Bạn hãy nhập đầy đủ thông tin!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
            }
            else if (password.CompareTo(comfim) != 0)
            {
                MessageBox.Show(
                    "Hãy kiểm tra lại xác nhận mật khẩu!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if(modify.CheckEmail(email, out ex))
            {
                MessageBox.Show(
                    ex,
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                string passHash = BCrypt.Net.BCrypt.HashPassword(password);
                modify.Register(email, passHash, fullname, out ex);
                if(string.IsNullOrEmpty(ex))
                {
                    MessageBox.Show(
                    "Bạn đã đăng kí tài khoàn thành công!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                    ex,
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    
                }
            }
        }

       
    }
}
