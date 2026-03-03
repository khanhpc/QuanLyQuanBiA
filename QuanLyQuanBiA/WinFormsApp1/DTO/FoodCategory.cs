using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.DTO
{
    public class FoodCategory
    {
        public int id { get; set; }
        public string name { get; set; }
        public FoodCategory()
        {
        }

        public FoodCategory(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
