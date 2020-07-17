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
    public partial class UC_NhapHang : UserControl
    {
        public UC_NhapHang()
        {
            InitializeComponent();
        }

        NhapHang_Mod nhapblo = new NhapHang_Mod();
        NhanVien_Mod nvblo = new NhanVien_Mod();
        NhaCungCap_Mod nccblo = new NhaCungCap_Mod();
        XeMay_Mod hangblo = new XeMay_Mod();
        ChiTietPhieuNhap luuvet = new ChiTietPhieuNhap();
        PhieuNhap pn = new PhieuNhap();

        bool kt = true;

        void load()
        {


            gridControl3.DataSource = nhapblo.GetAll(txtMaHD.Text);
            gridControl3.Refresh();

            txtMaHD.Enabled = false;
            txtMaHD.Text = nhapblo.NextID();

           
            cmbNgayNhap.Text = DateTime.Today.ToShortDateString();

            cmbNhaCungCap.DataSource = nccblo.getAll();
            cmbNhaCungCap.DisplayMember = "tennhacungcap";
            cmbNhaCungCap.ValueMember = "manhacungcap";

            cmbTenNhanVien.DataSource = nvblo.getAll();
            cmbTenNhanVien.DisplayMember = "tennhanvien";
            cmbTenNhanVien.ValueMember = "Manhanvien";

            
            cmbTenHang.DataSource = hangblo.getAll();
           cmbTenHang.DisplayMember = "tenhang";
            cmbTenHang.ValueMember = "mahang";
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


        void locktext(bool an)
        {
            
            txtMaHD.Enabled = false;
            cmbNgayNhap.Enabled = an;
            cmbNhaCungCap.Enabled = an;
            txtSoLuong.Enabled = an;
            txtDonGia.Enabled = an;
            cmbTenHang.Enabled = an;
            cmbTenNhanVien.Enabled = an;
            txtThue.Enabled = an;

            
        }


        void gandl()
        {
          
            gridControl3.DataSource = nhapblo.GetAll(txtMaHD.Text);
            gridControl3.Refresh();
        }

        private void UC_NhapHang_Load(object sender, EventArgs e)
        {
             load();
             lockbutton(false);
           
        }

        private void btThem_Click(object sender, EventArgs e)
        {
           // txtMaHD.Text = nhapblo.NextID();


            cmbNgayNhap.Enabled = false;
            cmbNhaCungCap.Enabled = false;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
            cmbTenHang.Enabled = true;
            cmbTenNhanVien.Enabled = false;
            txtThue.Enabled = true;
            kt = true;
          
           cmbTenHang.SelectedIndex = 0;
            txtSoLuong.Text ="";
           txtDonGia.Text = "";
            txtThue.Text="";
            lockbutton(false);
         
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            kt = false;
            cmbNgayNhap.Enabled = false;
            cmbNhaCungCap.Enabled = false;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
            cmbTenHang.Enabled = false;
            cmbTenNhanVien.Enabled = false;
            txtThue.Enabled = true;

           txtDonGia.Focus();
           lockbutton(false);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = new DialogResult();
            h = MessageBox.Show("Bạn Có Chắc Muốn Xóa Hàng Này Ra Khỏi Hóa Đơn Không", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h.ToString() == "OK")
            {
                if (!nhapblo.deleteCTPN(txtMaHD.Text, cmbTenHang.SelectedValue.ToString()))
                {
                    MessageBox.Show(hangblo.Error, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Đã Xóa Thành Công", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            gandl();
        }

        public void LuuPhieuNhap()
        {
                PhieuNhap pn = new PhieuNhap();
                pn.MaPN = txtMaHD.Text;
                pn.NgayNhap = cmbNgayNhap.Text;
                pn.MaNV = cmbTenNhanVien.SelectedValue.ToString();
                pn.MaNCC = cmbNhaCungCap.SelectedValue.ToString();
                if (!nhapblo.insertPN(pn))
                {
                    MessageBox.Show("Mã Hóa Đơn Này Đã Tồn Tại", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    kt = true;
                }
            
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            LuuPhieuNhap();

            if (txtDonGia.Text == "")
                MessageBox.Show("Vui Lòng Nhập Đơn Giá", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtSoLuong.Text == "")
                MessageBox.Show("Vui Lòng Nhập Số Lượng", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtThue.Text == "")
                MessageBox.Show("Vui Lòng Nhập Thuế", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                bool dk = true;
                ChiTietPhieuNhap ct = new ChiTietPhieuNhap();
                ct.MaPN = txtMaHD.Text;
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
                                if (!nhapblo.insertCTPN(ct))
                                    MessageBox.Show("Hàng Này Đã Có Trong Hóa Đơn Này Rồi", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                {
                                    MessageBox.Show("Nhập Hàng Vào Hóa Đơn Thành Công", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    gandl();
                                    lockbutton(true);
                                    locktext(false);
                                }
                            }
                            else
                            {
                                if (!nhapblo.updateCTPN(ct, txtMaHD.Text, cmbTenHang.SelectedValue.ToString()))
                                    MessageBox.Show(nhapblo.Error, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    else
                    {
                        if (kt == true)
                        {
                            if (!nhapblo.insertCTPN(ct))
                                MessageBox.Show("Hàng Này Đã Có Trong Hóa Đơn Này Rồi", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                            {
                                MessageBox.Show("Nhập Hàng Vào Hóa Đơn Thành Công", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                gandl();
                                lockbutton(true);
                                locktext(false);
                            }
                        }
                        else
                        {
                            if (!nhapblo.updateCTPN(ct, txtMaHD.Text, cmbTenHang.SelectedValue.ToString()))
                                MessageBox.Show(nhapblo.Error, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

       

        private void btHuy_Click(object sender, EventArgs e)
        {
            UC_NhapHang_Load(sender, e);
        }

        private void btIn_Click(object sender, EventArgs e)
        {
           

            In_HoaDonNhap HD = new In_HoaDonNhap(txtMaHD.Text);
            //HD = frmMain.ActiveForm;
            HD.Show();
        }

        
        }

    }
