using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoeStore.Controls;

namespace ShoeStore.Views
{
    public partial class frmMDI : Form
    {
        User user;

        frmHangGiay formHangGiay;
        frmNhaCungCap formNhaCungCap;
        frmDanhMuc formDanhMuc;
        frmGiay formGiay;
        frmNhapKho formNhapKho;
        frmNhanVien formNhanVien;
        frmKhachHang formKhachHang;
        frmInHoaDon formInHoaDon;
        frmHoaDon formHoaDon;
        frmThongke formThongKe;

        public frmMDI(User user)
        {
            InitializeComponent();
            this.user = user;
            this.WindowState = FormWindowState.Maximized;
        }

        #region Xử lý điều hướng MDI Child
        private void frmMDI_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            if (this.ActiveMdiChild.Tag == null)
            {
                TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                tp.Tag = this.ActiveMdiChild;
                tp.Parent = this.tabMain;
                this.tabMain.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabMain.SelectedTab != null && this.tabMain.SelectedTab.Tag != null)
            {
                (this.tabMain.SelectedTab.Tag as Form).Select();
            }
        }
        #endregion

        private void btnHangGiay_Click(object sender, EventArgs e)
        {
            if (this.formHangGiay is null || this.formHangGiay.IsDisposed)
            {
                this.formHangGiay = new frmHangGiay();
                this.formHangGiay.MdiParent = this;
                this.formHangGiay.Dock = DockStyle.Fill;
                this.formHangGiay.Show();
            }
            else
            {
                this.formHangGiay.Select();
            }
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            if (this.formNhaCungCap is null || this.formNhaCungCap.IsDisposed)
            {
                this.formNhaCungCap = new frmNhaCungCap();
                this.formNhaCungCap.MdiParent = this;
                this.formNhaCungCap.Dock = DockStyle.Fill;
                this.formNhaCungCap.Show();
            }
            else
            {
                this.formNhaCungCap.Select();
            }
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            if (this.formDanhMuc is null || this.formDanhMuc.IsDisposed)
            {
                this.formDanhMuc = new frmDanhMuc();
                this.formDanhMuc.MdiParent = this;
                this.formDanhMuc.Dock = DockStyle.Fill;
                this.formDanhMuc.Show();
            }
            else
            {
                this.formDanhMuc.Select();
            }
        }

        private void btnGiay_Click(object sender, EventArgs e)
        {
            if (this.formGiay is null || this.formGiay.IsDisposed)
            {
                this.formGiay = new frmGiay();
                this.formGiay.MdiParent = this;
                this.formGiay.Dock = DockStyle.Fill;
                this.formGiay.Show();
            }
            else
            {
                this.formGiay.Select();
            }
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            if (this.formNhapKho is null || this.formNhapKho.IsDisposed)
            {
                this.formNhapKho = new frmNhapKho(user);
                this.formNhapKho.MdiParent = this;
                this.formNhapKho.Dock = DockStyle.Fill;
                this.formNhapKho.Show();
            }
            else
            {
                this.formNhapKho.Select();
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (this.formNhanVien is null || this.formNhanVien.IsDisposed)
            {
                this.formNhanVien = new frmNhanVien();
                this.formNhanVien.MdiParent = this;
                this.formNhanVien.Dock = DockStyle.Fill;
                this.formNhanVien.Show();
            }
            else
            {
                this.formNhanVien.Select();
            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (this.formKhachHang is null || this.formKhachHang.IsDisposed)
            {
                this.formKhachHang = new frmKhachHang();
                this.formKhachHang.MdiParent = this;
                this.formKhachHang.Dock = DockStyle.Fill;
                this.formKhachHang.Show();
            }
            else
            {
                this.formKhachHang.Select();
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (this.formInHoaDon is null || this.formInHoaDon.IsDisposed)
            {
                this.formInHoaDon = new frmInHoaDon(user);
                this.formInHoaDon.MdiParent = this;
                this.formInHoaDon.Dock = DockStyle.Fill;
                this.formInHoaDon.Show();
            }
            else
            {
                this.formInHoaDon.Select();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (this.formThongKe is null || this.formThongKe.IsDisposed)
            {
                this.formThongKe = new frmThongke();
                this.formThongKe.MdiParent = this;
                this.formThongKe.Dock = DockStyle.Fill;
                this.formThongKe.Show();
            }
            else
            {
                this.formThongKe.Select();
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (this.formHoaDon is null || this.formHoaDon.IsDisposed)
            {
                this.formHoaDon = new frmHoaDon();
                this.formHoaDon.MdiParent = this;
                this.formHoaDon.Dock = DockStyle.Fill;
                this.formHoaDon.Show();
            }
            else
            {
                this.formHoaDon.Select();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap form = new frmDangNhap();
            form.Show();
            this.Hide();
        }
    }
}