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
    public partial class UC_QLXuatHang : UserControl
    {
        public UC_QLXuatHang()
        {
            InitializeComponent();
        }

        QLXuatHang_Mod xuatblo = new QLXuatHang_Mod();
        NhanVien_Mod nvblo = new NhanVien_Mod();
        KhachHang_Mod khblo = new KhachHang_Mod();
        XeMay_Mod hangblo = new XeMay_Mod();
        ChiTietPhieuXuat luuvet = new ChiTietPhieuXuat();
        PhieuXuat px = new PhieuXuat();
        Xulychuyendoiso xls = new Xulychuyendoiso();

        bool kt = true;

        void lockbutton(bool an)
        {
            btThem.Enabled = an;
            btSua.Enabled = an;
            btXoa.Enabled = an;
            btLuu.Enabled = !an;
            btHuy.Enabled = !an;
            btIn.Enabled = an;
        }


        void locktext(bool an)
        {
            
            txtMaHD.Enabled = false;
            cmbngayxuat.Enabled = an;
            cmbtenkhachhang.Enabled = an;
            txtSoLuong.Enabled = an;
            txtDonGia.Enabled = an;
            cmbTenHang.Enabled = an;
            cmbtennhanvien.Enabled = an;
            txtThue.Enabled = an;
          //  txtDonGia.Enabled = false;
            
        }
        
          private void UC_QLXuatHang_Load(object sender, EventArgs e)
        {
             // lockbutton(false);

            gridControl_qlnh.DataSource = xuatblo.getAll();
             binding();
             gridControl_qlnh.Refresh();

             // txtMaHD.Enabled = false;
             // txtMaHD.Text = nhapblo.NextID();

             cmbngayxuat.Text = DateTime.Today.ToShortDateString();
             cmbtenkhachhang.DataSource = khblo.getAll();
             cmbtenkhachhang.DisplayMember = "tenkhachhang";
             cmbtenkhachhang.ValueMember = "makhachhang";

             cmbtennhanvien.DataSource = nvblo.getAll();
             cmbtennhanvien.DisplayMember = "tennhanvien";
             cmbtennhanvien.ValueMember = "Manhanvien";

             cmbTenHang.DataSource = hangblo.getAll();
             cmbTenHang.DisplayMember = "tenhang";
             cmbTenHang.ValueMember = "mahang";
             txtDonGia.Text = hangblo.layGiaBan(cmbTenHang.SelectedValue.ToString()).ToString();

             double a = Convert.ToDouble(txt_tongtienthanhtoan.Text);
             text_chusotien.Text = xls.So_chu(a);
        }

        private void binding()
        {
            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text", gridControl_qlnh.DataSource, "Mapx");
            cmbngayxuat.DataBindings.Clear();
            cmbngayxuat.DataBindings.Add("Text", gridControl_qlnh.DataSource, "ngayxuat");
            cmbtenkhachhang.DataBindings.Clear();
            cmbtenkhachhang.DataBindings.Add("Text", gridControl_qlnh.DataSource, "tennhanvien");
            cmbtenkhachhang.DataBindings.Clear();
            cmbtenkhachhang.DataBindings.Add("Text", gridControl_qlnh.DataSource, "tenkhachhang");
            cmbTenHang.DataBindings.Clear();
            cmbTenHang.DataBindings.Add("Text", gridControl_qlnh.DataSource, "tenhang");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", gridControl_qlnh.DataSource, "slxuat");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", gridControl_qlnh.DataSource, "dongiaxuat");
            txtThue.DataBindings.Clear();
            txtThue.DataBindings.Add("Text", gridControl_qlnh.DataSource, "thue");
            txt_tongtienthanhtoan.DataBindings.Clear();
            txt_tongtienthanhtoan.DataBindings.Add("Text", gridControl_qlnh.DataSource, "thanhtien");

            }  
    
        
        private void btThem_Click(object sender, EventArgs e)
        {
           // txtMaHD.Text = nhapblo.NextID();

            cmbngayxuat.Enabled = false;
            cmbtennhanvien.Enabled = false;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
            cmbTenHang.Enabled = true;
            cmbtenkhachhang.Enabled = false;
            txtThue.Enabled = true;
            kt = true;
          
           cmbTenHang.SelectedIndex = 0;
            txtSoLuong.Text ="";
           txtDonGia.Text = "";
            txtThue.Text="";
           // lockbutton(false);
         
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            kt = false;
            cmbngayxuat.Enabled = false;
            cmbtennhanvien.Enabled = false;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
            cmbTenHang.Enabled = false;
            cmbtenkhachhang.Enabled = false;
            txtThue.Enabled = true;

           txtDonGia.Focus();
          // lockbutton(false);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = new DialogResult();
            h = MessageBox.Show("Bạn Có Chắc Muốn Xóa Hàng Này Ra Khỏi Hóa Đơn Không", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h.ToString() == "OK")
            {
                if (!xuatblo.deleteCTPX(txtMaHD.Text, cmbTenHang.SelectedValue.ToString()))
                {
                    MessageBox.Show(hangblo.Error, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    
                    MessageBox.Show("Đã Xóa Thành Công", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            UC_QLXuatHang_Load(sender, e);
        }

        public void LuuPhieuXuat()
        {
            PhieuXuat px = new PhieuXuat();
            px.MaPX = txtMaHD.Text;
            px.MaNV = cmbtennhanvien.SelectedValue.ToString();
            px.MaKH = cmbtenkhachhang.SelectedValue.ToString();
            px.Ngayxuat = cmbngayxuat.Text;
            if (!xuatblo.insertPX(px))
            {
                MessageBox.Show("Mã Phiếu Xuất Này Đã Tồn Tại", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            LuuPhieuXuat();

            if (txtDonGia.Text == "")
                MessageBox.Show("Vui Lòng Nhập Đơn Giá", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtSoLuong.Text == "")
                MessageBox.Show("Vui Lòng Nhập Số Lượng", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtThue.Text == "")
                MessageBox.Show("Vui Lòng Nhập Thuế", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                bool dk = true;
                ChiTietPhieuXuat ct = new ChiTietPhieuXuat();
                ct.MaPX = txtMaHD.Text;
                ct.MaHang = cmbTenHang.SelectedValue.ToString();
                try
                {
                    ct.SoLuong = Convert.ToInt16(txtSoLuong.Text);
                    ct.DonGia = Convert.ToInt64(txtDonGia.Text);
                    ct.Thue = float.Parse(txtThue.Text);
                }
                catch
                {
                    dk = false;
                }
                if (dk == false)
                {
                    MessageBox.Show("Các ô Số Lượng,Thuế Và Đơn Giá Phải Là Kiểu Số", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ct.Thue < 0)
                    MessageBox.Show("Tiền Thuế Không Được Nhỏ Hơn 0", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (ct.SoLuong < 0)
                    MessageBox.Show("Số Lượng Không Được Nhỏ Hơn 0", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (ct.DonGia < 0)
                    MessageBox.Show("Đơn Giá Không Được Nhỏ Hơn 0", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (Convert.ToInt64(txtDonGia.Text) > hangblo.layGiaBan(cmbTenHang.SelectedValue.ToString()))
                    {
                        DialogResult h = MessageBox.Show("Giá Nhập Lớn Hơn Giá Bán Hiện Thời, Bạn Có Chắc Muốn Nhập Không?", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (h.ToString() == "OK")
                        {
                            if (kt == true)
                            {
                                if (!xuatblo.insertCTPX(ct))
                                    MessageBox.Show("Hàng Này Đã Có Trong Hóa Đơn Này Rồi", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                {
                                    MessageBox.Show("Nhập Hàng Vào Hóa Đơn Thành Công", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    UC_QLXuatHang_Load(sender, e);
                                    lockbutton(true);
                                    locktext(false);
                                }
                            }
                            else
                            {
                                if (!xuatblo.updateCTPX(ct, txtMaHD.Text, cmbTenHang.SelectedValue.ToString()))
                                    MessageBox.Show(xuatblo.Error, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                {
                                    UC_QLXuatHang_Load(sender, e);
                                    MessageBox.Show("Sửa Hàng Trong Hóa Đơn Thành Công", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    lockbutton(true);
                                    locktext(false);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (kt == true)
                        {
                            if (!xuatblo.insertCTPX(ct))
                                MessageBox.Show("Hàng Này Đã Có Trong Hóa Đơn Này Rồi", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                            {
                                MessageBox.Show("Nhập Hàng Vào Hóa Đơn Thành Công", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UC_QLXuatHang_Load(sender, e);
                                lockbutton(true);
                                locktext(false);
                            }
                        }
                        else
                        {
                            if (!xuatblo.updateCTPX(ct, txtMaHD.Text, cmbTenHang.SelectedValue.ToString()))
                                MessageBox.Show(xuatblo.Error, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                            {
                                UC_QLXuatHang_Load(sender, e);
                                MessageBox.Show("Sửa Hàng Trong Hóa Đơn Thành Công", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                lockbutton(true);
                                locktext(false);
                            }
                        }
                    }

                }
            }
        }
               

        private void btHuy_Click(object sender, EventArgs e)
        {
            UC_QLXuatHang_Load(sender, e);
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            
            In_HoaDonXuat HD = new In_HoaDonXuat(txtMaHD.Text);
            HD.Show();
        }

        private void txt_tongtienthanhtoan_EditValueChanged(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_tongtienthanhtoan.Text);
            string b = xls.So_chu(a);
            text_chusotien.Text = b;



        }

        
        }

    }
