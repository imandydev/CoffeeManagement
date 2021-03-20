using ManagerCoffee.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffee.Control
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            set => instance = value; }
        public bool insertBill(Bill bill)
        {
            try { 
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                db.Bills.InsertOnSubmit(bill);
                db.SubmitChanges();
            }
                return true;
            } catch(Exception)
            {
                return false;
            }
            
        }
        public List<BillDTO> loadBill(DateTime start, DateTime end)
        {
            List<BillDTO> listBill = new List<BillDTO>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from bill in db.Bills join acc in db.Accounts on bill.idAccount equals acc.idAccount where (bill.founding >= start && bill.founding <= end) select new { id = (int)bill.idbill, idacc = (int)acc.idAccount, username = acc.username, total = (long)bill.total, founding = bill.founding.ToString(), discount = (long)bill.discount };
             
                foreach(var item in data)
                {
                        
                    BillDTO bill = new BillDTO(item.id, item.idacc, item.username, item.total, item.founding, item.discount);
                    listBill.Add(bill);                
                }
               
            }
            return listBill;
            }
        public long tongDoanhThu(List<BillDTO> listBill)
        {
            long sum = 0;
            foreach(BillDTO item in listBill)
            {
                sum += item.Total;
            }
            return sum;
        }
    }
    
}
