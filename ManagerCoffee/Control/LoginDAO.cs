using ManagerCoffee.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffee.DAO
{
   public class LoginDAO
    {
        private static LoginDAO instance;
        internal static LoginDAO Instance
        {
            get { if (instance == null) instance = new LoginDAO(); return instance; }
            set { instance = value; }
        }
        private LoginDAO()
        {

        }
        public bool checkLogin(string username, string pass)
        {
            int count = 0;
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var result = from a in db.Accounts where a.username == username && a.password == pass select a;
                count = result.Count();
            }
            return count > 0;
        }
        public bool checkTypeAccount(string username, string pass)
        {
            int count = 0;
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var result = from a in db.Accounts join type in db.AccountTypes on a.idAccountType equals type.idAccountType where type.nameType == "admin" && a.username == username && a.password == pass select a;
                count = result.Count();
            }
            // > 1 là admin : < 1 là user
            return count != 0;
        }
      
    }
}
