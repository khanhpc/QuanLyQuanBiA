using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.DTO
{
    public class BilliardTable
    {
        public BilliardTable()
        {
            Category = new TableCategory();
        }

        public BilliardTable(int id, string name, string status, int idCategory)
        {
            this.id = id;
            this.name = name;
            this.status = status;
            this.idCategory = idCategory;
            Category = new TableCategory();
        }

        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public int idCategory { get; set; }

        public TableCategory Category { get; set; }

    }
}
