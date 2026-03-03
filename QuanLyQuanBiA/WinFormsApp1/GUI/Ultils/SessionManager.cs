using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI.Ultils
{
    public class SessionManager
    {
        public static Account CurrentUser{ get; set; }
        public static bool IsLoggedIn() { 
            return CurrentUser != null;
        }
        public static void Logout() { 
            CurrentUser = null;
        }
    }
}
