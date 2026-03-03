using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.DAL;
using WinFormsApp1.DTO;

namespace WinFormsApp1.BLL
{
    public class LoginBLL
    {
        public static Account CheckLoginBLL(string userName, string passWord)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
            {
                throw new Exception("Vui Lòng Nhập Đầy Đủ Tài Khoản và Mật Khẩu!");
            }

            return LoginDAL.CheckLoginDAL(userName, passWord);
        }
    }
}
