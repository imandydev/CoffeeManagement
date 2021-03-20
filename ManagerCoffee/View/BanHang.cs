using DevExpress.XtraEditors;
using ManagerCoffee.Control;
using ManagerCoffee.DAO;
using ManagerCoffee.DTO;
using ManagerCoffee.Support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCoffee.View
{
    public partial class BanHang : DevExpress.XtraEditors.XtraForm
    {
        private static int countSize = 0;
        private static int countPrice = 0;
        private static long pricetemp = 0;
        private static int addChange = 0;
        public BanHang()
        {
            InitializeComponent();
            load();
        }
        // load tất cả
        public void load()
        {
            loadCategory();
            loadBill();
        }
        // trở về
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // load lên danh mục
        public void loadCategory()
        {
            List<CategoryItem> listCate = CategoryDAO.Instance.loadCate();
            tbdanhmuc.Items.Add("Tất Cả");
            tbdanhmuc.SelectedItem = "Tất Cả";
            foreach (CategoryItem item in listCate)
                tbdanhmuc.Items.Add(item.NameCate);
        }
        // set lại phần bill
        public void loadBill()
        {

            dgvbill.Columns["idDetail"].Visible = false;
            dgvbill.Columns[6].Visible = false;
            dgvbill.Columns[0].Width = 50;
            dgvbill.Columns[1].Width = 145;
            dgvbill.Columns[2].Width = 65;
            dgvbill.Columns[3].Width = 100;
            dgvbill.Columns[4].Width = 125;
            for (int i = 0; i < dgvbill.Columns.Count; i++)
            {
                dgvbill.Columns[i].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
                dgvbill.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvbill.EnableHeadersVisualStyles = false;
                dgvbill.Columns[i].HeaderCell.Style.BackColor = Color.Beige;
            }
        }
        // load lên danh sách sản phẩm theo tên sp và tên danh mục
        public void loadProduct()
        {
            string namePro = tbtimkiem.Text;
            string nameCate = tbdanhmuc.GetItemText(tbdanhmuc.SelectedItem);
            List<Product> listPro = ProductDAO.Instance.loadProductByNameCateAndNamePro(namePro, nameCate);

            foreach (Product item in listPro)
            {
                Button btn = new Button() { Width = ProductDAO.width, Height = ProductDAO.height};
                btn.Text = item.Name;
                btn.BackColor = Color.PaleVioletRed;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Tahoma", 12, FontStyle.Bold);
                btn.Tag = item.IdPro;
                flplistpro.Controls.Add(btn);
                btn.Click += (sender, e) => OnClickFlayout(this, e, btn.Tag.ToString());
            }
        }
        // tải lại danh sách sản phẩm thi danh mục thay đổi
        private void cb_Danh_Muc_Change(object sender, EventArgs e)
        {
            flplistpro.Controls.Clear();
            loadProduct();
        }
        // khi click btn tìm kiếm
        private void btnfind_Click(object sender, EventArgs e)
        {
            flplistpro.Controls.Clear();
            loadProduct();
        }
        // khi click chuột chọn vào các đồ uống
        public void OnClickFlayout (object sender, EventArgs e, String tag)
        {
            List<Product> listPro = ProductDAO.Instance.loadProductByID(Int16.Parse(tag));
            List<string> listSize = new List<string>();
            tbnamepro.Text = listPro[0].Name.ToString();
            countSize = 0;
            foreach(Product item in listPro)
            {
                listSize.Add(item.Size);
            }
            cbsize.DataSource = listSize;
            amount.Value = 1;
            string getSize = cbsize.SelectedItem.ToString();
            foreach(Product item in listPro)
            {
                if (getSize.Equals(item.Size)) { 
                    tbprice.Text = (item.Price * amount.Value).ToString();
                    pricetemp = (long)(item.Price);
                    btnaddpro.Tag = item.IdDetail.ToString();
                    break;
                }
            }
            tbnamepro.Tag = tag;
         
        }
        // khi kích thước thay đổi
        private void sizeChange(object sender, EventArgs e)
        {
            // xảy ra lỗi khi lần đầu click vào button hạn chế lỗi bằng sử dụng biến tĩnh
            countSize++;
            if (countSize > 1) {
                string size = cbsize.GetItemText(cbsize.SelectedItem);
                int id = Int16.Parse(tbnamepro.Tag.ToString());
                List<Product> listPro = ProductDAO.Instance.loadProductByIDAndSize(id, size);
                tbprice.Text = (listPro[0].Price * amount.Value).ToString();
                btnaddpro.Tag = listPro[0].IdDetail.ToString();
                pricetemp = (long)(listPro[0].Price);
            }
        }
        // khi giá thay đổi
        private void priceChange(object sender, EventArgs e)
        {
            countPrice++;
            if (countPrice > 1) { 
            int getAmount = (int)amount.Value;
            tbprice.Text = (pricetemp * getAmount).ToString();
            }
        }

        private void btnaddpro_Click(object sender, EventArgs e)
        {
            dgvbill.Rows.Add(dgvbill.Rows.Count, tbnamepro.Text, cbsize.GetItemText(cbsize.SelectedItem), amount.Value, tbprice.Text, btnaddpro.Tag, tbnamepro.Tag);
           

        }
        // khi thay đổi giảm giá
         private void changeGiamGia(object sender, EventArgs e)
        {
            changePrice();


        }
        // khi thêm dòng
        private void PriceChangeRowAdd(object sender, DataGridViewRowsAddedEventArgs e)
        {
            changePrice();
        }
        // khi xóa dòng
        private void PriceChangeRowRemove(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            changePrice();
        }
        // hỗ trợ thay đổi giá khi xóa hoặc thêm dòng
        public void changePrice()
        {
            try { 
            long giamgia = 0;
            string getGiamGia = tbgiamgia.Text;
            if (!getGiamGia.Equals(""))
                giamgia = long.Parse(getGiamGia);

            long total = 0;
            for (int i = 0; i < dgvbill.Rows.Count - 1; i++)
            {
                total += long.Parse(dgvbill.Rows[i].Cells[4].FormattedValue.ToString());
            }
            tbtong.Text = (total - giamgia).ToString();
            } catch (Exception)
            {
            }
        }

        // button xóa
        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                int rowIndex = dgvbill.CurrentCell.RowIndex;
                dgvbill.Rows.RemoveAt(rowIndex);
            } catch(Exception)
            {
                MessageBox.Show("Vui Lòng Chọn Sản Phẩm!");
            }
        }
        // thanh toán tạo bill
        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if(dgvbill.Rows.Count > 1) { 
            string userName = Form1.getUserName;
            List<Staff> listStaff = StaffDAO.Instance.getStaffByUserName(userName);
             // lấy ra id nhân viên nhập đơn
            int idStaff = listStaff[0].Id;
            // lấy ra giảm giá
            string getDiscount = tbgiamgia.Text;
            long discount = 0;
            if (!getDiscount.Equals(""))
                discount = long.Parse(getDiscount);
                // lấy ra ngày hiện tại

            var currentTime = DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss:fff");
            var parseCurrentTime = DateTime.ParseExact(currentTime, "yyyy-MM-dd HH:mm:ss:fff", CultureInfo.InvariantCulture);
             // lấy ra tổng tiền
            long total = long.Parse(tbtong.Text);
            
                Bill bill = new Bill
                {
                    idbill = 1,
                    idAccount = idStaff,
                    total = total,
                    founding = parseCurrentTime,
                    discount = discount,
                };
                bool checkAddBill = BillDAO.Instance.insertBill(bill);
                if(checkAddBill) {
                    for(int i = 0; i < dgvbill.Rows.Count -1; i++)
                    {
                        BillInfo infor = new BillInfo
                        {
                            idbillInfor = 1,
                            idbill = bill.idbill,
                            iddetail = Int16.Parse(dgvbill.Rows[i].Cells[5].FormattedValue.ToString()),
                            amount = Int16.Parse(dgvbill.Rows[i].Cells[3].FormattedValue.ToString()),
                            price = long.Parse(dgvbill.Rows[i].Cells[4].FormattedValue.ToString()),
                        };
                        BillInforDAO.Instance.insert(infor);
                    }
                   
                
                        dgvbill.Rows.Clear();
                        MessageBox.Show("Thêm Đơn Hàng Thành Công!");
               

                }
                else
                    MessageBox.Show("Thêm Đơn Hàng Thất Bại!");
            } else
            {
                MessageBox.Show("Chưa có sản phẩm để tạo đơn hàng!");
            }
        }
    }
}