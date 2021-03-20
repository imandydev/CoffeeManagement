using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffee.Control
{
   public class TypeAccountDAO
    {
        private static TypeAccountDAO instance;

        public static TypeAccountDAO Instance
        {
            get { if (instance == null) instance = new TypeAccountDAO(); return instance; }
            set { instance = value; }
        }
        public TypeAccountDAO()
        {

        }
        public List<String> listTypeAccount()
        {
            List<String> listType = new List<String>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from type in db.AccountTypes
                           select type;
                foreach (AccountType item in data)
                {
                    listType.Add(item.nameType);
                }
            }
            return listType;
        }
        public int IDAccount(string type)
        {
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from typeAcc in db.AccountTypes
                           select typeAcc;
                foreach (AccountType item in data)
                {
                    if (item.nameType.Equals(type))
                        return item.idAccountType;
                }
            }
            return -1;
        }
    }
}
