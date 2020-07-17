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

namespace Project.Component
{
    public partial class UC_XeMay : UserControl
    {
        public UC_XeMay()
        {
            InitializeComponent();
        }
        
        bool kt = true;
        XeMay_Mod xm = new XeMay_Mod();
        XeMay hang = new XeMay();
        private void binding()
        {
            txtMaLoaiXeMay.DataBindings.Clear();
            txtMaLoaiXeMay.DataBindings.Add("Text", gridControl_DanhSachXM.DataSource, "MAHANG");
            txtTenLoaiXeMay.DataBindings.Clear();
            txtTenLoaiXeMay.DataBindings.Add("Text", gridControl_DanhSachXM.DataSource, "TENHANG");
            txtNhaSanXuat.DataBindings.Clear();
            txtNhaSanXuat.DataBindings.Add("Text", gridControl_DanhSachXM.DataSource, "NHASX");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", gridControl_DanhSachXM.DataSource, "SOLUONG");
            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("Text", gridControl_DanhSachXM.DataSource, "DGBAN");
            txtBaoHanh.DataBindings.Clear();
            txtBaoHanh.DataBindings.Add("Text", gridControl_DanhSachXM.DataSource, "THONGTINBAOHANH");
            txtDonViTinh.DataBindings.Clear();
            txtDonViTinh.DataBindings.Add("Text", gridControl_DanhSachXM.DataSource, "DONVITINH");
            txtMauSac.DataBindings.Clear();
            txtMauSac.DataBindings.Add("Text", gridControl_DanhSachXM.DataSource, "MOTA");
           
           
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
            txtMaLoaiXeMay.Enabled = false;
            txtTenLoaiXeMay.Enabled = an;
            txtSoLuong.Visible = false;
            txtGiaBan.Enabled = an;
            txtDonViTinh.Enabled = an;
            txtNhaSanXuat.Enabled = an;
            txtBaoHanh.Enabled = an;
            txtMauSac.Enabled = an;
            labelControl5.Visible = false;
        }

        private void UC_XeMay_Load(object sender, EventArgs e)
        {

                 gridControl_DanhSachXM.DataSource = xm.getAll();
                 binding();
                 lockbutton(true);
                 locktext(false);
                 rdbTimTheoNhaSanXuat.Checked = true;
                
           
        }

        void cleartext()
        {
            txtMauSac.Text = "";
            txtNhaSanXuat.Text = "";
            txtSoLuong.Text = "0";
            txtGiaBan.Text = "";
            txtBaoHanh.Text = "";
            txtDonViTinh.Text = "";
            txtTenLoaiXeMay.Text = "";
           
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            kt = true;
            cleartext();
            locktext(true);
            lockbutton(false);
            txtMaLoaiXeMay.Text = xm.NextID();
            txtSoLuong.Text = "0";
           
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            kt = false;
            locktext(true);
            lockbutton(false);
            txtTenLoaiXeMay.Focus();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = new DialogResult();
            h = MessageBox.Show("Bạn Có Chắc Muốn Xóa Hàng " + txtMaLoaiXeMay.Text + " ra khỏi danh sách", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h.ToString() == "OK")
            {
                if (!xm.deleteHang(txtMaLoaiXeMay.Text))
                {
                    MessageBox.Show(xm.Error, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           UC_XeMay_Load();

        }

        private void UC_XeMay_Load()
        {
            gridControl_DanhSachXM.DataSource = xm.getAll();
            binding();
            lockbutton(true);
            locktext(false);
           
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            
            if (kt == true)
            {
                if (txtMaLoaiXeMay.Text == "")
                    MessageBox.Show("Không được bỏ trống mã hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (txtTenLoaiXeMay.Text == "")
                    MessageBox.Show("Không được bỏ trống tên hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (txtNhaSanXuat.Text == "")
                    MessageBox.Show("Không được bỏ trống tên nhà sản xuất", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (txtSoLuong.Text == "")
                    MessageBox.Show("Không được bỏ trống số lượng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    bool kt1 = true;
                    hang.MaHang = txtMaLoaiXeMay.Text;
                    hang.TenHang = txtTenLoaiXeMay.Text;
                    hang.NhaSX = txtNhaSanXuat.Text;
                    try
                    {
                        hang.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                        hang.Gia = Convert.ToInt64(txtGiaBan.Text);
                    }
                    catch
                    {
                        kt1 = false;
                    }
                    hang.BaoHanh = txtBaoHanh.Text;
                    hang.DvTinh = txtDonViTinh.Text;
                    hang.MoTa = txtMauSac.Text;
                    if (kt1 == false)
                        MessageBox.Show("Dữ liệu nhập vào ô số lượng hoặc giá bán Chưa Đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        if (!xm.insertHang(hang))
                        {
                            MessageBox.Show("Mã hàng này đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Them Hang Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UC_XeMay_Load();
                        }
                }
            }
            else
            {
                if (txtTenLoaiXeMay.Text == "")
                    MessageBox.Show("Không được bỏ trống tên hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (txtNhaSanXuat.Text == "")
                    MessageBox.Show("Không được bỏ trống nhà sản xuất", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (txtSoLuong.Text == "")
                    MessageBox.Show("Không được bỏ trống số lượng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    bool kt1 = true;
                    hang.TenHang = txtTenLoaiXeMay.Text;
                    hang.NhaSX = txtNhaSanXuat.Text;
                    try
                    {
                        hang.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                        hang.Gia = Convert.ToInt64(txtGiaBan.Text);
                    }
                    catch
                    {
                        kt1 = false;
                    }
                    hang.BaoHanh = txtBaoHanh.Text;
                    hang.DvTinh = txtDonViTinh.Text;
                    hang.MoTa = txtMauSac.Text;
                    if (kt1 == false)
                        MessageBox.Show("Dữ liệu nhập vào ô số lượng hoặc giá bán chưa đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        if (xm.updateHang(hang, txtMaLoaiXeMay.Text))
                        {
                            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UC_XeMay_Load();
                        }
                        else
                        {
                            MessageBox.Show(xm.Error, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }

            
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
          UC_XeMay_Load();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.InDanhSachXeMay();
            f.Show();
        }

        private void txtTimTheoNhaSanXuat_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachXM.DataSource = xm.searchNhaSanXuat(txt_TimTheoNhaSanXuat.Text);
            binding();
        }

        private void txtTimTheoTenXeMay_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachXM.DataSource = xm.searchTenXe(txt_TimTheoTenXeMay.Text);
            binding();
        }

        private void txtTimTheoMaLoaiXe_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachXM.DataSource = xm.searchMaLoaiXe(txt_TimTheoMaLoaiXe.Text);
            binding();
        }
          

    }
}
