using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.DAL;
using WinFormsApp1.DTO;

namespace WinFormsApp1.BLL
{
    public class BilliardTableBLL
    {
        public static List<BilliardTable> GetBilliardTableBLL { get; private set; }
        public static List<BilliardTable> LoadListTableBLL()
        {
            GetBilliardTableBLL = BilliardTableDAL.LoadListTableDAL();
            return GetBilliardTableBLL;
        }
        public static List<BilliardTable> LoadListTableChuyenBanDAL()
        {
            return BilliardTableDAL.LoadListTableChuyenBanDAL();
        }
    }
}
