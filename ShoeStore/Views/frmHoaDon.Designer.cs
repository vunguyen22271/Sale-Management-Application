namespace ShoeStore.Views
{
    partial class frmHoaDon
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
            this.btnChiTietHoaDon = new System.Windows.Forms.Button();
            this.groupBoxThongTinBoPhan = new System.Windows.Forms.GroupBox();
            this.lv = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIdNhapKho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayNhapKho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTongThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxThongTinBoPhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChiTietHoaDon
            // 
            this.btnChiTietHoaDon.Location = new System.Drawing.Point(12, 472);
            this.btnChiTietHoaDon.Name = "btnChiTietHoaDon";
            this.btnChiTietHoaDon.Size = new System.Drawing.Size(165, 26);
            this.btnChiTietHoaDon.TabIndex = 35;
            this.btnChiTietHoaDon.Text = "Chi tiết hoá đơn";
            this.btnChiTietHoaDon.UseVisualStyleBackColor = true;
            this.btnChiTietHoaDon.Click += new System.EventHandler(this.btnChiTietHoaDon_Click);
            // 
            // groupBoxThongTinBoPhan
            // 
            this.groupBoxThongTinBoPhan.Controls.Add(this.lv);
            this.groupBoxThongTinBoPhan.Location = new System.Drawing.Point(12, 12);
            this.groupBoxThongTinBoPhan.Name = "groupBoxThongTinBoPhan";
            this.groupBoxThongTinBoPhan.Size = new System.Drawing.Size(810, 454);
            this.groupBoxThongTinBoPhan.TabIndex = 33;
            this.groupBoxThongTinBoPhan.TabStop = false;
            this.groupBoxThongTinBoPhan.Text = "Thông tin chung";
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colIdNhapKho,
            this.colNV,
            this.colKH,
            this.colNgayNhapKho,
            this.colSoLuong,
            this.colTongThanhTien});
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(6, 25);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(798, 423);
            this.lv.TabIndex = 1;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colIdNhapKho
            // 
            this.colIdNhapKho.Text = "Id Hoá đơn";
            this.colIdNhapKho.Width = 89;
            // 
            // colNV
            // 
            this.colNV.Text = "Nhân viên";
            this.colNV.Width = 81;
            // 
            // colKH
            // 
            this.colKH.Text = "Khách hàng";
            this.colKH.Width = 102;
            // 
            // colNgayNhapKho
            // 
            this.colNgayNhapKho.Text = "Ngày in hoá đơn";
            this.colNgayNhapKho.Width = 136;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Tổng số lượng";
            this.colSoLuong.Width = 101;
            // 
            // colTongThanhTien
            // 
            this.colTongThanhTien.Text = "Tổng thành tiền";
            this.colTongThanhTien.Width = 88;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 523);
            this.Controls.Add(this.btnChiTietHoaDon);
            this.Controls.Add(this.groupBoxThongTinBoPhan);
            this.Name = "frmHoaDon";
            this.Text = "Hoá đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBoxThongTinBoPhan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChiTietHoaDon;
        private System.Windows.Forms.GroupBox groupBoxThongTinBoPhan;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colIdNhapKho;
        private System.Windows.Forms.ColumnHeader colNV;
        private System.Windows.Forms.ColumnHeader colKH;
        private System.Windows.Forms.ColumnHeader colNgayNhapKho;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colTongThanhTien;
    }
}