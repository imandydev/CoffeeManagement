using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffee.Support
{
    public class BillInforDTO
    {
        private int id;
        private int idBill;
        private int idDetail;
        private int amount;
        private long price;

        public BillInforDTO(int id, int idBill, int idDetail, int amount, long price)
        {
            this.Id = id;
            this.IdBill = idBill;
            this.IdDetail = idDetail;
            this.Amount = amount;
            this.Price = price;
        }

        public int Id { get => id; set => id = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdDetail { get => idDetail; set => idDetail = value; }
        public int Amount { get => amount; set => amount = value; }
        public long Price { get => price; set => price = value; }
    }
}
