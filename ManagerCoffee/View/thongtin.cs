using DevExpress.XtraEditors;
using ManagerCoffee.Control;
using ManagerCoffee.Support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCoffee.View
{
    public partial class thongtin : DevExpress.XtraEditors.XtraForm
    {
        string username = Form1.getUserName;
        public thongtin()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            loadProfile();
        }
        public void loadProfile()
        {
            Staff staff = StaffDAO.Instance.getStaffByUserName(username)[0];
            tbid.Text = staff.Id.ToString();
            tbname.Text = staff.Name;
            tbtype.Text = staff.Type;
            tbusername.Text = staff.Username;
            string[] dob = Time.splitDate(staff.Dob.ToString());
            dtpdob.Value = new DateTime(Int16.Parse(dob[0]), Int16.Parse(dob[1]), Int16.Parse(dob[2]));
            string[] dateStart = Time.splitDate(staff.StartDate.ToString());
            dtpstart.Value = new DateTime(Int16.Parse(dateStart[0]), Int16.Parse(dateStart[1]), Int16.Parse(dateStart[2]));
            tbadress.Text = staff.Address;
            ncphone.Value = staff.NumberP;
        }
    }
}