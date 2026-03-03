using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.DTO
{
    public class Food
    {
        public int id { get; set; }
        public string name { get; set; }
        public int idCategory { get; set; }
        public float price { get; set; }
        public string url { get; set; }

        public Food() { }

        public Food(int id, string name, int idCategory, float price, string url)
        {
            this.id = id;
            this.name = name;
            this.idCategory = idCategory;
            this.price = price;
            this.url = url;
        }
    }
}
