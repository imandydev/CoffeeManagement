using DevExpress.XtraEditors;
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
    public partial class TrangChu : DevExpress.XtraEditors.XtraForm
    {
   
        public TrangChu()
        {
            InitializeComponent();
       
        }
        public TrangChu(bool setVal)
        {
            InitializeComponent();
            setQuanLy(setVal);
        }
        public void setQuanLy(bool setValue)
        {
            btnquanly.Enabled = setValue;
            if (!setValue)
                btnquanly.BackColor = Color.Gray;
        }

        private void btnbanhang_Click(object sender, EventArgs e)
        {
            BanHang main = new BanHang();
            this.Hide();
            main.ShowDialog();
            this.Show();
        }

        private void btnquanly_Click(object sender, EventArgs e)
        {
            QuanLy main = new QuanLy();
            this.Hide();
            main.ShowDialog();
            this.Show();
        }

        private void btndonhang_Click(object sender, EventArgs e)
        {
            DonHang main = new DonHang();
            this.Hide();
            main.ShowDialog();
            this.Show();
        }

        private void btnhuongdan_Click(object sender, EventArgs e)
        {

        }

        private void btnthongtin_Click(object sender, EventArgs e)
        {
            thongtin main = new thongtin();
            this.Hide();
            main.ShowDialog();
            this.Show();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}