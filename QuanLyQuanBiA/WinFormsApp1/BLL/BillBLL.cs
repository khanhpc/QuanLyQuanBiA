using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.DAL;
using WinFormsApp1.DTO;

namespace WinFormsApp1.BLL
{
    public class BillBLL
    {
        public static bool MoBanVaBamGio(int idBan, int idAccount)
        {
            return BillDAL.MoBanVaBamGio(idBan, idAccount);
        }

        public static bool DongBan(int idBan)
        {
            return BillDAL.DongBan(idBan);
        }

        public static List<MenuDTO> GetListMenuTable(int idBan)
        {
            return BillDAL.GetListMenuTable(idBan);
        }

        public static List<Bill> GetDateIn_DateOut(int idBan)
        {
            return BillDAL.GetDateIn_DateOut(idBan);
        }

        public static int GetUncheckBillIDByTableID(int idTable)
        {
            return BillDAL.GetUncheckBillIDByTableID(idTable);
        }

        public static bool ThanhToanBill(int idBan, double totalPrice)
        {
            return BillDAL.ThanhToanBill(idBan, totalPrice);
        }

        public static bool ChuyenBan(int idBanCu, int idBanMoi)
        {
            return BillDAL.ChuyenBan(idBanCu, idBanMoi);
        }
    }
}
