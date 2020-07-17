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
    public partial class UC_QLNhapHang : UserControl
    {
        public UC_QLNhapHang()
        {
            InitializeComponent();
        }

        QLNhapHang_Mod nhapblo = new QLNhapHang_Mod();
        NhanVien_Mod nvblo = new NhanVien_Mod();
        NhaCungCap_Mod nccblo = new NhaCungCap_Mod();
        XeMay_Mod hangblo = new XeMay_Mod();
        ChiTietPhieuNhap luuvet = new ChiTietPhieuNhap();
        PhieuNhap pn = new PhieuNhap();
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
            cmbNgayNhap.Enabled = an;
            cmbNhaCungCap.Enabled = an;
            txtSoLuong.Enabled = an;
            txtDonGia.Enabled = an;
            cmbTenHang.Enabled = an;
            cmbTenNhanVien.Enabled = an;
            txtThue.Enabled = an;
        }
        
          private void UC_QLNhapHang_Load(object sender, EventArgs e)
        {
             // lockbutton(false);

             gridControl_qlnh.DataSource = nhapblo.GetAll();
             binding();
             txt_tongtienthanhtoan_TextChanged(sender, e);
             gridControl_qlnh.Refresh();

             // txtMaHD.Enabled = false;
             //   txtMaHD.Text = nhapblo.NextID();

          
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

            // double a = Convert.ToDouble(txt_tongtienthanhtoan.Text);
            // text_chusotien.Text = xls.So_chu(a);

        }

        private void binding()
        {
            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text", gridControl_qlnh.DataSource, "Mapn");
            cmbNgayNhap.DataBindings.Clear();
            cmbNgayNhap.DataBindings.Add("Text", gridControl_qlnh.DataSource, "ngaynhap");
            cmbTenNhanVien.DataBindings.Clear();
            cmbTenNhanVien.DataBindings.Add("Text", gridControl_qlnh.DataSource, "tennhanvien");
            cmbNhaCungCap.DataBindings.Clear();
            cmbNhaCungCap.DataBindings.Add("Text", gridControl_qlnh.DataSource, "tennhacungcap");
            cmbTenHang.DataBindings.Clear();
            cmbTenHang.DataBindings.Add("Text", gridControl_qlnh.DataSource, "tenhang");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", gridControl_qlnh.DataSource, "slnhap");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", gridControl_qlnh.DataSource, "dongianhap");
            txtThue.DataBindings.Clear();
            txtThue.DataBindings.Add("Text", gridControl_qlnh.DataSource, "thue");
            txt_tongtienthanhtoan.DataBindings.Clear();
            txt_tongtienthanhtoan.DataBindings.Add("Text", gridControl_qlnh.DataSource, "thanhtien");
            text_chusotien.DataBindings.Clear();
            
          
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
           // lockbutton(false);
         
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
          // lockbutton(false);
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
            UC_QLNhapHang_Load(sender, e);
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
                                    UC_QLNhapHang_Load(sender, e);
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
                                    UC_QLNhapHang_Load(sender, e);
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
                                UC_QLNhapHang_Load(sender, e);
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
                                UC_QLNhapHang_Load(sender, e);
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
            UC_QLNhapHang_Load(sender, e);
        }

        private void btIn_Click(object sender, EventArgs e)
        {
           

            In_HoaDonNhap HD = new In_HoaDonNhap(txtMaHD.Text);
            //HD = frmMain.ActiveForm;
            HD.Show();


        }

     

        private void txt_tongtienthanhtoan_TextChanged(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_tongtienthanhtoan.Text);
            string b = xls.So_chu(a);
            text_chusotien.Text = b;
        }

        
        }

    }
