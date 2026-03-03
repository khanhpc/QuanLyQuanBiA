using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.DTO;
using WinFormsApp1.DAL;

namespace WinFormsApp1.BLL
{
    public class FoodBLL
    {
        public static List<Food> GetListFoodBLL { get; private set; }

        public static List<Food> GetListFood()
        {
            GetListFoodBLL = FoodDAL.GetListFoodDAL();
            return GetListFoodBLL;
        }

        public static bool ThemMonVaoBill(int idBill, int idFood, int count)
        {
            return FoodDAL.ThemMonVaoBill(idBill, idFood, count);
        }
    }
}
