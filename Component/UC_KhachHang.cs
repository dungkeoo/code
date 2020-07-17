using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project.Bussiness;
using Project.Controller;

namespace Project.Component
{
    public partial class UC_KhachHang : UserControl
    {
        public UC_KhachHang()
        {
            InitializeComponent();
        }

        public DataTable tb;
        KhachHang_Mod blo = new KhachHang_Mod();
        bool kt = true;
        KhachHang luuvet = new KhachHang();

        
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
            txtMaKhachHang.Enabled = false;
            txtTenKhachHang.Enabled = an;
            txtDiaChi.Enabled = an;
            txtPhone.Enabled = an;
            txtEmail.Enabled = an;

        }

        private void binding()
        {
            txtMaKhachHang.DataBindings.Clear();
            txtMaKhachHang.DataBindings.Add("Text", gridControl_DanhSachKhachHang.DataSource, "MAKHACHHANG");
            txtTenKhachHang.DataBindings.Clear();
            txtTenKhachHang.DataBindings.Add("Text", gridControl_DanhSachKhachHang.DataSource, "TENKHACHHANG");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", gridControl_DanhSachKhachHang.DataSource, "DIACHI");
            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add("Text", gridControl_DanhSachKhachHang.DataSource, "DIENTHOAI");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", gridControl_DanhSachKhachHang.DataSource, "EMAIL");
          
        }

        void cleartext()
        {
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";

        }

        private void UC_KhachHang_Load(object sender, EventArgs e)
        {
            gridControl_DanhSachKhachHang.DataSource = blo.getAll();
            binding();
            lockbutton(true);
            locktext(false);
            rdbTimTheoMaKH.Checked = true;
          
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            locktext(true);
            cleartext();
            txtMaKhachHang.Text = blo.NextID();
            txtTenKhachHang.Focus();
            kt = true;
            lockbutton(false);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            locktext(true);
            txtMaKhachHang.Enabled = false;
            txtTenKhachHang.Focus();
            kt = false;
            lockbutton(false);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = new DialogResult();
            h = MessageBox.Show("Ban Co Chac Muon Xoa Khach Hang " + txtMaKhachHang.Text + " ra khoi danh sach", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h.ToString() == "OK")
            {
                if (!blo.deleteKH(txtMaKhachHang.Text))
                {
                    MessageBox.Show(blo.Error, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Da Xoa Thanh Cong Khach Hang " + txtTenKhachHang.Text, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            KhachHang_Load();
        }

        private void KhachHang_Load()
        {
            gridControl_DanhSachKhachHang.DataSource = blo.getAll();
            binding();
            lockbutton(true);
            locktext(false);
            rdbTimTheoTenKH.Checked = true;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            KhachHang khach = new KhachHang();
            if (kt == true)
            {
                if (txtMaKhachHang.Text == "")
                    MessageBox.Show("Khong Duoc Bo Trong Ma Khach", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (txtTenKhachHang.Text == "")
                    MessageBox.Show("Khong Duoc Bo Trong Ten Khach", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (txtDiaChi.Text == "")
                    MessageBox.Show("Khong Duoc Bo Trong Dia Chi Khach", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (txtPhone.Text == "")
                    MessageBox.Show("Khong Duoc Bo Trong Dien Thoai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    bool kt1 = true;
                    khach.MaKH = txtMaKhachHang.Text;
                    khach.TenKH = txtTenKhachHang.Text;
                    khach.DiaChi = txtDiaChi.Text;
                    try
                    {
                        khach.DienThoai = Convert.ToInt64(txtPhone.Text);
                    }
                    catch
                    {
                        kt1 = false;
                    }
                    khach.Email = txtEmail.Text;
                    if (kt1 == false)
                        MessageBox.Show("Du Lieu Nhap Vao O So Dien Thoai Chua Dung", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        if (!blo.insertKH(khach))
                        {
                            MessageBox.Show("Ma Khach Hang Nay Da Ton Tai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Them Khach Hang Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           KhachHang_Load();

                        }
                }
            }
            else
            {
                if (txtMaKhachHang.Text == "")
                    MessageBox.Show("Khong Duoc Bo Trong Ma Khach", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (txtTenKhachHang.Text == "")
                    MessageBox.Show("Khong Duoc Bo Trong Ten Khach", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (txtDiaChi.Text == "")
                    MessageBox.Show("Khong Duoc Bo Trong Dia Chi Khach", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (txtPhone.Text == "")
                    MessageBox.Show("Khong Duoc Bo Trong Dien Thoai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    bool kt1 = true;
                    khach.TenKH = txtTenKhachHang.Text;
                    khach.DiaChi = txtDiaChi.Text;
                    try
                    {
                        khach.DienThoai = Convert.ToInt64(txtPhone.Text);
                    }
                    catch
                    {
                        kt1 = false;
                    }
                    khach.Email = txtEmail.Text;
                    if (kt1 == false)
                        MessageBox.Show("Du Lieu Nhap Vao O So Dien Thoai Chua Dung", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        if (blo.updateKH(khach, txtMaKhachHang.Text))
                        {
                            MessageBox.Show("Sua Thong Tin Khach Hang Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KhachHang_Load();

                        }
                        else
                        {
                            MessageBox.Show(blo.Error, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            KhachHang_Load();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.InKhachHang();
            f.Show();

        }

        private void txt_TimTheoMaKH_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachKhachHang.DataSource = blo.searchMaKH(txt_TimTheoMaKH.Text);
            binding();
        }

        private void txt_TimTheoTenKH_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachKhachHang.DataSource = blo.searchTenKH(txt_TimTheoTenKH.Text);
            binding();
        }

        private void txt_TimTheoDiaChiKH_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachKhachHang.DataSource = blo.searchDiaChi(txt_TimTheoDiaChiKH.Text);
            binding();
        }

        
    }
}
