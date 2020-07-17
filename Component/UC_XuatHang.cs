using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project.Controller;
using Project.Bussiness;
using Project.Reports;

namespace Project.Component
{
    public partial class UC_XuatHang : UserControl
    {
        public UC_XuatHang()
        {
            InitializeComponent();
        }

        XeMay_Mod hangblo = new XeMay_Mod();
        NhanVien_Mod nvblo = new NhanVien_Mod();
        KhachHang_Mod khachblo = new KhachHang_Mod();
        XuatHang_Mod xuatblo = new XuatHang_Mod();
        ChiTietPhieuXuat luuvet = new ChiTietPhieuXuat();
        bool kt = true;
        void load()
        {

            gridControl1.DataSource = xuatblo.getAll(txtMaHoaDon.Text);
            gridControl1.Refresh();

            txtMaHoaDon.Text = xuatblo.NextID();
            txtMaHoaDon.Enabled = false;
            
            cmbNgayXuat.Text = DateTime.Today.ToShortDateString();
            cmbKhachHang.DataSource = khachblo.getAll();
            cmbKhachHang.DisplayMember = "tenkhachhang";
            cmbKhachHang.ValueMember = "makhachhang";

            cmbNhanVien.DataSource = nvblo.getAll();
            cmbNhanVien.DisplayMember = "tennhanvien";
            cmbNhanVien.ValueMember = "Manhanvien";

            cmbTenHang.DataSource = hangblo.getAll();
            cmbTenHang.DisplayMember = "tenhang";
            cmbTenHang.ValueMember = "mahang";
            txtGiaBan.Text = hangblo.layGiaBan(cmbTenHang.SelectedValue.ToString()).ToString();
        }

        void lockbutton(bool an)
        {
            btThem.Enabled = an;
            btSua.Enabled = an;
            btXoa.Enabled = an;
            btLuu.Enabled = !an;
            btHuy.Enabled = !an;
            btIn.Enabled = an;
        }

        void gandl()
        {
            gridControl1.DataSource = xuatblo.getAll(txtMaHoaDon.Text);
            gridControl1.Refresh();
        }

        void locktext(bool an)
        {

            txtMaHoaDon.Enabled = false;
            cmbNgayXuat.Enabled = an;
            cmbNhanVien.Enabled = an;
            txtSoLuong.Enabled = an;
            txtGiaBan.Enabled = false;
            cmbTenHang.Enabled = an;
            cmbTenHang.Enabled = an;
            cmbKhachHang.Enabled = an;
            txtThue.Enabled = an;
        }

        private void LuuPhieuXuat()
        {
                PhieuXuat px = new PhieuXuat();
                px.MaPX = txtMaHoaDon.Text;
                px.MaNV = cmbNhanVien.SelectedValue.ToString();
                px.MaKH = cmbKhachHang.SelectedValue.ToString();
                px.Ngayxuat = cmbNgayXuat.Text;
                if (!xuatblo.insertPX(px))
                {
                    MessageBox.Show("Mã Phiếu Xuất Này Đã Tồn Tại", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
        }


        private void btLuu_Click(object sender, EventArgs e)
        {

            LuuPhieuXuat();

            if (txtGiaBan.Text == "")
                MessageBox.Show("Vui Lòng Nhập Đơn Giá", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtSoLuong.Text == "")
                MessageBox.Show("Vui Lòng Nhập Số Lượng", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtThue.Text == "")
                MessageBox.Show("Vui Lòng Nhập Thuế", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                bool dk = true;
                ChiTietPhieuXuat px = new ChiTietPhieuXuat();
                px.MaPX = txtMaHoaDon.Text;
                px.MaHang = cmbTenHang.SelectedValue.ToString();
                try
                {
                    px.SoLuong = Convert.ToInt16(txtSoLuong.Text);
                    px.DonGia = Convert.ToInt64(txtGiaBan.Text);
                    px.Thue = float.Parse(txtThue.Text);
                }
                catch
                {
                    dk = false;
                }
                if (dk == false)
                {
                    MessageBox.Show("Các ô Số Lượng,Thuế Và Đơn Giá Phải Là Kiểu Số", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (px.Thue < 0)
                    MessageBox.Show("Tiền Thuế Không Được Nhỏ Hơn 0", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (px.SoLuong < 0)
                    MessageBox.Show("Số Lượng Không Được Nhỏ Hơn 0", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (px.DonGia < 0)
                    MessageBox.Show("Đơn Giá Không Được Nhỏ Hơn 0", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    int sl = hangblo.soluong(cmbTenHang.SelectedValue.ToString());
                    if (sl < int.Parse(txtSoLuong.Text))
                    {
                        MessageBox.Show("Lượng Hàng Trong Kho Không Đủ Để Xuất", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (kt == true)
                        {

                            if (!xuatblo.insertCTPX(px))
                                MessageBox.Show("Hàng Này Đã Có Trong Hóa Đơn Này Rồi", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                            {
                                MessageBox.Show("Xuất Hàng Vào Hóa Đơn Thành Công", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                gandl();
                               lockbutton(true);
                               locktext(false);
                            }
                        }
                        else
                        {
                            if (!xuatblo.updateCTPX(px, txtMaHoaDon.Text, cmbTenHang.SelectedValue.ToString()))
                                MessageBox.Show(xuatblo.Error, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                            {
                                gandl();
                                MessageBox.Show("Sửa Hàng Trong Hóa Đơn Thành Công", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               lockbutton(true);
                                locktext(false);
                            }
                        }
                    }

                }
            }
            
        }

        private void UC_XuatHang_Load(object sender, EventArgs e)
        {
            load();
            lockbutton(false);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
           // txtMaHoaDon.Text = xuatblo.NextID();

            kt = true;
            locktext(true);
            cmbTenHang.SelectedIndex = 0;
            txtSoLuong.Text = "";
            txtThue.Text = "";
            txtGiaBan.Enabled = false;
            cmbKhachHang.Enabled = false;
            cmbNgayXuat.Enabled = false;
            cmbNhanVien.Enabled = false;
            lockbutton(false);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
             kt = false;
            cmbNgayXuat.Enabled = false;
            cmbNhanVien.Enabled = false;
            txtSoLuong.Enabled = true;
            txtGiaBan.Enabled = false;
            cmbTenHang.Enabled = false;
            cmbTenHang.Enabled = false;
            txtThue.Enabled = true;
            txtSoLuong.Focus();
            lockbutton(false);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
             DialogResult h = new DialogResult();
            h = MessageBox.Show("Bạn Có Chắc Muốn Xóa Hàng Này Ra Khỏi Hóa Đơn Không", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h.ToString() == "OK")
            {
                if (!xuatblo.deleteCTPX(txtMaHoaDon.Text, cmbTenHang.SelectedValue.ToString()))
                {
                    MessageBox.Show(hangblo.Error, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã Xóa Thành Công", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }            
            }            
            gandl();
        }

        private void cmbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGiaBan.Text = hangblo.layGiaBan(cmbTenHang.SelectedValue.ToString()).ToString();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
           

            In_HoaDonXuat HD = new In_HoaDonXuat(txtMaHoaDon.Text);
            //HD = frmMain.ActiveForm;
            HD.Show();
        }

      
        }
        }
    
