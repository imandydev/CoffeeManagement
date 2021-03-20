using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffee.Support
{
    public class Staff
    {
        private int id;
        private string type;
        private string name;
        private string username;
        private string dob;
        private string startDate;
        private string endDate;
        private string address;
        private long numberP;
      

        public Staff(int id, string type, string name, string username, string dob, string startDate, string endDate, string address, long numberP)
        {
            this.Id = id;
            this.Type = type;
            this.Name = name;
            this.Username = username;
            this.Dob = dob;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Address = address;
            this.NumberP = numberP;
          
        }


        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Dob { get => dob; set => dob = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public string Address { get => address; set => address = value; }
        public long NumberP { get => numberP; set => numberP = value; }
       
    }
}
