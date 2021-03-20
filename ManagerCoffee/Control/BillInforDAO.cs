using ManagerCoffee.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffee.Control
{
    public class BillInforDAO
    {
        private static BillInforDAO instance;

        public static BillInforDAO Instance {
            get { if (instance == null) instance = new BillInforDAO(); return instance; }
            set => instance = value; }
         public List<BillInforDTO> loadListBillInforByIdBill(int id)
        {
            List<BillInforDTO> list = new List<BillInforDTO>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from infor in db.BillInfos join detail in db.detailFoods on infor.iddetail equals detail.iddetail where infor.idbill == id select new { idbillIn = infor.idbillInfor, idBill = infor.idbill, idPro = detail.idfood, amount = infor.amount ,price = (long)infor.price };
                foreach(var item in data)
                {
                    BillInforDTO infor = new BillInforDTO(item.idbillIn, item.idBill, item.idPro, item.amount, (long)item.price);
                    list.Add(infor);
                }
            }
            return list;
            }
        public bool insert(BillInfo infor)
        {
            try { 
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                    db.BillInfos.InsertOnSubmit(infor);
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
