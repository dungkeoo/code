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
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
        }

        NhanVien_Mod blo = new NhanVien_Mod();
        bool kt = true;
        NhanVien luuvet = new NhanVien();

        private void binding()
        {
            txtMaNhanVien.DataBindings.Clear();
            txtMaNhanVien.DataBindings.Add("Text", gridControl_DanhSachNV.DataSource, "Manhanvien");
            txtTenNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Add("Text", gridControl_DanhSachNV.DataSource, "tennhanvien");
            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Text", gridControl_DanhSachNV.DataSource, "namsinh");
            Combobox_GioiTinh.DataBindings.Clear();
            Combobox_GioiTinh.DataBindings.Add("Text", gridControl_DanhSachNV.DataSource, "gioitinh");
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", gridControl_DanhSachNV.DataSource, "dienthoai");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", gridControl_DanhSachNV.DataSource, "diachi");
            Combobox_ChucVu.DataBindings.Clear();
            Combobox_ChucVu.DataBindings.Add("Text", gridControl_DanhSachNV.DataSource, "chucvu");
            txtLuong.DataBindings.Clear();
            txtLuong.DataBindings.Add("Text", gridControl_DanhSachNV.DataSource, "luongcoban");

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
            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = an;
            txtDiaChi.Enabled = an;
            txtDienThoai.Enabled = an;
            Combobox_ChucVu.Enabled = an;
            txtLuong.Enabled = an;
            txtNgaySinh.Enabled = an;
            Combobox_GioiTinh.Enabled = an;
        }
                
        void cleartext()
        {
            txtTenNhanVien.Text = "";
            txtDienThoai.Text = "";
            txtDienThoai.Text = "";
            Combobox_ChucVu.Text = "";
            txtLuong.Text = "";
            txtNgaySinh.Text = "";
            txtDiaChi.Text = "";
            Combobox_ChucVu.Text = "Ban Hang";
        }


        private void UC_NhanVien_Load(object sender, EventArgs e)
        {

            gridControl_DanhSachNV.DataSource = blo.getAll();
            binding();
            lockbutton(true);
            locktext(false);
            rdbTimTheoMaNhanVien.Checked = true;
            
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
           if (txtTenNhanVien.Text == "")
                MessageBox.Show("Không được bỏ trống tên nhân viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtNgaySinh.Text == "")
                MessageBox.Show("Không được bỏ trống năm sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtDienThoai.Text == "")
                MessageBox.Show("Không được bỏ trống số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtDiaChi.Text == "")
                MessageBox.Show("Không được bỏ trống địa chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
             else if (txtLuong.Text == "")
                MessageBox.Show("Không được bỏ trống lương nhân viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                bool kt1 = true;
                bool kt2 = true;
                bool kt3 = true;
                nv.MaNV = txtMaNhanVien.Text;
                nv.TenNV = txtTenNhanVien.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.ChucVu = Combobox_ChucVu.Text;
                nv.GioiTinh = Combobox_GioiTinh.Text;
                try
                {
                    nv.SoDT = Convert.ToInt64(txtDienThoai.Text);
                }
                catch
                {
                    kt1 = false;
                }


                try
                {
                    nv.Namsinh = txtNgaySinh.Text;
                }
                catch
                {
                    kt2 = false;
                }

                try
                {
                    nv.Luong = Convert.ToInt64(txtLuong.Text);
                }
                catch
                {
                    kt3 = false;
                }

                if (kt1 == false)
                    MessageBox.Show("Số điện thoại không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (kt2 == false)
                    MessageBox.Show("Năm sinh không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (kt3 == false)
                    MessageBox.Show("Giá trị nhập vào lương không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    if (kt == true)
                    {
                        if (!blo.insertNV(nv))
                        {
                            MessageBox.Show("Lỗi hệ thống, Không lưu được", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            NhanVien_Load();
                        }
                    }
                    else
                    {
                        if (!blo.updateNV(nv, txtMaNhanVien.Text))
                        {
                            MessageBox.Show(blo.Error, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sửa nhân viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            NhanVien_Load();
                        }
                    }

            }      
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            locktext(true);
            cleartext();
            txtMaNhanVien.Text = blo.NextID();
            txtTenNhanVien.Focus();
            kt = true;
            lockbutton(false);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            locktext(true);
            txtTenNhanVien.Focus();
            kt = false;
            lockbutton(false);
          
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = new DialogResult();
            h = MessageBox.Show("Bạn có chắc muốn xóa " + txtMaNhanVien.Text + " ra khỏi danh sách nhân viên", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h.ToString() == "OK")
            {
                if (!blo.deleteNV(txtMaNhanVien.Text))
                {
                    MessageBox.Show(blo.Error, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã xóa nhân viên thành công " + txtTenNhanVien.Text, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            NhanVien_Load();
        }

        private void NhanVien_Load()
        {
            gridControl_DanhSachNV.DataSource = blo.getAll();
            binding();
            lockbutton(true);
            locktext(false);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
                      
            NhanVien_Load();
         
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.InNhanVien();
            f.Show();
        }

        private void txt_TimTheoMaNV_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachNV.DataSource = blo.searchMa(txt_TimTheoMaNV.Text);
            binding();
        }

        private void txt_TimTheoTenNV_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachNV.DataSource = blo.searchTen(txt_TimTheoTenNV.Text);
            binding();
        }

        private void txt_TimTheoDiaChiNV_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachNV.DataSource = blo.searchDiaChi(txt_TimTheoDiaChiNV.Text);
            binding();
        }
           
    }
}
