using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffee.DTO
{
    public class CategoryItem : IComparable<CategoryItem>
    {
        private int id;
        private string nameCate;
        private int orther;
        public CategoryItem(int id, string nameCate, int orther)
        {
            this.id = id;
            this.nameCate = nameCate;
            this.orther = orther;
        }
        public CategoryItem(FoodCategory cate)
        {
            this.id = (int)cate.idcategory;
            this.nameCate = cate.namecategory;
            this.orther = (int)cate.orther;
        }
        public int ID { get => id; set => id = value; }
        public string NameCate { get => nameCate; set => nameCate = value; }
        public int Orther { get => orther; set => orther = value; }

        public int CompareTo(CategoryItem that)
        {
            return this.Orther - that.Orther;

        }
    }
}
