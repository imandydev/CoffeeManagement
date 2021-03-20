using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffee.Support
{
    public class Product : IComparable<Product>
    {
        private int idDetail;
        private int idPro;
        private string name;
        private string namecate;
        private string size;
        private long price;
        private int other;
        private string status;
        public Product(int idDetail, int idPro, string name, string namecate, string size, long price, int other, string status)
        {
            this.IdDetail = idDetail;
            this.IdPro = idPro;
            this.Name = name;
            this.Namecate = namecate;
            this.Size = size;
            this.Price = price;
            this.Other = other;
            this.Status = status;
           
        }
        public Product(int idPro, string name, string status)
        {
            this.IdPro = idPro;
            this.Name = name;
            this.Status = status;
        }
        public int CompareTo(Product that)
        {
            return this.Other - that.Other;

        }
        public int IdDetail { get => idDetail; set => idDetail = value; }
        public int IdPro { get => idPro; set => idPro = value; }
        public string Name { get => name; set => name = value; }
        public string Namecate { get => namecate; set => namecate = value; }
        public string Size { get => size; set => size = value; }
        public long Price { get => price; set => price = value; }
        public int Other { get => other; set => other = value; }
        public string Status { get => status; set => status = value; }
    }
}
