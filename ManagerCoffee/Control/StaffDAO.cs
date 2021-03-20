using ManagerCoffee.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffee.Control
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return instance; }
            set
            {
                instance = value;
            }
        }
        public List<Staff> loadStaff()
        {
            List<Staff> listStaff = new List<Staff>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data =  from acc in db.Accounts join type in db.AccountTypes on acc.idAccountType equals type.idAccountType select new { id = acc.idAccount, type = type.nameType, name = acc.full_name, username = acc.username, dob = acc.dateofbird.ToString(), startdate = acc.startdate.ToString(), enddate = acc.enddate.ToString(), address = acc.address, phone = (long)acc.numberphone };

                foreach (var item in data)
                {
                    Staff staff = new Staff(item.id, item.type, item.name, item.username, item.dob, item.startdate, item.enddate, item.address, item.phone);
                    listStaff.Add(staff);
                }
                
            }
            return listStaff;
        }
        // tìm kiếm theo loại tài khoản
        public List<Staff> searchStaffType(string typeThat)
        {
            List<Staff> listStaff = new List<Staff>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from acc in db.Accounts join type in db.AccountTypes on acc.idAccountType equals type.idAccountType where type.nameType == typeThat select new { id = acc.idAccount, type = type.nameType, name = acc.full_name, username = acc.username, dob = acc.dateofbird.ToString(), startdate = acc.startdate.ToString(), enddate = acc.enddate.ToString(), address = acc.address, phone = (long)acc.numberphone };

                foreach (var item in data)
                {
                    Staff staff = new Staff(item.id, item.type, item.name, item.username, item.dob, item.startdate, item.enddate, item.address, item.phone);
                    listStaff.Add(staff);
                }

            }
            return listStaff;
        }
        // tìm kiếm theo full name
        public List<Staff> searchStaffFullName(string name)
        {
            List<Staff> listStaff = new List<Staff>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from acc in db.Accounts join type in db.AccountTypes on acc.idAccountType equals type.idAccountType where acc.full_name.Contains(name) select new { id = acc.idAccount, type = type.nameType, name = acc.full_name, username = acc.username, dob = acc.dateofbird.ToString(), startdate = acc.startdate.ToString(), enddate = acc.enddate.ToString(), address = acc.address, phone = (long)acc.numberphone };

                foreach (var item in data)
                {
                    Staff staff = new Staff(item.id, item.type, item.name, item.username, item.dob, item.startdate, item.enddate, item.address, item.phone);
                    listStaff.Add(staff);
                }

            }
            return listStaff;
        }

       // tìm thì tên gần đúng
        public List<Staff> searchStaffByUserName(string username)
        {
            List<Staff> listStaff = new List<Staff>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from acc in db.Accounts join type in db.AccountTypes on acc.idAccountType equals type.idAccountType where acc.username.Contains(username) select new { id = acc.idAccount, type = type.nameType, name = acc.full_name, username = acc.username, dob = acc.dateofbird.ToString(), startdate = acc.startdate.ToString(), enddate = acc.enddate.ToString(), address = acc.address, phone = (long)acc.numberphone };

                foreach (var item in data)
                {
                    Staff staff = new Staff(item.id, item.type, item.name, item.username, item.dob, item.startdate, item.enddate, item.address, item.phone);
                    listStaff.Add(staff);
                }
            }
            return listStaff;
        }
        public List<Staff> searchStaffById(int id)
        {
            List<Staff> listStaff = new List<Staff>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from acc in db.Accounts join type in db.AccountTypes on acc.idAccountType equals type.idAccountType where acc.idAccount == id select new { id = acc.idAccount, type = type.nameType, name = acc.full_name, username = acc.username, dob = acc.dateofbird.ToString(), startdate = acc.startdate.ToString(), enddate = acc.enddate.ToString(), address = acc.address, phone = (long)acc.numberphone };

                foreach (var item in data)
                {
                    Staff staff = new Staff(item.id, item.type, item.name, item.username, item.dob, item.startdate, item.enddate, item.address, item.phone);
                    listStaff.Add(staff);
                }
            }
            return listStaff;
        }
        // tìm theo địa chỉ
        public List<Staff> searchStaffByAddress(string address)
        {
            List<Staff> listStaff = new List<Staff>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from acc in db.Accounts join type in db.AccountTypes on acc.idAccountType equals type.idAccountType where acc.address.Contains(address) select new { id = acc.idAccount, type = type.nameType, name = acc.full_name, username = acc.username, dob = acc.dateofbird.ToString(), startdate = acc.startdate.ToString(), enddate = acc.enddate.ToString(), address = acc.address, phone = (long)acc.numberphone };

                foreach (var item in data)
                {
                    Staff staff = new Staff(item.id, item.type, item.name, item.username, item.dob, item.startdate, item.enddate, item.address, item.phone);
                    listStaff.Add(staff);
                }
            }
            return listStaff;
        }
        // tìm theo số điện thoại
        public List<Staff> searchStaffBySDT(long numP)
        {
            List<Staff> listStaff = new List<Staff>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from acc in db.Accounts join type in db.AccountTypes on acc.idAccountType equals type.idAccountType where acc.numberphone == numP select new { id = acc.idAccount, type = type.nameType, name = acc.full_name, username = acc.username, dob = acc.dateofbird.ToString(), startdate = acc.startdate.ToString(), enddate = acc.enddate.ToString(), address = acc.address, phone = (long)acc.numberphone };

                foreach (var item in data)
                {
                    Staff staff = new Staff(item.id, item.type, item.name, item.username, item.dob, item.startdate, item.enddate, item.address, item.phone);
                    listStaff.Add(staff);
                }
            }
            return listStaff;
        }
        // get staff by username
        public List<Staff> getStaffByUserName(string username)
        {
            List<Staff> listStaff = new List<Staff>();
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from acc in db.Accounts join type in db.AccountTypes on acc.idAccountType equals type.idAccountType where acc.username == username select new { id = acc.idAccount, type = type.nameType, name = acc.full_name, username = acc.username, dob = acc.dateofbird.ToString(), startdate = acc.startdate.ToString(), enddate = acc.enddate.ToString(), address = acc.address, phone = (long)acc.numberphone };

                foreach (var item in data)
                {
                    Staff staff = new Staff(item.id, item.type, item.name, item.username, item.dob, item.startdate, item.enddate, item.address, item.phone);
                    listStaff.Add(staff);
                }
            }
            return listStaff;
        }

        // get staff by id
        public Staff getStaffByID(int id)
        {
            using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
            {
                var data = from acc in db.Accounts join type in db.AccountTypes on acc.idAccountType equals type.idAccountType where acc.idAccount == id select new { id = acc.idAccount, type = type.nameType, name = acc.full_name, username = acc.username, dob = acc.dateofbird.ToString(), startdate = acc.startdate.ToString(), enddate = acc.enddate.ToString(), address = acc.address, phone = (long)acc.numberphone };

                foreach (var item in data)
                {
                   
                        return new Staff(item.id, item.type, item.name, item.username, item.dob, item.startdate, item.enddate, item.address, item.phone);
                    
                }
            }
            return null;
        }

        public bool insertStaff(Account staff)
        {
            try
            {
                using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
                {
                    foreach(Staff item in loadStaff())
                    {
                        if (item.Username.Equals(staff.username))
                            return false;
                    }

                    db.Accounts.InsertOnSubmit(staff);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public bool deleteStaff(int id)
        {
            try
            {
                using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
                {
                    Account acc = db.Accounts.SingleOrDefault(x => x.idAccount == id);
                    db.Accounts.DeleteOnSubmit(acc);
                    db.SubmitChanges();
                    return true;
                }

            }catch(Exception)
            {
                return false;
            }
        }
        public bool updateStaff(int id, int idAcc, string fullname, string username, string pass, DateTime dob, DateTime startDate, DateTime endDate, string address, long numberPhone )
        {
            Staff staff = getStaffByID(id);
            try
            {
                using (DataBaseCoffeeDataContext db = new DataBaseCoffeeDataContext())
                {
                    if(staff.Username.Equals(username)) { 
                    Account account = db.Accounts.SingleOrDefault(x => x.idAccount == id);
                    account.idAccountType = idAcc;
                    account.full_name = fullname;
                    account.password = pass;
                    account.dateofbird = dob;
                    account.startdate = startDate;
                    account.enddate = endDate;
                    account.address = address;
                    account.numberphone = numberPhone;
                    db.SubmitChanges();
                    return true;
                    } else
                    {
                        foreach(Staff item in loadStaff())
                        {
                            if(item.Username.Equals(username))
                            {
                                return false;
                            }
                            Account account = db.Accounts.SingleOrDefault(x => x.idAccount == id);
                            account.idAccountType = idAcc;
                            account.username = username;
                            account.full_name = fullname;
                            account.password = pass;
                            account.dateofbird = dob;
                            account.startdate = startDate;
                            account.enddate = endDate;
                            account.address = address;
                            account.numberphone = numberPhone;
                            db.SubmitChanges();
              
                        }
                        return true;
                    }
                }
                    
            } catch (Exception)
            {
                return false;
            }
        }
       
    }
}
