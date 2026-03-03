using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.DAL;
using WinFormsApp1.DTO;

namespace WinFormsApp1.BLL
{
    public class TableCategoryBLL
    {
        public static List<TableCategory> GetTableCategory()
        {
            return TableCategoryDAL.GetListTableCategoryDAL();
        }
    }
}
