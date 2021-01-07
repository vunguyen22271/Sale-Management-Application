namespace ShoeStore.Views
{
    partial class frmInHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTongSoLuong = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTongThanhTien = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.groupBoxThongTinBoPhan = new System.Windows.Forms.GroupBox();
            this.lv = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIDGiay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMauSac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblIdHoaDon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblSoLuongTrongKho = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLayidKhachHang = new System.Windows.Forms.Button();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSdtKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTenGiay = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaChiTietHD = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxThongTinBoPhan.SuspendLayout();
            this.groupBoxThongTinChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDangXuat);
            this.groupBox1.Controls.Add(this.lblTongSoLuong);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblTongThanhTien);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnThanhToan);
            this.groupBox1.Location = new System.Drawing.Point(18, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 56);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // lblTongSoLuong
            // 
            this.lblTongSoLuong.AutoSize = true;
            this.lblTongSoLuong.Location = new System.Drawing.Point(288, 30);
            this.lblTongSoLuong.Name = "lblTongSoLuong";
            this.lblTongSoLuong.Size = new System.Drawing.Size(0, 13);
            this.lblTongSoLuong.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tổng số lượng";
            // 
            // lblTongThanhTien
            // 
            this.lblTongThanhTien.AutoSize = true;
            this.lblTongThanhTien.Location = new System.Drawing.Point(439, 30);
            this.lblTongThanhTien.Name = "lblTongThanhTien";
            this.lblTongThanhTien.Size = new System.Drawing.Size(0, 13);
            this.lblTongThanhTien.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tổng thành tiền";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(697, 16);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 40);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(598, 16);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(80, 40);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // groupBoxThongTinBoPhan
            // 
            this.groupBoxThongTinBoPhan.Controls.Add(this.lv);
            this.groupBoxThongTinBoPhan.Location = new System.Drawing.Point(12, 250);
            this.groupBoxThongTinBoPhan.Name = "groupBoxThongTinBoPhan";
            this.groupBoxThongTinBoPhan.Size = new System.Drawing.Size(810, 199);
            this.groupBoxThongTinBoPhan.TabIndex = 35;
            this.groupBoxThongTinBoPhan.TabStop = false;
            this.groupBoxThongTinBoPhan.Text = "Thông tin chung";
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colIDGiay,
            this.colTen,
            this.colMauSac,
            this.colSize,
            this.colSoLuong,
            this.colBan,
            this.colThanhTien});
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(6, 19);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(798, 174);
            this.lv.TabIndex = 1;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colIDGiay
            // 
            this.colIDGiay.Text = "Mã giày";
            // 
            // colTen
            // 
            this.colTen.Text = "Tên giày";
            this.colTen.Width = 98;
            // 
            // colMauSac
            // 
            this.colMauSac.Text = "Màu sắc";
            this.colMauSac.Width = 85;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.Width = 93;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 132;
            // 
            // colBan
            // 
            this.colBan.Text = "Giá bán";
            this.colBan.Width = 108;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Text = "Thành tiền";
            this.colThanhTien.Width = 188;
            // 
            // groupBoxThongTinChiTiet
            // 
            this.groupBoxThongTinChiTiet.Controls.Add(this.btnXoaChiTietHD);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label8);
            this.groupBoxThongTinChiTiet.Controls.Add(this.lblIdHoaDon);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label6);
            this.groupBoxThongTinChiTiet.Controls.Add(this.lblNgayNhap);
            this.groupBoxThongTinChiTiet.Controls.Add(this.lblSoLuongTrongKho);
            this.groupBoxThongTinChiTiet.Controls.Add(this.lblGiaBan);
            this.groupBoxThongTinChiTiet.Controls.Add(this.btnThem);
            this.groupBoxThongTinChiTiet.Controls.Add(this.btnLayidKhachHang);
            this.groupBoxThongTinChiTiet.Controls.Add(this.txtTenKH);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label4);
            this.groupBoxThongTinChiTiet.Controls.Add(this.txtSdtKH);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label1);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label5);
            this.groupBoxThongTinChiTiet.Controls.Add(this.cbTenGiay);
            this.groupBoxThongTinChiTiet.Controls.Add(this.txtSoLuong);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label3);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label2);
            this.groupBoxThongTinChiTiet.Location = new System.Drawing.Point(12, 12);
            this.groupBoxThongTinChiTiet.Name = "groupBoxThongTinChiTiet";
            this.groupBoxThongTinChiTiet.Size = new System.Drawing.Size(810, 232);
            this.groupBoxThongTinChiTiet.TabIndex = 36;
            this.groupBoxThongTinChiTiet.TabStop = false;
            this.groupBoxThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(534, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mã hoá đơn";
            // 
            // lblIdHoaDon
            // 
            this.lblIdHoaDon.AutoSize = true;
            this.lblIdHoaDon.Location = new System.Drawing.Point(602, 26);
            this.lblIdHoaDon.Name = "lblIdHoaDon";
            this.lblIdHoaDon.Size = new System.Drawing.Size(0, 13);
            this.lblIdHoaDon.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(679, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày nhập:";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(744, 26);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(0, 13);
            this.lblNgayNhap.TabIndex = 22;
            // 
            // lblSoLuongTrongKho
            // 
            this.lblSoLuongTrongKho.AutoSize = true;
            this.lblSoLuongTrongKho.Location = new System.Drawing.Point(501, 143);
            this.lblSoLuongTrongKho.Name = "lblSoLuongTrongKho";
            this.lblSoLuongTrongKho.Size = new System.Drawing.Size(12, 13);
            this.lblSoLuongTrongKho.TabIndex = 21;
            this.lblSoLuongTrongKho.Text = "/";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Location = new System.Drawing.Point(640, 143);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(0, 13);
            this.lblGiaBan.TabIndex = 20;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(282, 186);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 40);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm giày";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLayidKhachHang
            // 
            this.btnLayidKhachHang.Location = new System.Drawing.Point(440, 8);
            this.btnLayidKhachHang.Name = "btnLayidKhachHang";
            this.btnLayidKhachHang.Size = new System.Drawing.Size(80, 40);
            this.btnLayidKhachHang.TabIndex = 5;
            this.btnLayidKhachHang.Text = "Tìm/Thêm khách hàng";
            this.btnLayidKhachHang.UseVisualStyleBackColor = true;
            this.btnLayidKhachHang.Click += new System.EventHandler(this.btnLayidKhachHang_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(315, 19);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(100, 20);
            this.txtTenKH.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tên Khách hàng";
            // 
            // txtSdtKH
            // 
            this.txtSdtKH.Location = new System.Drawing.Point(110, 19);
            this.txtSdtKH.Name = "txtSdtKH";
            this.txtSdtKH.Size = new System.Drawing.Size(100, 20);
            this.txtSdtKH.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "SĐT Khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Giá bán:";
            // 
            // cbTenGiay
            // 
            this.cbTenGiay.FormattingEnabled = true;
            this.cbTenGiay.Location = new System.Drawing.Point(77, 140);
            this.cbTenGiay.Name = "cbTenGiay";
            this.cbTenGiay.Size = new System.Drawing.Size(285, 21);
            this.cbTenGiay.TabIndex = 8;
            this.cbTenGiay.SelectedIndexChanged += new System.EventHandler(this.cbTenGiay_SelectedIndexChanged);
            this.cbTenGiay.SelectionChangeCommitted += new System.EventHandler(this.cbTenGiay_SelectionChangeCommitted);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(448, 140);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(47, 20);
            this.txtSoLuong.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên giày";
            // 
            // btnXoaChiTietHD
            // 
            this.btnXoaChiTietHD.Location = new System.Drawing.Point(406, 186);
            this.btnXoaChiTietHD.Name = "btnXoaChiTietHD";
            this.btnXoaChiTietHD.Size = new System.Drawing.Size(80, 40);
            this.btnXoaChiTietHD.TabIndex = 27;
            this.btnXoaChiTietHD.Text = "Xoá giày";
            this.btnXoaChiTietHD.UseVisualStyleBackColor = true;
            this.btnXoaChiTietHD.Click += new System.EventHandler(this.btnXoaChiTietHD_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(18, 10);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(80, 40);
            this.btnDangXuat.TabIndex = 28;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxThongTinBoPhan);
            this.Controls.Add(this.groupBoxThongTinChiTiet);
            this.Name = "frmInHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In hoá đơn";
            this.Load += new System.EventHandler(this.frmInHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxThongTinBoPhan.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.GroupBox groupBoxThongTinBoPhan;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colMauSac;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colBan;
        private System.Windows.Forms.ColumnHeader colThanhTien;
        private System.Windows.Forms.GroupBox groupBoxThongTinChiTiet;
        private System.Windows.Forms.Button btnLayidKhachHang;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSdtKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTenGiay;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblSoLuongTrongKho;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTongSoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTongThanhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader colIDGiay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIdHoaDon;
        private System.Windows.Forms.Button btnXoaChiTietHD;
        private System.Windows.Forms.Button btnDangXuat;
    }
}