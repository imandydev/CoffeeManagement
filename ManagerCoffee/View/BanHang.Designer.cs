
using ManagerCoffee.Support;

namespace ManagerCoffee.View
{
    partial class BanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvbill = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbnamepro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.flplistpro = new System.Windows.Forms.FlowLayoutPanel();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.cbsize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnaddpro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.tbtong = new System.Windows.Forms.TextBox();
            this.tbgiamgia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnfind = new System.Windows.Forms.Button();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.tbdanhmuc = new System.Windows.Forms.ComboBox();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dgvbill);
            this.panel1.Controls.Add(this.tbnamepro);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbprice);
            this.panel1.Controls.Add(this.flplistpro);
            this.panel1.Controls.Add(this.btnthanhtoan);
            this.panel1.Controls.Add(this.cbsize);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnaddpro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.tbtong);
            this.panel1.Controls.Add(this.tbgiamgia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnfind);
            this.panel1.Controls.Add(this.tbtimkiem);
            this.panel1.Controls.Add(this.tbdanhmuc);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 676);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(126)))), ((int)(((byte)(39)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ManagerCoffee.Properties.Resources.Editing_Delete_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(829, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 74);
            this.button1.TabIndex = 25;
            this.button1.Text = "Xóa Sản Phẩm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvbill
            // 
            this.dgvbill.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.name,
            this.size,
            this.amount_1,
            this.price_1,
            this.iddetail,
            this.idpro});
            this.dgvbill.Location = new System.Drawing.Point(-1, 75);
            this.dgvbill.Name = "dgvbill";
            this.dgvbill.Size = new System.Drawing.Size(528, 414);
            this.dgvbill.TabIndex = 24;
            this.dgvbill.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.PriceChangeRowAdd);
            this.dgvbill.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.PriceChangeRowRemove);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Tên Sản Phẩm";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            // 
            // amount_1
            // 
            this.amount_1.HeaderText = "Số Lượng";
            this.amount_1.Name = "amount_1";
            // 
            // price_1
            // 
            this.price_1.HeaderText = "Giá Tiền";
            this.price_1.Name = "price_1";
            this.price_1.ReadOnly = true;
            // 
            // iddetail
            // 
            this.iddetail.HeaderText = "IdDetail";
            this.iddetail.Name = "iddetail";
            this.iddetail.ReadOnly = true;
            // 
            // idpro
            // 
            this.idpro.HeaderText = "IdPro";
            this.idpro.Name = "idpro";
            // 
            // tbnamepro
            // 
            this.tbnamepro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnamepro.Location = new System.Drawing.Point(1054, 503);
            this.tbnamepro.Multiline = true;
            this.tbnamepro.Name = "tbnamepro";
            this.tbnamepro.ReadOnly = true;
            this.tbnamepro.Size = new System.Drawing.Size(147, 29);
            this.tbnamepro.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(922, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tên Sản Phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(922, 563);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Giá Tiền";
            // 
            // tbprice
            // 
            this.tbprice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbprice.Location = new System.Drawing.Point(1054, 555);
            this.tbprice.Multiline = true;
            this.tbprice.Name = "tbprice";
            this.tbprice.ReadOnly = true;
            this.tbprice.Size = new System.Drawing.Size(147, 29);
            this.tbprice.TabIndex = 6;
            // 
            // flplistpro
            // 
            this.flplistpro.Location = new System.Drawing.Point(533, 75);
            this.flplistpro.Name = "flplistpro";
            this.flplistpro.Size = new System.Drawing.Size(680, 414);
            this.flplistpro.TabIndex = 20;
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(126)))), ((int)(((byte)(39)))));
            this.btnthanhtoan.FlatAppearance.BorderSize = 0;
            this.btnthanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthanhtoan.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.ForeColor = System.Drawing.Color.White;
            this.btnthanhtoan.Location = new System.Drawing.Point(-1, 599);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(528, 74);
            this.btnthanhtoan.TabIndex = 7;
            this.btnthanhtoan.Text = "Thanh Toán";
            this.btnthanhtoan.UseVisualStyleBackColor = false;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // cbsize
            // 
            this.cbsize.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsize.FormattingEnabled = true;
            this.cbsize.Location = new System.Drawing.Point(629, 559);
            this.cbsize.Name = "cbsize";
            this.cbsize.Size = new System.Drawing.Size(75, 25);
            this.cbsize.TabIndex = 19;
            this.cbsize.SelectedIndexChanged += new System.EventHandler(this.sizeChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 560);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(842, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tìm Kiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(842, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Danh Mục";
            // 
            // btnaddpro
            // 
            this.btnaddpro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(126)))), ((int)(((byte)(39)))));
            this.btnaddpro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnaddpro.FlatAppearance.BorderSize = 0;
            this.btnaddpro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddpro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddpro.ForeColor = System.Drawing.Color.White;
            this.btnaddpro.Image = global::ManagerCoffee.Properties.Resources.Ecommerce_Buy_icon;
            this.btnaddpro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddpro.Location = new System.Drawing.Point(1018, 599);
            this.btnaddpro.Name = "btnaddpro";
            this.btnaddpro.Size = new System.Drawing.Size(195, 74);
            this.btnaddpro.TabIndex = 4;
            this.btnaddpro.Text = "Thêm Sản Phẩm";
            this.btnaddpro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaddpro.UseVisualStyleBackColor = false;
            this.btnaddpro.Click += new System.EventHandler(this.btnaddpro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(736, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số Lượng";
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(829, 559);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(57, 25);
            this.amount.TabIndex = 3;
            this.amount.ValueChanged += new System.EventHandler(this.priceChange);
            // 
            // tbtong
            // 
            this.tbtong.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtong.Location = new System.Drawing.Point(368, 553);
            this.tbtong.Multiline = true;
            this.tbtong.Name = "tbtong";
            this.tbtong.ReadOnly = true;
            this.tbtong.Size = new System.Drawing.Size(159, 29);
            this.tbtong.TabIndex = 6;
            // 
            // tbgiamgia
            // 
            this.tbgiamgia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgiamgia.Location = new System.Drawing.Point(368, 505);
            this.tbgiamgia.Multiline = true;
            this.tbgiamgia.Name = "tbgiamgia";
            this.tbgiamgia.Size = new System.Drawing.Size(159, 29);
            this.tbgiamgia.TabIndex = 5;
            this.tbgiamgia.TextChanged += new System.EventHandler(this.changeGiamGia);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Giảm Giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tổng Tiền";
            // 
            // btnfind
            // 
            this.btnfind.FlatAppearance.BorderSize = 0;
            this.btnfind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfind.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.Image = global::ManagerCoffee.Properties.Resources.Search_icon;
            this.btnfind.Location = new System.Drawing.Point(1117, 3);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(68, 66);
            this.btnfind.TabIndex = 2;
            this.btnfind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtimkiem.Location = new System.Drawing.Point(926, 10);
            this.tbtimkiem.Multiline = true;
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(185, 28);
            this.tbtimkiem.TabIndex = 0;
            // 
            // tbdanhmuc
            // 
            this.tbdanhmuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbdanhmuc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdanhmuc.FormattingEnabled = true;
            this.tbdanhmuc.Location = new System.Drawing.Point(926, 44);
            this.tbdanhmuc.Name = "tbdanhmuc";
            this.tbdanhmuc.Size = new System.Drawing.Size(185, 25);
            this.tbdanhmuc.TabIndex = 1;
            this.tbdanhmuc.SelectedIndexChanged += new System.EventHandler(this.cb_Danh_Muc_Change);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.White;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Black;
            this.btnback.Image = global::ManagerCoffee.Properties.Resources.arrow_back_icon;
            this.btnback.Location = new System.Drawing.Point(4, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(54, 56);
            this.btnback.TabIndex = 8;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // BanHang
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 686);
            this.Controls.Add(this.panel1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BanHang.IconOptions.SvgImage")));
            this.Name = "BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnaddpro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.TextBox tbtong;
        private System.Windows.Forms.TextBox tbgiamgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.ComboBox tbdanhmuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbsize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flplistpro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbnamepro;
        private System.Windows.Forms.DataGridView dgvbill;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpro;
        private System.Windows.Forms.Button button1;
    }
}