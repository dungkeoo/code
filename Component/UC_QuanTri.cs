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
    public partial class UC_QuanTri : UserControl
    {
        public UC_QuanTri()
        {
            InitializeComponent();
        }

        bool kt = true;
        QuanTri_Mod blo = new QuanTri_Mod();

        void locktext(bool an)
        {
            txtTaiKhoan.Enabled = an;
            txtMatKhau.Enabled = an;
            txtDiaChi.Enabled = an;
            txtPhone.Enabled = an;
            txtEmail.Enabled = an;
            cmbQuyen.Enabled = an;
        }

        void lockbutton(bool an)
        {
            btThem.Enabled = an;
            btSua.Enabled = an;
            btXoa.Enabled = an;
            btIn.Enabled = an;
            btLuu.Enabled = !an;
            btHuy.Enabled = !an;
        }

        private void binding()
        {
            txtTaiKhoan.DataBindings.Clear();
            txtTaiKhoan.DataBindings.Add("Text", gridControl_DanhSachTK.DataSource, "Taikhoan");
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", gridControl_DanhSachTK.DataSource, "MatKhau");
            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add("Text", gridControl_DanhSachTK.DataSource, "DienThoai");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", gridControl_DanhSachTK.DataSource, "DiaChi");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", gridControl_DanhSachTK.DataSource, "Email");
            cmbQuyen.DataBindings.Clear();
            cmbQuyen.DataBindings.Add("Text", gridControl_DanhSachTK.DataSource, "Quyen");
            

        }

        private void UC_QuanTri_Load(object sender, EventArgs e)

        {
            gridControl_DanhSachTK.DataSource = blo.getAll();
            binding();
            locktext(false);
            lockbutton(true);
            rdbTimTheoNhaSanXuat.Checked = true;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
                MessageBox.Show("Hãy Nhập Tên Tài Khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtMatKhau.Text == "")
                MessageBox.Show("Hãy Nhập Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtPhone.Text == "")
                MessageBox.Show("Hãy Nhập Điện Thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtDiaChi.Text == "")
                MessageBox.Show("Hãy Nhập Địa Chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                bool a = true;
                TaiKhoan tk = new TaiKhoan();
                tk.TenTK = txtTaiKhoan.Text;
                tk.MatKhau = txtMatKhau.Text;
                tk.Diachi = txtDiaChi.Text;
                try
                {
                    tk.Dienthoai = Convert.ToInt64(txtPhone.Text);
                }
                catch
                {
                    a = false;
                }
                tk.Email = txtEmail.Text;
                tk.QuyenDN = cmbQuyen.Text;
                if (a == false)
                {
                    MessageBox.Show("Số Điện Thoại Chưa Đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (kt == true)
                    {
                        if (!blo.insertTK(tk))
                            MessageBox.Show("Tên Tài Khoản Này Đã Tồn Tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            MessageBox.Show("Đã Thêm Tài Khoản Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         
                            UC_QuanTri_Load(sender, e);
                        }
                    }
                    else
                    {
                        if (!blo.updateTK(tk, txtTaiKhoan.Text, txtMatKhau.Text))
                            MessageBox.Show(blo.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            MessageBox.Show("Đã Sửa Tài Khoản Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           UC_QuanTri_Load(sender, e);
                        }
                    }
                }
            }
        }

    
        private void clear()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtDiaChi.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
           
        }
        
        private void btThem_Click(object sender, EventArgs e)
        {
            kt = true;
            locktext(true);
            clear();
            txtTaiKhoan.Focus();
            lockbutton(false);
        }

        

        private void btSua_Click(object sender, EventArgs e)
        {
            kt = false;
            locktext(true);                     
            txtDiaChi.Focus();
            lockbutton(false);
            txtTaiKhoan.Enabled = false;
            txtMatKhau.Enabled = false;
                      
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn Có Thực Sự Muốn Xóa Tài Khoản Này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h.ToString() == "OK")
            {
                if (!blo.deleteTK(txtTaiKhoan.Text))
                    MessageBox.Show(blo.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Đã Xóa Tài Khoản Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            UC_QuanTri_Load(sender, e);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            UC_QuanTri_Load(sender, e);
        }

        private void txtTimTheoTen_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachTK.DataSource = blo.searchTen(txt_TimTheoTen.Text);
            binding();
        }

        private void txt_TimTheoDiaChi_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachTK.DataSource = blo.searchDiaChi(txt_TimTheoDiaChi.Text);
            binding();
        }

        private void txt_TimTheoEmail_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachTK.DataSource = blo.searchEmail(txt_TimTheoEmail.Text);
             binding();
        }
    }
}
