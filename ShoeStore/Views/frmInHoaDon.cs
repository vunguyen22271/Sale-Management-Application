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
    public partial class frmInHoaDon : Form
    {
        string idHoaDon = "0";
        Status status = new Status();
        KhachHang khachHang = new KhachHang();
        HoaDon hoaDon = new HoaDon();
        ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
        Giay giay = new Giay();
        DanhMuc danhMuc = new DanhMuc();
        string idKH;
        User user;
        public frmInHoaDon(User user)
        {
            InitializeComponent();
            this.user = user;
            lblNgayNhap.Text = (DateTime.Now).ToString("dd/MM/yyyy");
        }
        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            LoadCBTenGiay(sender, e);
            LoadListView();
            lblIdHoaDon.Text = this.idHoaDon;
            if(user.PhanQuyen == "0")
            {
                btnDangXuat.Hide();
            }
        }
        private void LoadCBTenGiay(object sender, EventArgs e)
        {
            DataTable dt = giay.Giay_tb;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = dt.Rows[i]["tenLoaiGiay"].ToString() + " - " + dt.Rows[i]["mauSac"].ToString() + " - " + dt.Rows[i]["size"].ToString();
                item.Value = dt.Rows[i]["idGiay"].ToString();
                cbTenGiay.Items.Add(item);
            }
            if (cbTenGiay.Items.Count > 0)
            {
                cbTenGiay.SelectedIndex = 0;
                cbTenGiay_SelectionChangeCommitted(sender, e);
            }
        }
        public void LoadListView()
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.Items.Clear();

            string str;
            chiTietHoaDon.LoadDanhSachChiTiet(this.idHoaDon);
            DataTable dt = chiTietHoaDon.ChiTietHoaDon_tb;
            DataRow[] foundRows;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lv.Items.Add((i + 1).ToString());

                str = dt.Rows[i]["idGiay"].ToString();
                lvi.SubItems.Add(str);

                foundRows = giay.Giay_tb.Select("idGiay='" + str + "'");
                str = foundRows[0]["idLoaiGiay"].ToString();
                foundRows = danhMuc.DanhMuc_tb.Select("idLoaiGiay='" + str + "'");
                str = foundRows[0]["tenLoaiGiay"].ToString();
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["mauSac"].ToString();
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["size"].ToString();
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["soLuong"].ToString();
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["donGia"].ToString();
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["thanhTien"].ToString();
                lvi.SubItems.Add(str);
            }
            hoaDon.LoadHoaDon(this.idHoaDon);
            dt = hoaDon.HoaDon_tb;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lblTongSoLuong.Text = dt.Rows[i]["soLuong"].ToString();
                lblTongThanhTien.Text = dt.Rows[i]["thanhTien"].ToString();

            }
        }
        private void cbTenGiay_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                string str;
                string ten = lv.Items[lv.SelectedIndices[0]].SubItems[2].Text;
                string mausac = lv.Items[lv.SelectedIndices[0]].SubItems[3].Text;
                string size = lv.Items[lv.SelectedIndices[0]].SubItems[4].Text;
                str = ten + " - " + mausac + " - " + size;

                cbTenGiay.SelectedIndex = cbTenGiay.FindStringExact(str);
                txtSoLuong.Text = lv.Items[lv.SelectedIndices[0]].SubItems[5].Text;
                lblGiaBan.Text = lv.Items[lv.SelectedIndices[0]].SubItems[6].Text;
            }
        }
        private void btnLayidKhachHang_Click(object sender, EventArgs e)
        {
            if (kiemTraTaoPhieuHoaDonKoThongBao() != status.Exist)
            {
                string ten = txtTenKH.Text.Trim();
                string sdt = txtSdtKH.Text.Trim();
                if (ten != "" && sdt != "")
                {
                    if (IsPhoneNumber(sdt) == false || sdt.Length < 10)
                    {
                        MessageBox.Show("Số điện thoại không được chứa ký tự đặc biệt và độ dài từ 10 số trở lên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    this.idKH = khachHang.TimIDKhachHang(sdt);
                    if (this.idKH == status.Nonexistence)
                    {
                        //Insert
                        khachHang.Them(ten, sdt);
                        //Select idKH
                        this.idKH = khachHang.TimIDKhachHang(sdt);
                    }
                    txtTenKH.Text = khachHang.KhachHang_tb.Rows[0]["tenKH"].ToString();
                    //Tạo phiếu hoá đơn
                    string ngayNhapKho = (DateTime.Now).ToString("MM/dd/yyyy");
                    this.idHoaDon = hoaDon.ThemHoaDon(user.IdUser, idKH, ngayNhapKho);
                    if (this.idHoaDon == status.Nonexistence)
                    {
                        MessageBox.Show("Lỗi tạo hoá đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.idHoaDon = "0";
                        lblIdHoaDon.Text = this.idHoaDon;
                        chiTietHoaDon.LoadDanhSachChiTiet(this.idHoaDon);
                    }
                    else
                    {
                        this.chiTietHoaDon = new ChiTietHoaDon();
                        this.chiTietHoaDon.LoadDanhSachChiTiet(this.idHoaDon);
                        lblIdHoaDon.Text = this.idHoaDon;
                        MessageBox.Show("Lấy khách hàng và tạo phiếu hoá đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập tên hoặc sđt của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Thanh toán hoặc huỷ hoá đơn hiện tại trước khi nhập khách hàng và tạo hoá đơn mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(kiemTraTaoPhieuHoaDon() == status.Exist)
            {
                string idGiay = (cbTenGiay.SelectedItem as ComboboxItem).Value.ToString();
                string soluong = txtSoLuong.Text;
                string giaBan = lblGiaBan.Text;

                if (idGiay != "" && giaBan != "" && soluong != "")
                {
                    if (IsPositiveNumber(giaBan) == false || IsPositiveNumber(soluong) == false)
                    {
                        MessageBox.Show("Giá bán và số lượng chỉ chứa giá trị dương lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (chiTietHoaDon.ThemChiTiet(this.idHoaDon, idGiay, giaBan, soluong) == status.Success)
                    {
                        MessageBox.Show("Giày đã được thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListView();
                        //Function trả ra tổng số lượng và tổng thành tiền
                        hoaDon.LoadHoaDon(this.idHoaDon);
                        DataTable dt = hoaDon.HoaDon_tb;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            lblTongSoLuong.Text = dt.Rows[i]["soLuong"].ToString();
                            lblTongThanhTien.Text = dt.Rows[i]["thanhTien"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giày bị trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public static bool IsPositiveNumber(string number)
        {
            if (IsNumber(number) == false)
            {
                return false;
            }

            int num = int.Parse(number);
            if (num > 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsNumber(string number)
        {
            try
            {
                int sdt = int.Parse(number);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool IsPhoneNumber(string number)
        {
            try
            {
                int sdt = int.Parse(number);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (kiemTraTaoPhieuHoaDon() == status.Exist)
            {
                if(lv.Items.Count <= 0)
                {
                    MessageBox.Show("Hoá đơn chưa có bất cứ chi tiết nào để thanh toán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                //Transaction thanh toán đã được xử lý bởi trigger

                MessageBox.Show("Phiếu hoá đơn đã được thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Sau khi thanh toán, set idHoaDon về 0
                this.idHoaDon = "0";
                lblIdHoaDon.Text = this.idHoaDon;
                chiTietHoaDon.LoadDanhSachChiTiet(this.idHoaDon);
                LoadListView();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (kiemTraTaoPhieuHoaDon() == status.Exist)
            {
                //xoá hoá đơn và chi tiết hoá đơn hiện tại
                hoaDon = new HoaDon();
                hoaDon.XoaByToanBoHoaDon(this.idHoaDon); 

                MessageBox.Show("Phiếu hoá đơn đã được xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //set idHoaDon = 0
                this.idHoaDon = "0";
                lblIdHoaDon.Text = this.idHoaDon;
                chiTietHoaDon.LoadDanhSachChiTiet(this.idHoaDon);
                LoadListView(); 
                hoaDon.LoadHoaDon(this.idHoaDon);
                DataTable dt = hoaDon.HoaDon_tb;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lblTongSoLuong.Text = dt.Rows[i]["soLuong"].ToString();
                    lblTongThanhTien.Text = dt.Rows[i]["thanhTien"].ToString();

                }
            }
        }
        private string kiemTraTaoPhieuHoaDon()
        {
            if(this.idHoaDon == "0")
            {
                MessageBox.Show("Bạn chưa tạo phiếu hoá đơn. Vui lòng nhập khách hàng và bấm nút Tìm/Thêm khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return status.Nonexistence;
            }
            else
            {
                return status.Exist;
            }
        }
        private string kiemTraTaoPhieuHoaDonKoThongBao()
        {
            if (this.idHoaDon == "0")
            {
                return status.Nonexistence;
            }
            else
            {
                return status.Exist;
            }
        }

        private void cbTenGiay_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRow[] foundRows;
            string idGiay = (cbTenGiay.SelectedItem as ComboboxItem).Value.ToString();
            foundRows = giay.Giay_tb.Select("idGiay='" + idGiay + "'");
            lblSoLuongTrongKho.Text = "/" + foundRows[0]["soLuongGiay"].ToString();
            lblGiaBan.Text = foundRows[0]["giaBan"].ToString();
        }


        private void btnXoaChiTietHD_Click(object sender, EventArgs e)
        {
            if (kiemTraTaoPhieuHoaDon() == status.Exist)
            {
                if (lv.SelectedIndices.Count > 0)
                {
                    string str = "";
                    str = lv.Items[lv.SelectedIndices[0]].SubItems[1].Text;
                    if (MessageBox.Show("Bạn có chắc chắn là muốn xóa  giày ’" + str + "’ không ?", "Hỏi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int deleteIndex = lv.SelectedIndices[0];
                        if (chiTietHoaDon.XoaChiTiet(this.idHoaDon, deleteIndex) == status.Success)
                        {
                            LoadListView();
                        }
                        else
                        {
                            MessageBox.Show("Xoá không thành công", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn phải chọn 1 nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
