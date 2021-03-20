using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffee.Support
{
    public class BillDTO
    {
        private int id;
        private int idAccount;
        private string username;
        private long total;
        private string founding;
        private long discount;

        public BillDTO(int id, int idAccount, string username, long total, string founding, long discount)
        {
            this.Id = id;
            this.IdAccount = idAccount;
            this.Username = username;
            this.Founding = founding;
            this.Discount = discount;
            this.Total = total;
        }

        public int Id { get => id; set => id = value; }
        public int IdAccount { get => idAccount; set => idAccount = value; }
        public string Username { get => username; set => username = value; }
        
        public string Founding { get => founding; set => founding = value; }
        public long Discount { get => discount; set => discount = value; }
        public long Total { get => total; set => total = value; }
    }
}
