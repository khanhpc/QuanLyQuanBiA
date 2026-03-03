using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.BLL;
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text.Trim();
                string passWord = txtPassWord.Text.Trim();
                Account acc = LoginBLL.CheckLoginBLL(userName, passWord);

                if (acc != null)
                {
                    Ultils.SessionManager.CurrentUser = acc;
                    MessageBox.Show("Đăng Nhập Thành Công!");
                    txtUserName.ResetText();
                    txtPassWord.ResetText();
                    if (acc.type == 0)
                    {
                        Hide();
                        MainPanel1 a = new MainPanel1();
                        a.ShowDialog();
                        Show();
                    }
                }
                else
                {
                    MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
