using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffee.Support
{
    public class DetailProduct
    {
        private int id;
        private int idFood;
        private string size;
        private int price;

        public DetailProduct(int id, int idFood, string size, int price)
        {
            this.Id = id;
            this.IdFood = idFood;
            this.Size = size;
            this.Price = price;
        }

        public int Id { get => id; set => id = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public string Size { get => size; set => size = value; }
        public int Price { get => price; set => price = value; }
    }
}
