using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.DTO
{
    public class TableCategory
    {
        public TableCategory() { }

        public TableCategory(int id, string name, float price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
    }
}
