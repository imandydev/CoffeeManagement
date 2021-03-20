using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffee.Support
{
    public class Time
    {
        public static String[] splitDate(String str)
        {
            String[] arr = str.Split('-');
            return arr;
        }
    }
}
