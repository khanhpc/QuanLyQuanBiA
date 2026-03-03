using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.DTO
{
    public class Account
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string displayName { get; set; }
        public int type { get; set; }

        public Account()
        {

        }

        public Account(int id, string userName, string password, string displayName, int type)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.displayName = displayName;
            this.type = type;
        }
    }
}
