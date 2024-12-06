using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát!",
                "Thông báo",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel= true;
            }
        }
        Modify modify = new Modify();
        string error;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role;
            if(rbtnAdmin.Checked)
            {
                role = "Admin";
            }
            else
            {
                role = "User";
            }

            if(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)) 
            {
                MessageBox.Show(
                "Bạn hãy nhập đầy đủ thông tin!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question);
            }
            else if(modify.CheckLogin(email, password, role , out error))
            {

                MessageBox.Show(
                $"{error}",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question);
                this.Hide();
                Home home = new Home();
                home.Show();
            }
            else
            {

                MessageBox.Show(
                $"Bạn đang gặp lỗi: {error}",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question);
            }
        }

        private void btnResign_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
