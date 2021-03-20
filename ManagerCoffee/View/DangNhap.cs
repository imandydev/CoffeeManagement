using ManagerCoffee.DAO;
using ManagerCoffee.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManagerCoffee
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public static string getUserName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = tbusername.Text;
            string pass = tbpass.Text;
            bool checkLogin = LoginDAO.Instance.checkLogin(username, pass);
            bool checkType = LoginDAO.Instance.checkTypeAccount(username, pass);
            if (checkLogin)
            {
                getUserName = username;
                TrangChu main = new TrangChu(checkType);
                this.Hide();
                main.ShowDialog();
                this.Close();
            } else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
        }
    }
}
