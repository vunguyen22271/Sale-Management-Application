namespace ShoeStore.Views
{
    partial class frmNhapKho
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
            this.groupBoxThongTinBoPhan = new System.Windows.Forms.GroupBox();
            this.lv = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayNhapKho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTongThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThemPhieu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTongThanhTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTongSoLuong = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblNguoiNhap = new System.Windows.Forms.Label();
            this.colIdNhapKho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNCC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChiTietPhieuNhap = new System.Windows.Forms.Button();
            this.groupBoxThongTinBoPhan.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxThongTinBoPhan
            // 
            this.groupBoxThongTinBoPhan.Controls.Add(this.lv);
            this.groupBoxThongTinBoPhan.Location = new System.Drawing.Point(12, 165);
            this.groupBoxThongTinBoPhan.Name = "groupBoxThongTinBoPhan";
            this.groupBoxThongTinBoPhan.Size = new System.Drawing.Size(810, 199);
            this.groupBoxThongTinBoPhan.TabIndex = 29;
            this.groupBoxThongTinBoPhan.TabStop = false;
            this.groupBoxThongTinBoPhan.Text = "Thông tin chung";
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colIdNhapKho,
            this.colNV,
            this.colNCC,
            this.colNgayNhapKho,
            this.colSoLuong,
            this.colTongThanhTien});
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(6, 25);
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
            // colNgayNhapKho
            // 
            this.colNgayNhapKho.Text = "Ngày nhập kho";
            this.colNgayNhapKho.Width = 86;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Tổng số lượng";
            // 
            // colTongThanhTien
            // 
            this.colTongThanhTien.Text = "Tổng thành tiền";
            this.colTongThanhTien.Width = 88;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThemPhieu);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblTongThanhTien);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblTongSoLuong);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbNhaCungCap);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblNgayNhap);
            this.groupBox3.Controls.Add(this.lblNguoiNhap);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(804, 147);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.Location = new System.Drawing.Point(13, 94);
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.Size = new System.Drawing.Size(80, 40);
            this.btnThemPhieu.TabIndex = 23;
            this.btnThemPhieu.Text = "Thêm phiếu";
            this.btnThemPhieu.UseVisualStyleBackColor = true;
            this.btnThemPhieu.Click += new System.EventHandler(this.btnThemPhieu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(610, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tổng thành tiền:";
            // 
            // lblTongThanhTien
            // 
            this.lblTongThanhTien.AutoSize = true;
            this.lblTongThanhTien.Location = new System.Drawing.Point(701, 121);
            this.lblTongThanhTien.Name = "lblTongThanhTien";
            this.lblTongThanhTien.Size = new System.Drawing.Size(82, 13);
            this.lblTongThanhTien.TabIndex = 21;
            this.lblTongThanhTien.Text = "Tổng thành tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tổng số lượng:";
            // 
            // lblTongSoLuong
            // 
            this.lblTongSoLuong.AutoSize = true;
            this.lblTongSoLuong.Location = new System.Drawing.Point(503, 121);
            this.lblTongSoLuong.Name = "lblTongSoLuong";
            this.lblTongSoLuong.Size = new System.Drawing.Size(75, 13);
            this.lblTongSoLuong.TabIndex = 19;
            this.lblTongSoLuong.Text = "Tổng số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Người nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ngày nhập:";
            // 
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.FormattingEnabled = true;
            this.cbNhaCungCap.Location = new System.Drawing.Point(94, 19);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Size = new System.Drawing.Size(121, 21);
            this.cbNhaCungCap.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Nhà cung cấp";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(258, 64);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(59, 13);
            this.lblNgayNhap.TabIndex = 4;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // lblNguoiNhap
            // 
            this.lblNguoiNhap.AutoSize = true;
            this.lblNguoiNhap.Location = new System.Drawing.Point(91, 64);
            this.lblNguoiNhap.Name = "lblNguoiNhap";
            this.lblNguoiNhap.Size = new System.Drawing.Size(62, 13);
            this.lblNguoiNhap.TabIndex = 3;
            this.lblNguoiNhap.Text = "Người nhập";
            // 
            // colIdNhapKho
            // 
            this.colIdNhapKho.Text = "Id Nhập kho";
            // 
            // colNV
            // 
            this.colNV.Text = "Nhân viên";
            // 
            // colNCC
            // 
            this.colNCC.Text = "Nhà cung cấp";
            // 
            // btnChiTietPhieuNhap
            // 
            this.btnChiTietPhieuNhap.Location = new System.Drawing.Point(12, 370);
            this.btnChiTietPhieuNhap.Name = "btnChiTietPhieuNhap";
            this.btnChiTietPhieuNhap.Size = new System.Drawing.Size(165, 26);
            this.btnChiTietPhieuNhap.TabIndex = 32;
            this.btnChiTietPhieuNhap.Text = "Chi tiết phiếu nhập";
            this.btnChiTietPhieuNhap.UseVisualStyleBackColor = true;
            this.btnChiTietPhieuNhap.Click += new System.EventHandler(this.btnChiTietPhieuNhap_Click);
            // 
            // frmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 523);
            this.Controls.Add(this.btnChiTietPhieuNhap);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxThongTinBoPhan);
            this.Name = "frmNhapKho";
            this.Text = "Nhập kho";
            this.Load += new System.EventHandler(this.frmNhapKho_Load);
            this.groupBoxThongTinBoPhan.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxThongTinBoPhan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbNhaCungCap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblNguoiNhap;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colNgayNhapKho;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colTongThanhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemPhieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTongThanhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTongSoLuong;
        private System.Windows.Forms.ColumnHeader colIdNhapKho;
        private System.Windows.Forms.ColumnHeader colNV;
        private System.Windows.Forms.ColumnHeader colNCC;
        private System.Windows.Forms.Button btnChiTietPhieuNhap;
    }
}