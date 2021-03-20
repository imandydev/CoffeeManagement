using ManagerCoffee.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffee.Control
{
    public class DetailProductDAO
    {
        private static DetailProductDAO instance;

        public static DetailProductDAO Instance {
            get { if (instance == null) instance = new DetailProductDAO(); return instance; }
            set => instance = value; }
        public bool insertDetailPro(detailFood detail)
        {
            try { 
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                db.detailFoods.InsertOnSubmit(detail);
                db.SubmitChanges();
            }
            return true;
            } catch(Exception) { 
            return false;
            }
        }
        public bool deleteDetailPro(int id)
        {
            try { 
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                detailFood detail = db.detailFoods.SingleOrDefault(x => x.iddetail == id);
                db.detailFoods.DeleteOnSubmit(detail);
                db.SubmitChanges();
                     return true;
                }
            } catch (Exception)
            {
                return false;
            }
           
        }
        public bool updateDetailPro(int idDetail, string namePro, string cate, string size, long price, string status)
        {
            try
            {
                using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
                {
                    int idcate = CategoryDAO.Instance.getIdCateByNameCate(cate);
                    int idPro = ProductDAO.Instance.loadIDProduct(namePro, idcate)[0];
                    detailFood detailF = db.detailFoods.SingleOrDefault(x => x.iddetail == idDetail);
                    detailF.idfood = idPro;
                    detailF.size = size;
                    detailF.price = price;
                    detailF.status = status;
                    db.SubmitChanges();
                }

               return true;
            }catch(Exception)
            {
                return false;
            }
        }
    }
}
