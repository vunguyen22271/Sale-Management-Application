namespace ShoeStore.Views
{
    partial class frmChiTietNhapKho
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
            this.btnThemChiTietNhapKho = new System.Windows.Forms.Button();
            this.groupBoxThongTinBoPhan = new System.Windows.Forms.GroupBox();
            this.lv = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDGiay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMauSac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.txtGiaGoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTenGiay = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxThongTinBoPhan.SuspendLayout();
            this.groupBoxThongTinChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThemChiTietNhapKho);
            this.groupBox1.Location = new System.Drawing.Point(18, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 110);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // btnThemChiTietNhapKho
            // 
            this.btnThemChiTietNhapKho.Location = new System.Drawing.Point(161, 39);
            this.btnThemChiTietNhapKho.Name = "btnThemChiTietNhapKho";
            this.btnThemChiTietNhapKho.Size = new System.Drawing.Size(80, 40);
            this.btnThemChiTietNhapKho.TabIndex = 4;
            this.btnThemChiTietNhapKho.Text = "Thêm giày";
            this.btnThemChiTietNhapKho.UseVisualStyleBackColor = true;
            this.btnThemChiTietNhapKho.Click += new System.EventHandler(this.btnThemChiTietNhapKho_Click_1);
            // 
            // groupBoxThongTinBoPhan
            // 
            this.groupBoxThongTinBoPhan.Controls.Add(this.lv);
            this.groupBoxThongTinBoPhan.Location = new System.Drawing.Point(12, 191);
            this.groupBoxThongTinBoPhan.Name = "groupBoxThongTinBoPhan";
            this.groupBoxThongTinBoPhan.Size = new System.Drawing.Size(810, 199);
            this.groupBoxThongTinBoPhan.TabIndex = 38;
            this.groupBoxThongTinBoPhan.TabStop = false;
            this.groupBoxThongTinBoPhan.Text = "Thông tin chung";
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colDGiay,
            this.colTen,
            this.colMauSac,
            this.colSize,
            this.colSoLuong,
            this.colGoc,
            this.colThanhTien});
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(6, 19);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(798, 174);
            this.lv.TabIndex = 1;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colDGiay
            // 
            this.colDGiay.Text = "Mã giày";
            // 
            // colTen
            // 
            this.colTen.Text = "Tên giày";
            this.colTen.Width = 86;
            // 
            // colMauSac
            // 
            this.colMauSac.Text = "Màu sắc";
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            // 
            // colGoc
            // 
            this.colGoc.Text = "Giá gốc";
            this.colGoc.Width = 88;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Text = "Thành tiền";
            // 
            // groupBoxThongTinChiTiet
            // 
            this.groupBoxThongTinChiTiet.Controls.Add(this.txtGiaGoc);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label5);
            this.groupBoxThongTinChiTiet.Controls.Add(this.cbTenGiay);
            this.groupBoxThongTinChiTiet.Controls.Add(this.txtSoLuong);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label3);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label2);
            this.groupBoxThongTinChiTiet.Location = new System.Drawing.Point(12, 12);
            this.groupBoxThongTinChiTiet.Name = "groupBoxThongTinChiTiet";
            this.groupBoxThongTinChiTiet.Size = new System.Drawing.Size(810, 150);
            this.groupBoxThongTinChiTiet.TabIndex = 39;
            this.groupBoxThongTinChiTiet.TabStop = false;
            this.groupBoxThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // txtGiaGoc
            // 
            this.txtGiaGoc.Location = new System.Drawing.Point(548, 27);
            this.txtGiaGoc.Name = "txtGiaGoc";
            this.txtGiaGoc.Size = new System.Drawing.Size(100, 20);
            this.txtGiaGoc.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Giá gốc";
            // 
            // cbTenGiay
            // 
            this.cbTenGiay.FormattingEnabled = true;
            this.cbTenGiay.Location = new System.Drawing.Point(69, 27);
            this.cbTenGiay.Name = "cbTenGiay";
            this.cbTenGiay.Size = new System.Drawing.Size(285, 21);
            this.cbTenGiay.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(440, 27);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(47, 20);
            this.txtSoLuong.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên giày";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(378, 39);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 40);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmChiTietNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxThongTinBoPhan);
            this.Controls.Add(this.groupBoxThongTinChiTiet);
            this.Name = "frmChiTietNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết nhập kho";
            this.Load += new System.EventHandler(this.frmChiTietNhapKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxThongTinBoPhan.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemChiTietNhapKho;
        private System.Windows.Forms.GroupBox groupBoxThongTinBoPhan;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colMauSac;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colGoc;
        private System.Windows.Forms.ColumnHeader colThanhTien;
        private System.Windows.Forms.GroupBox groupBoxThongTinChiTiet;
        private System.Windows.Forms.TextBox txtGiaGoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTenGiay;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader colDGiay;
        private System.Windows.Forms.Button btnXoa;
    }
}