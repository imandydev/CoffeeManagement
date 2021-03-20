using ManagerCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffee.DAO
{
   public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO
            Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            set
            {
                instance = value;
            }
        }
        private CategoryDAO()
        {

        }
       
        public List<CategoryItem> loadCate()
        {
            List<CategoryItem> listCate = new List<CategoryItem>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from cate in db.FoodCategories
                           select cate;
                foreach (FoodCategory item in data)
                {
                    listCate.Add(new CategoryItem(item));
                }
                listCate.Sort();
            }
            return listCate;
        }
        // tìm kiếm theo id
        public List<CategoryItem> searchCateByID(int id)
        {
            List<CategoryItem> listCate = new List<CategoryItem>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from cate in db.FoodCategories where cate.idcategory == id
                           select cate;
                foreach (FoodCategory item in data)
                {
                    listCate.Add(new CategoryItem(item));
                }
                listCate.Sort();
            }
            return listCate;
        }
        // tìm kiếm theo name
        public List<CategoryItem> searchCateByNameCate(string name)
        {
            List<CategoryItem> listCate = new List<CategoryItem>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from cate in db.FoodCategories
                           where cate.namecategory.Contains(name)
                           select cate;
                foreach (FoodCategory item in data)
                {
                    listCate.Add(new CategoryItem(item));
                }
                listCate.Sort();
            }
            return listCate;
        }
        public List<string> listCate()
        {
            List<String> listNameCate = new List<string>();
            List<CategoryItem> listCate = loadCate();
            foreach(CategoryItem item in listCate)
            {
                listNameCate.Add(item.NameCate);
            }
            return listNameCate;
         }
        public List<int> listIdCate()
        {
            List<int> listIDCate = new List<int>();
            List<CategoryItem> listCate = loadCate();
            foreach (CategoryItem item in listCate)
            {
                listIDCate.Add(item.ID);
            }
            return listIDCate;
        }
        public int getIdCateByNameCate( string Name)
        {
            foreach(CategoryItem item in loadCate())
            {
                if (item.NameCate.Equals(Name))
                    return item.ID;
            }
            return 0;
        }
        public string getNameCateByIdCate(int id)
        {
            foreach (CategoryItem item in loadCate())
            {
                if (item.ID.Equals(id))
                    return item.NameCate;
            }
            return null;
        }
        public bool insert(FoodCategory cate)
        {
            List<CategoryItem> listCate = loadCate();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                foreach(CategoryItem item in listCate)
                {
                    if (cate.namecategory.Equals(item.NameCate))
                        return false;
                }
                db.FoodCategories.InsertOnSubmit(cate);
                db.SubmitChanges();
            }
                return true;
        }
        public bool deleteCate(int id)
        {
            try { 
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                
                FoodCategory cate = db.FoodCategories.SingleOrDefault(x => x.idcategory == id);
                db.FoodCategories.DeleteOnSubmit(cate);
                db.SubmitChanges();
                    return true;
                }
            } catch(Exception)
            {
                return false;
            }
            
        }
        public bool updateCate(int idCate, string nameCate, int other )
        {
            List<CategoryItem> listCate = loadCate();
            try
            {
                using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
                {
                    foreach(CategoryItem item in listCate)
                    {
                        if (item.NameCate.Equals(nameCate))
                            return false;
                    }
                    FoodCategory cate = db.FoodCategories.SingleOrDefault(x => x.idcategory == idCate);
                    cate.namecategory = nameCate;
                    cate.orther = other;
                    db.SubmitChanges();
                    return true;
                }
                } catch(Exception)
            {
                return false;
            }
        }
    }
}

