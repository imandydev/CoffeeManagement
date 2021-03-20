using ManagerCoffee.DAO;
using ManagerCoffee.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffee.Control
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        public static int width = 120;
        public static int height = 120;
        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return instance; }
            set
            {
                instance = value;
            }
        }


        public ProductDAO()
        {

        }
        // load lên tất cả sản phẩm
        public List<Product> loadProduct()
        {
            List<Product> listPro = new List<Product>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from food in db.Foods join cate in db.FoodCategories on food.idcategory equals cate.idcategory join detail in db.detailFoods on food.idfood equals detail.idfood select new  { IdDetail = detail.iddetail, IdPro = food.idfood, Name = food.foodname, Namecate = cate.namecategory, Size = detail.size, Price = (long)detail.price, Other = food.orther, Status = detail.status };
                foreach (var item in data)
                {
                    Product pro = new Product(item.IdDetail ,item.IdPro, item.Name, item.Namecate, item.Size, item.Price, item.Other, item.Status);
                    listPro.Add(pro);
                }
                listPro.Sort();
            }
            return listPro;
        }
        
        // tìm kiếm sản phẩm theo tên sản phẩm và tên danh mục
        public List<Product> loadProductByNameCateAndNamePro(string namePro, string nameCate)
        {
            List<Product> listPro = new List<Product>();
            List<string> listSaveName = new List<string>();
            
            if (nameCate.Equals("Tất Cả"))
            {
                using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
                {
                    var data = from food in db.Foods join detail in db.detailFoods on food.idfood equals detail.idfood where food.foodname.Contains(namePro) && detail.status == "Hiển Thị" select new { food.idfood, food.foodname, detail.status, food.idcategory };
                    foreach (var item in data)
                    {
                        Product pro = new Product(item.idfood, item.foodname, item.status);
                      
                        if(!listSaveName.Contains(pro.Name + "/" + item.idcategory)) {
                            listSaveName.Add(pro.Name + "/" + item.idcategory);
                            listPro.Add(pro);
                        }

                    }
                    listPro.Sort();
                }
                return listPro;
            }
            else
            {
                using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
                {
                    var data = from food in db.Foods join cate in db.FoodCategories on food.idcategory equals cate.idcategory join detail in db.detailFoods on food.idfood equals detail.idfood where cate.namecategory == nameCate && food.foodname.Contains(namePro) && detail.status == "Hiển Thị" select new { food.idfood, food.foodname, detail.status };
                    foreach (var item in data)
                    {
                        Product pro = new Product(item.idfood, item.foodname, item.status);
                        if (!listSaveName.Contains(pro.Name))
                        {
                            listSaveName.Add(pro.Name);
                            listPro.Add(pro);
                        }
                    }
                    listPro.Sort();
                }

            }
            return listPro;
        }
        // load lên tất cả sản phẩm theo id
        public List<Product> loadProductByID(int id)
        {
            List<Product> listPro = new List<Product>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from food in db.Foods join cate in db.FoodCategories on food.idcategory equals cate.idcategory join detail in db.detailFoods on food.idfood equals detail.idfood where food.idfood == id && detail.status == "Hiển Thị" select new { IdDetail = detail.iddetail, IdPro = food.idfood, Name = food.foodname, Namecate = cate.namecategory, Size = detail.size, Price = (long)detail.price, Other = food.orther, Status = detail.status };
                foreach (var item in data)
                {
                    Product pro = new Product(item.IdDetail, item.IdPro, item.Name, item.Namecate, item.Size, item.Price, item.Other, item.Status);
                    listPro.Add(pro);
                }
            }
            return listPro;
        }
        // tìm kiếm theo id
        public List<Product> searchProductByID(int id)
        {
            List<Product> listPro = new List<Product>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from food in db.Foods join cate in db.FoodCategories on food.idcategory equals cate.idcategory join detail in db.detailFoods on food.idfood equals detail.idfood where detail.iddetail == id  select new { IdDetail = detail.iddetail, IdPro = food.idfood, Name = food.foodname, Namecate = cate.namecategory, Size = detail.size, Price = (long)detail.price, Other = food.orther, Status = detail.status };
                foreach (var item in data)
                {
                    Product pro = new Product(item.IdDetail, item.IdPro, item.Name, item.Namecate, item.Size, item.Price, item.Other, item.Status);
                    listPro.Add(pro);
                }
            }
            return listPro;
        }
        // tìm kiếm theo tên danh mục
        public List<Product> searchProductByNameCate(string name)
        {
            List<Product> listPro = new List<Product>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from food in db.Foods join cate in db.FoodCategories on food.idcategory equals cate.idcategory join detail in db.detailFoods on food.idfood equals detail.idfood where cate.namecategory.Contains(name) select new { IdDetail = detail.iddetail, IdPro = food.idfood, Name = food.foodname, Namecate = cate.namecategory, Size = detail.size, Price = (long)detail.price, Other = food.orther, Status = detail.status };
                foreach (var item in data)
                {
                    Product pro = new Product(item.IdDetail, item.IdPro, item.Name, item.Namecate, item.Size, item.Price, item.Other, item.Status);
                    listPro.Add(pro);
                }
            }
            return listPro;
        }
        public List<Product> searchProductBySize(string size)
        {
            List<Product> listPro = new List<Product>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from food in db.Foods join cate in db.FoodCategories on food.idcategory equals cate.idcategory join detail in db.detailFoods on food.idfood equals detail.idfood where detail.size == size select new { IdDetail = detail.iddetail, IdPro = food.idfood, Name = food.foodname, Namecate = cate.namecategory, Size = detail.size, Price = (long)detail.price, Other = food.orther, Status = detail.status };
                foreach (var item in data)
                {
                    Product pro = new Product(item.IdDetail, item.IdPro, item.Name, item.Namecate, item.Size, item.Price, item.Other, item.Status);
                    listPro.Add(pro);
                }
            }
            return listPro;
        }
        // tìm kiếm theo tên sp
        public List<Product> searchProductByName(string name)
        {
            List<Product> listPro = new List<Product>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from food in db.Foods join cate in db.FoodCategories on food.idcategory equals cate.idcategory join detail in db.detailFoods on food.idfood equals detail.idfood where food.foodname.Contains(name) select new { IdDetail = detail.iddetail, IdPro = food.idfood, Name = food.foodname, Namecate = cate.namecategory, Size = detail.size, Price = (long)detail.price, Other = food.orther, Status = detail.status };
                foreach (var item in data)
                {
                    Product pro = new Product(item.IdDetail, item.IdPro, item.Name, item.Namecate, item.Size, item.Price, item.Other, item.Status);
                    listPro.Add(pro);
                }
            }
            return listPro;
        }
        // tìm kiếm theo giá
        public List<Product> searchProductByPrice(long price)
        {
            List<Product> listPro = new List<Product>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from food in db.Foods join cate in db.FoodCategories on food.idcategory equals cate.idcategory join detail in db.detailFoods on food.idfood equals detail.idfood where detail.price == price select new { IdDetail = detail.iddetail, IdPro = food.idfood, Name = food.foodname, Namecate = cate.namecategory, Size = detail.size, Price = (long)detail.price, Other = food.orther, Status = detail.status };
                foreach (var item in data)
                {
                    Product pro = new Product(item.IdDetail, item.IdPro, item.Name, item.Namecate, item.Size, item.Price, item.Other, item.Status);
                    listPro.Add(pro);
                }
            }
            return listPro;
        }
        // tìm kiếm theo trạng thái
        public List<Product> searchProductByStatus(string status)
        {
            List<Product> listPro = new List<Product>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from food in db.Foods join cate in db.FoodCategories on food.idcategory equals cate.idcategory join detail in db.detailFoods on food.idfood equals detail.idfood where detail.status == status select new { IdDetail = detail.iddetail, IdPro = food.idfood, Name = food.foodname, Namecate = cate.namecategory, Size = detail.size, Price = (long)detail.price, Other = food.orther, Status = detail.status };
                foreach (var item in data)
                {
                    Product pro = new Product(item.IdDetail, item.IdPro, item.Name, item.Namecate, item.Size, item.Price, item.Other, item.Status);
                    listPro.Add(pro);
                }
            }
            return listPro;
        }
        public List<Product> loadProductByIDDetail(int id)
        {
            List<Product> listPro = new List<Product>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from food in db.Foods join cate in db.FoodCategories on food.idcategory equals cate.idcategory join detail in db.detailFoods on food.idfood equals detail.idfood where detail.iddetail == id  select new { IdDetail = detail.iddetail, IdPro = food.idfood, Name = food.foodname, Namecate = cate.namecategory, Size = detail.size, Price = (long)detail.price, Other = food.orther, Status = detail.status };
                foreach (var item in data)
                {
                    Product pro = new Product(item.IdDetail, item.IdPro, item.Name, item.Namecate, item.Size, item.Price, item.Other, item.Status);
                    listPro.Add(pro);
                }
            }
            return listPro;
        }

        // load lên tất cả sản phẩm
        public List<Product> loadProductByIDAndSize(int id, string size)
        {
            List<Product> listPro = new List<Product>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from food in db.Foods join cate in db.FoodCategories on food.idcategory equals cate.idcategory join detail in db.detailFoods on food.idfood equals detail.idfood where food.idfood == id && detail.size == size select new { IdDetail = detail.iddetail, IdPro = food.idfood, Name = food.foodname, Namecate = cate.namecategory, Size = detail.size, Price = (long)detail.price, Other = food.orther, Status = detail.status };
                foreach (var item in data)
                {
                    Product pro = new Product(item.IdDetail, item.IdPro, item.Name, item.Namecate, item.Size, item.Price, item.Other, item.Status);
                    listPro.Add(pro);
                }
            }
            return listPro;
        }
        // insert sản phẩm
        public bool insertProduct(Food pro, string nameCate)
        {
            List<Product> listPro = loadProduct();
          
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                foreach(Product item in listPro)
                {
                 
                    if (item.Name.Equals(pro.foodname) && item.Namecate.Equals(nameCate))
                        return false;
                }
                db.Foods.InsertOnSubmit(pro);
                db.SubmitChanges();
            }
             return true;
        }
        public List<string> listStatus()
        {
            List<string> listStatus = new List<string>();
            foreach (Product item in loadProduct())
                listStatus.Add(item.Status);
            return listStatus;
        }
        public List<int> loadIDProduct(string name, int idcate)
        {
            List<int> listPro = new List<int>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from food in db.Foods join cate in db.FoodCategories on food.idcategory equals cate.idcategory join detail in db.detailFoods on food.idfood equals detail.idfood where food.foodname == name && cate.idcategory == idcate select new { IdDetail = detail.iddetail, IdPro = food.idfood, Name = food.foodname, Namecate = cate.namecategory, Size = detail.size, Price = (long)detail.price, Other = food.orther, Status = detail.status };
                foreach (var item in data)
                {
                    Product pro = new Product(item.IdDetail, item.IdPro, item.Name, item.Namecate, item.Size, item.Price, item.Other, item.Status);
                    listPro.Add(pro.IdPro);
                }
                
            }
            return listPro;
        }
       public bool updatePro(int idDetail, string namePro, string cate)
        {
            List<Product> listPro = loadProduct();
            try
            {
                using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
                {
                    foreach (Product item in listPro)
                    {

                        if (item.Name.Equals(namePro) && item.Namecate.Equals(cate))
                            return false;
                    }
                    int idcate = CategoryDAO.Instance.getIdCateByNameCate(cate);
                    int getIdByName = loadProductByIDDetail(idDetail)[0].IdPro;
                    
                    Food pro = db.Foods.SingleOrDefault(x => x.idfood == getIdByName);
                    pro.idcategory = idcate;
                    pro.foodname = namePro;
                    db.SubmitChanges();
                }
                    return true;
            }catch (Exception)
            {
                return false;
            }
        }
    }
}
