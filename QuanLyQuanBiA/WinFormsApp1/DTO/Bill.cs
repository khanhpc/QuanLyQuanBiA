using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.DTO
{
    public class Bill
    {
        public int id { get; set; }
        public DateTime dateCheckIn { get; set; }
        public DateTime? dateCheckOut { get; set; }
        public int idTable { get; set; }
        public int status { get; set; }
        public int idDiscount { get; set; }
        public float totalPrice { get; set; }

        public int idAccount { get; set; }

        public Bill()
        {
            Table = new BilliardTable();
        }

        public Bill(int id, DateTime dateCheckIn, DateTime? dateCheckOut, int idTable, int status, int idDiscount, float totalPrice, int idAccount)
        {
            this.id = id;
            this.dateCheckIn = dateCheckIn;
            this.dateCheckOut = dateCheckOut;
            this.idTable = idTable;
            this.status = status;
            this.idDiscount = idDiscount;
            this.totalPrice = totalPrice;
            this.idAccount = idAccount;
        }

        public BilliardTable Table { get; set; }
    }
}
