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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCoffee.View
{
    public partial class QuanLy : DevExpress.XtraEditors.XtraForm
    {
        public QuanLy()
        {
            InitializeComponent();
            load();
        }
        // load tất cả
        public void load()
        {
            loadProduct();
            loadCategory();
            loadStaff();
            loadBillDashBoard();
            loadCTDH();
            loadAddCBB();
            
        }
        public void loadAddCBB()
        {
            cbtrangthai.Items.Add("Hiển Thị");
            cbtrangthai.SelectedItem = "Hiển Thị";
            cbtrangthai.Items.Add("Ẩn");
            // cb sản phẩm
            cbChooseItemSearchPro.Items.Add("Mã Sản Phẩm");
            cbChooseItemSearchPro.SelectedItem = "Mã Sản Phẩm";
            cbChooseItemSearchPro.Items.Add("Tên Sản Phẩm");
            cbChooseItemSearchPro.Items.Add("Tên Danh Mục");
            cbChooseItemSearchPro.Items.Add("Kích Thước");
            cbChooseItemSearchPro.Items.Add("Giá");
            cbChooseItemSearchPro.Items.Add("Trạng Thái");
            // danh mục
            cbChooseItemSearchCate.Items.Add("Mã Danh Mục");
            cbChooseItemSearchCate.SelectedItem = "Mã Danh Mục";
            cbChooseItemSearchCate.Items.Add("Tên Danh Mục");
            // nhân viên
            cbChooseItemSearchStaff.Items.Add("Mã Tài Khoản");
            cbChooseItemSearchStaff.SelectedItem = "Mã Tài Khoản";
            cbChooseItemSearchStaff.Items.Add("Loại Tài Khoản");
            cbChooseItemSearchStaff.Items.Add("Họ Và Tên");
            cbChooseItemSearchStaff.Items.Add("Tên Đăng Nhập");
            cbChooseItemSearchStaff.Items.Add("Địa Chỉ");
            cbChooseItemSearchStaff.Items.Add("Số Điện Thoại");
        }
        // danh sách sản phẩm
        public void loadProduct()
        { 
            List<string> listNameCate = CategoryDAO.Instance.listCate();
            cbcatepro.DataSource = listNameCate;
            dgvfood.DataSource = ProductDAO.Instance.loadProduct();
            dgvfood.Columns[1].Visible = false;
            // set kích thước
            dgvfood.Columns[0].Width = 130;
            dgvfood.Columns[2].Width = 135;
            dgvfood.Columns[3].Width = 135;
            dgvfood.Columns[4].Width = 130;
            dgvfood.Columns[5].Width = 130;
            dgvfood.Columns[6].Width = 130;
            dgvfood.Columns[7].Width = 130;
            // set font size dòng đầu
            dgvfood.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgvfood.Columns[2].HeaderText = "Tên Sản Phẩm";
            dgvfood.Columns[3].HeaderText = "Tên Danh Mục";
            dgvfood.Columns[4].HeaderText = "Kích Thước";
            dgvfood.Columns[5].HeaderText = "Giá";
            dgvfood.Columns[6].HeaderText = "Thứ Tự";
            dgvfood.Columns[7].HeaderText = "Trạng Thái";
            // set lại font size dòng đầu
            for (int i = 0; i < dgvfood.Columns.Count; i++)
            {
                dgvfood.Columns[i].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
                dgvfood.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvfood.EnableHeadersVisualStyles = false;
                dgvfood.Columns[i].HeaderCell.Style.BackColor = Color.Beige;
            }
            // set lại font size tất cả các dòng
            foreach (DataGridViewColumn c in dgvfood.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Tahoma", 10);
            }
        }   
        // danh sách danh mục
        public void loadCategory()
        {
            dgvcate.DataSource = CategoryDAO.Instance.loadCate();
            // set lại kích thước cột và tên cột
            dgvcate.Columns[0].Width = 145;
            dgvcate.Columns[1].Width = 415;
            dgvcate.Columns[2].Width = 100;
            dgvcate.Columns[0].HeaderText = "Mã Danh Mục";
            dgvcate.Columns[1].HeaderText = "Tên Danh Mục";
            dgvcate.Columns[2].HeaderText = "Thứ Tự";
            // set lại font size dòng đầu
            for(int i = 0; i < dgvcate.Columns.Count; i++) { 
            dgvcate.Columns[i].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgvcate.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvcate.EnableHeadersVisualStyles = false;
                dgvcate.Columns[i].HeaderCell.Style.BackColor = Color.Beige;
            }
            // set lại font size tất cả các dòng
            foreach(DataGridViewColumn c in dgvcate.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Tahoma", 12);
            }
        }
        // danh sách nhân viên
        public void loadStaff()
        {
            List<String> listTypeAccount = TypeAccountDAO.Instance.listTypeAccount();
            cbtypeacc.DataSource = listTypeAccount;
            dgvstaff.DataSource = StaffDAO.Instance.loadStaff();
            // set lại tên dòng đầu
            dgvstaff.Columns[0].HeaderText = "Mã Tài Khoản";
            dgvstaff.Columns[1].HeaderText = "Loại Tài Khoản";
            dgvstaff.Columns[2].HeaderText = "Họ Và Tên";
            dgvstaff.Columns[3].HeaderText = "Tên Đăng Nhập";
            dgvstaff.Columns[4].HeaderText = "Ngày Sinh";
            dgvstaff.Columns[5].HeaderText = "Ngày Bắt Đầu";
            dgvstaff.Columns[6].HeaderText = "Ngày Kết Thúc";
            dgvstaff.Columns[7].HeaderText = "Địa Chỉ";
            dgvstaff.Columns[8].HeaderText = "Số Điện Thoại";
            for (int i = 0; i < dgvstaff.Columns.Count; i++)
            {
                dgvstaff.Columns[i].Width = 145;
            }
            for (int i = 0; i < dgvstaff.Columns.Count; i++)
            {
                dgvstaff.Columns[i].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
                dgvstaff.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvstaff.EnableHeadersVisualStyles = false;
                dgvstaff.Columns[i].HeaderCell.Style.BackColor = Color.Beige;
            }
            // set lại font size tất cả các dòng
            foreach (DataGridViewColumn c in dgvstaff.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Tahoma", 10);
            }
        }
        // get data click in datagridview cate
        private void cell_Click_Cate(object sender, DataGridViewCellEventArgs e)
        {
            // try catch giảm lỗi khi bấm vào dòng == null
            try
            {
                if (dgvcate.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
              
                dgvcate.CurrentRow.Selected = true;
                tbidcate.Text = dgvcate.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    tbcate.Text = dgvcate.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                ncorthercate.Value = Int32.Parse(dgvcate.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                
            }
            }
            catch (Exception)
            {
                tbidcate.Text = "";
                tbcate.Text = "";
                ncorthercate.Value = 0;
            }
        }
        // get data click in datagridview food

        private void cell_click_product(object sender, DataGridViewCellEventArgs e)
        {
            // try catch giảm lỗi khi bấm vào dòng == null
            try
            {
                
                if (dgvfood.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvfood.CurrentRow.Selected = true;
                    
                    tbidpro.Text = dgvfood.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    tbnamepro.Text = dgvfood.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    cbcatepro.SelectedItem = dgvfood.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    cbtrangthai.SelectedItem = dgvfood.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                    tbsizepro.Text = dgvfood.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    numericpricepro.Value = Int32.Parse(dgvfood.Rows[e.RowIndex].Cells[5].FormattedValue.ToString());
                    numericorther.Value = Int32.Parse(dgvfood.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());

                }
            }
            catch (Exception)
            {
                tbidpro.Text = "";
                tbnamepro.Text = "";
                cbcatepro.SelectedIndex = 0;
                tbsizepro.Text = "";
                numericpricepro.Value = 0;
            }
        }
        // get data click in datagridview staff
        private void cell_click_staff(object sender, DataGridViewCellEventArgs e)
        {
            // try catch giảm lỗi khi bấm vào dòng == null
            
            try
            {
                if (dgvstaff.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvstaff.CurrentRow.Selected = true;
                    tbidstaff.Text = dgvstaff.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    tbnamestaff.Text = dgvstaff.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    // loaij tai khoan
               
                    cbtypeacc.SelectedItem = dgvstaff.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    tbusername.Text = dgvstaff.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    // set ngay sinh
                    String[] dob = Time.splitDate(dgvstaff.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                    dtpdob.Value = new DateTime(Int16.Parse(dob[0]), Int16.Parse(dob[1]), Int16.Parse(dob[2]));
                    // set ngay bat dau
                    String[] startDate = Time.splitDate(dgvstaff.Rows[e.RowIndex].Cells[5].FormattedValue.ToString());
                    
                    dtbstart.Value = new DateTime(Int16.Parse(startDate[0]), Int16.Parse(startDate[1]), Int16.Parse(startDate[2]));

                    // set ngay ket thuc
                    String[] endDate = Time.splitDate(dgvstaff.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());
                    // neu k co ngay ket thuc

                    if (endDate.Length == 1)
                        dtbend.Value = new DateTime(2100, 1, 1);
                    else
                    {

                        dtbend.Value = new DateTime(Int16.Parse(endDate[0]), Int16.Parse(endDate[1]), Int16.Parse(endDate[2]));
                    }

                    tbaddress.Text = dgvstaff.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                    numericPhone.Value = Int32.Parse(dgvstaff.Rows[e.RowIndex].Cells[8].FormattedValue.ToString());
                }
            }
            catch (Exception)
            {
                tbidstaff.Text = "";
                tbnamestaff.Text = "";
                tbusername.Text = "";
                dtpdob.Value = new DateTime(2100, 1, 1);
                dtbstart.Value = new DateTime(2100, 1, 1);
                dtbend.Value = new DateTime(2100, 1, 1);
                tbaddress.Text = "";
                numericPhone.Value = 0;
                
            }
        }
        // xóa sản phẩm
        private void btndel_Click(object sender, EventArgs e)
        {
            int id = Int16.Parse(tbidpro.Text);
            bool checkAddPro = DetailProductDAO.Instance.deleteDetailPro(id);
            if(checkAddPro)
            {
                MessageBox.Show("Xóa Sản Phẩm Thành Công!");
                loadProduct();
                clearItemProduct();
            } else
                MessageBox.Show("Xóa Sản Phẩm Thất Bại!");

        }
        // thêm sản phẩm
        private void btnadd_Click(object sender, EventArgs e)
        {
           
            string namePro = tbnamepro.Text;
            string nameCate = cbcatepro.GetItemText(cbcatepro.SelectedItem);
            string status = cbtrangthai.GetItemText(cbtrangthai.SelectedItem);
            int idCate = CategoryDAO.Instance.getIdCateByNameCate(nameCate);
            string size = tbsizepro.Text;
            long price = (long)numericpricepro.Value;
            int orther = (int)numericorther.Value;
            
            Food pro = new Food
            {
                idfood = 1,
                idcategory = idCate,
                foodname = namePro,
                orther = orther,
            };
           
            bool checkInsert = false;
            bool checkAddDetail = false;
            detailFood detailPro = null;
            if (pro.idcategory != 0 && !namePro.Equals("") && !size.Equals(""))
            {
                checkInsert = ProductDAO.Instance.insertProduct(pro,nameCate);
                int idPro = pro.idfood;
                // nếu sản phẩm đã có rồi thì thêm vào id sản phẩm đã có
                if (!checkInsert)
                {
                    idPro = ProductDAO.Instance.loadIDProduct(namePro, idCate)[0];
                }
                detailPro = new detailFood
                    {
                        iddetail = 1,
                        idfood = idPro,
                        size = size,
                        price = price,
                        status = status,
                    };
                
                checkAddDetail = DetailProductDAO.Instance.insertDetailPro(detailPro);
                   if(checkAddDetail) {
                        loadProduct();
                        clearItemProduct();
                        MessageBox.Show("Đã Thêm Sản Phẩm!");
                    } else
                    {
                        MessageBox.Show("Thêm Thất Bại!");
                    }
                
            } else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");  
        }
        // clear thông tin product
       public void clearItemProduct()
        {
            tbidpro.Text = "";
            tbnamepro.Text = "";
            cbcatepro.SelectedIndex = 0;
            tbsizepro.Text = "";
            numericpricepro.Value = 0;
            numericorther.Value = 0;
            cbtrangthai.Items.Clear();
        }
        // sửa thông tin sản phẩm
        private void btnedit_Click(object sender, EventArgs e)
        {
            int idPro = Int16.Parse(tbidpro.Text);
            string namePro = tbnamepro.Text;
            string cate = cbcatepro.GetItemText(cbcatepro.SelectedItem);
            string size = tbsizepro.Text;
            long price = (long)numericpricepro.Value;
            string status = cbtrangthai.GetItemText(cbtrangthai.SelectedItem);
            
            if (CategoryDAO.Instance.getIdCateByNameCate(cate) != 0 && !namePro.Equals("") && !size.Equals(""))
                {
                bool checkUpdatePro = ProductDAO.Instance.updatePro(idPro, namePro, cate);
                if (checkUpdatePro) {
                    DetailProductDAO.Instance.updateDetailPro(idPro, namePro, cate, size, price, status);
                    loadProduct();
                    MessageBox.Show("Sửa Thông Tin Thành Công!");
                } 
                else
                {
                    List<Product> listpro = ProductDAO.Instance.loadProductByIDDetail(idPro);
                    string nameProByIdDetail = listpro[0].Name;
                    string nameCate = listpro[0].Namecate;
                    bool checkUpdateDetail= DetailProductDAO.Instance.updateDetailPro(idPro, nameProByIdDetail, nameCate, size, price, status);
                    if(checkUpdateDetail)
                    {
                        loadProduct();
                        MessageBox.Show("Sửa Thông Tin Thành Công!");
                    } else
                        MessageBox.Show("Sửa Thông Tin Sản Phẩm Thất Bại!");
                }
                    
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        }
        // thêm danh mục
        private void button6_Click(object sender, EventArgs e)
        {
            string nameCate = tbcate.Text;
            int orther = (int)ncorthercate.Value;
            FoodCategory cate = new FoodCategory {
                idcategory = 1,
                namecategory = nameCate,
                orther = orther,
            };
            bool checkAddCate = false;
            if (!nameCate.Equals(""))
               checkAddCate = CategoryDAO.Instance.insert(cate);
            if (checkAddCate) {
                MessageBox.Show("Thêm Danh Mục Thành Công!");
                loadCategory();
            }
            else
                MessageBox.Show("Thêm Danh Mục Thất Bại!");
        }
        // xóa danh mục
        private void button8_Click(object sender, EventArgs e)
        {
            int id = Int16.Parse(tbidcate.Text);
           
            bool checkDelCate = CategoryDAO.Instance.deleteCate(id);
            if (checkDelCate)
            {
                MessageBox.Show("Xóa Danh Mục Thành Công!");
                loadCategory();
                clearItemCate();
            }
            else
                MessageBox.Show("Xóa Danh Mục Thất Bại!");
        }
        // sửa danh mục
        private void button7_Click(object sender, EventArgs e)
        {
            int id = Int16.Parse(tbidcate.Text);
            string nameCate = tbcate.Text;
            int orther = (int)ncorthercate.Value;
            bool checkUpdateCate = CategoryDAO.Instance.updateCate(id, nameCate, orther);
            if(checkUpdateCate)
            {
                MessageBox.Show("Sửa Danh Mục Thành Công!");
                loadCategory();
            } else
                MessageBox.Show("Sửa Danh Mục Thất Bại!");
        }
        // clear cate
        public void clearItemCate()
        {
            tbidcate.Text = "";
            tbcate.Text = "";
            ncorthercate.Value = 0;
        }
        // thêm nhân viên
        private void button10_Click(object sender, EventArgs e)
        {
            
            string nameStaff = tbnamestaff.Text;
            string typeAcc = cbtypeacc.GetItemText(cbtypeacc.SelectedItem);
            int idAcc = TypeAccountDAO.Instance.IDAccount(typeAcc);
            string username = tbusername.Text;
            string pass = "1";
            DateTime dob = dtpdob.Value;
            DateTime startDate = dtbstart.Value;
            DateTime endDate = dtbend.Value;
            string address = tbaddress.Text;
            long sdt = (long)numericPhone.Value;

            if (!username.Equals("")) { 
                Account acc = new Account
                {
                    idAccount = 1,
                    idAccountType = idAcc,
                    full_name = nameStaff,
                    username = username,
                    password = pass,
                    dateofbird = dob,
                    startdate = startDate,
                    enddate = endDate,
                    address = address,
                    numberphone = sdt,
                };
                bool checkAddUser = StaffDAO.Instance.insertStaff(acc);
                if (checkAddUser) { 
                    MessageBox.Show("Thêm Nhân Viên Thành Công!");
                    loadStaff();
                }
                else
                    MessageBox.Show("Thêm Nhân Viên Thất Bại!");
            } else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");

        }
        
        // xóa nhân viên
        private void button12_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbidstaff.Text);
            bool checkDelStaff = StaffDAO.Instance.deleteStaff(id);
            if(checkDelStaff)
            {
                MessageBox.Show("Xóa Nhân Viên Thành Công!");
                loadStaff();
            } else
                MessageBox.Show("Xóa Nhân Viên Thất Bại!");
        }

        // sửa thông tin nhân viên
        private void button11_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbidstaff.Text);
            string nameStaff = tbnamestaff.Text;
            string typeAcc = cbtypeacc.GetItemText(cbtypeacc.SelectedItem);
            int idAcc = TypeAccountDAO.Instance.IDAccount(typeAcc);
            string username = tbusername.Text;
            string pass = "1";
            DateTime dob = dtpdob.Value;
            DateTime startDate = dtbstart.Value;
            DateTime endDate = dtbend.Value;
            string address = tbaddress.Text;
            long sdt = (long)numericPhone.Value;
            if(!username.Equals(""))
            {
                bool checkUpdateStaff = StaffDAO.Instance.updateStaff(id, idAcc, nameStaff,username, pass, dob, startDate, endDate, address, sdt);
                if(checkUpdateStaff)
                {
                    MessageBox.Show("Sửa Thông Tin Nhân Viên Thành Công!");
                    loadStaff();
                } else
                    MessageBox.Show("Sửa Thông Tin Nhân Viên Thất Bại!");

            } else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        }

        // Thống kê
        // load lên danh sách thống kê theo ngày
        public void loadBillDashBoard()
        {
       
            DateTime start = dtpstartdb.Value;
            DateTime end = dtbenddb.Value;
            List<BillDTO> listBill  = BillDAO.Instance.loadBill(start, end);
            tbtongsodon.Text = listBill.Count().ToString();
            tbdoanhthu.Text = BillDAO.Instance.tongDoanhThu(listBill).ToString();
            dgvthongke.DataSource = listBill;
            // set width column
            dgvthongke.Columns[0].Width = 120;
            dgvthongke.Columns[2].Width = 170;
            dgvthongke.Columns[3].Width = 150;
            dgvthongke.Columns[4].Width = 120;
            dgvthongke.Columns[5].Width = 140;
            // set name column
            dgvthongke.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvthongke.Columns[1].Visible = false;
            dgvthongke.Columns[2].HeaderText = "Tài Khoản Hóa Đơn";
            dgvthongke.Columns[3].HeaderText = "Ngày Lập";
            dgvthongke.Columns[4].HeaderText = "Giảm Giá";
            dgvthongke.Columns[5].HeaderText = "Tổng Tiền";
            dgvthongke.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            for (int i = 0; i < dgvthongke.Columns.Count; i++)
            {
                dgvthongke.Columns[i].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
                dgvthongke.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvthongke.EnableHeadersVisualStyles = false;
                dgvthongke.Columns[i].HeaderCell.Style.BackColor = Color.Beige;
            }
            foreach (DataGridViewColumn c in dgvthongke.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Tahoma", 10);
            }
        }
        // khi thay đổi ngày bắt đầu trong thống kê
        private void thongke_startDateChange(object sender, EventArgs e)
        {
            loadBillDashBoard();
        }
        // khi thay đổi ngày kết thúc trong thống kê
        private void thongKe_endDateChange(object sender, EventArgs e)
        {
            loadBillDashBoard();
        }
        // load chi tiết đơn hàng
        public void loadCTDH()
        {
            dgvchitietdonhang.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvchitietdonhang.Columns[0].Width = 50;
            dgvchitietdonhang.Columns[1].Width = 130;
            dgvchitietdonhang.Columns[2].Width = 140;
            dgvchitietdonhang.Columns[3].Width = 120;
            for (int i = 0; i < dgvchitietdonhang.Columns.Count; i++)
            {
                dgvchitietdonhang.Columns[i].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
                dgvchitietdonhang.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvchitietdonhang.EnableHeadersVisualStyles = false;
                dgvchitietdonhang.Columns[i].HeaderCell.Style.BackColor = Color.Beige;
            }
            foreach (DataGridViewColumn c in dgvchitietdonhang.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Tahoma", 10);
            }
        }
        // khi nhấp chuột vào 1 ô trong phần thống kê
        private void cellClick_thongKe(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvchitietdonhang.Rows.Clear();
                if (dgvthongke.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvthongke.CurrentRow.Selected = true;
                    int id = Int16.Parse(dgvthongke.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    List<BillInforDTO> listBillInfor = BillInforDAO.Instance.loadListBillInforByIdBill(id);

                    foreach(BillInforDTO item in listBillInfor)
                    {
                        List<Product> listPro = ProductDAO.Instance.loadProductByID(item.IdDetail);
                        dgvchitietdonhang.Rows.Add(dgvchitietdonhang.Rows.Count, item.Id, listPro[0].Name, item.Amount, item.Price);
                    }

                }
            }
            catch (Exception)
            {
               
            }
        }
        // tìm kiếm product
        private void button4_Click(object sender, EventArgs e)
        {
            string topic = cbChooseItemSearchPro.GetItemText(cbChooseItemSearchPro.SelectedItem);
            string inputSearch = tbsearchpro.Text.Trim();
           if(inputSearch.Equals(""))
            {
                dgvfood.DataSource = ProductDAO.Instance.loadProduct();
            } else {
                try
                {
                    switch (topic)
                    {
                        case "Mã Sản Phẩm":
                            dgvfood.DataSource = ProductDAO.Instance.searchProductByID(Int16.Parse(inputSearch));
                            break;
                        case "Tên Sản Phẩm":
                            dgvfood.DataSource = ProductDAO.Instance.searchProductByName(inputSearch);
                            break;
                        case "Tên Danh Mục":
                            dgvfood.DataSource = ProductDAO.Instance.searchProductByNameCate(inputSearch);
                            break;
                        case "Kích Thước":
                            dgvfood.DataSource = ProductDAO.Instance.searchProductBySize(inputSearch);
                            break;
                        case "Giá":
                            dgvfood.DataSource = ProductDAO.Instance.searchProductByPrice(long.Parse(inputSearch));
                            break;
                        case "Trạng Thái":
                            dgvfood.DataSource = ProductDAO.Instance.searchProductByStatus(inputSearch);
                            break;

                    }
                }catch(Exception)
                {
                    
                }
            }
        }
        // tìm kiếm danh mục
        private void button5_Click(object sender, EventArgs e)
        {
            string topic = cbChooseItemSearchCate.GetItemText(cbChooseItemSearchCate.SelectedItem);
            string inputSearch = tbsearchcate.Text.Trim();
            if (inputSearch.Equals(""))
            {
                dgvcate.DataSource = CategoryDAO.Instance.loadCate();
            }
            else
            {
                try
                {
                    switch (topic)
                    {
                        case "Mã Danh Mục":
                            dgvcate.DataSource = CategoryDAO.Instance.searchCateByID(Int16.Parse(inputSearch));
                            break;
                        case "Tên Danh Mục":
                            dgvcate.DataSource = CategoryDAO.Instance.searchCateByNameCate(inputSearch);
                            break;
                       
                    }
                }
                catch (Exception)
                {

                }
            }
        }
        // tìm kiếm nhân viên
        private void button9_Click(object sender, EventArgs e)
        {
            string topic = cbChooseItemSearchStaff.GetItemText(cbChooseItemSearchStaff.SelectedItem);
            string inputSearch = tbsearchstaff.Text.Trim();
            if (inputSearch.Equals(""))
            {
                dgvstaff.DataSource = StaffDAO.Instance.loadStaff();
            }
            else
            {
                try
                {
                    switch (topic)
                    {
                        case "Mã Tài Khoản":
                            dgvstaff.DataSource = StaffDAO.Instance.searchStaffById(Int16.Parse(inputSearch));
                            break;
                        case "Loại Tài Khoản":
                            dgvstaff.DataSource = StaffDAO.Instance.searchStaffType(inputSearch);
                            break;
                        case "Họ Và Tên":
                            dgvstaff.DataSource = StaffDAO.Instance.searchStaffFullName(inputSearch);
                            break;
                        case "Tên Đăng Nhập":
                            dgvstaff.DataSource = StaffDAO.Instance.searchStaffByUserName(inputSearch);
                            break;
                        case "Địa Chỉ":
                            dgvstaff.DataSource = StaffDAO.Instance.searchStaffByAddress(inputSearch);
                            break;
                        case "Số Điện Thoại":
                            dgvstaff.DataSource = StaffDAO.Instance.searchStaffBySDT(long.Parse(inputSearch));
                            break;

                    }
                }
                catch (Exception)
                {

                }
            }
        }
    }
}