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
    public partial class UC_NhaCungCap : UserControl
    {
        public UC_NhaCungCap()
        {
            InitializeComponent();
        }

        NhaCungCap luuvet = new NhaCungCap();
        bool kt = true;
        NhaCungCap_Mod   blo = new NhaCungCap_Mod();

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
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = an;
            txtDiaChi.Enabled = an;
            txtPhone.Enabled = an;
            txtEmail.Enabled = an;

        }

        private void binding()
        {
            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", gridControl_DoanhSachNCC.DataSource, "manhacungcap");
            txtTenNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Add("Text", gridControl_DoanhSachNCC.DataSource, "tennhacungcap");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", gridControl_DoanhSachNCC.DataSource, "Diachi");
            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add("Text", gridControl_DoanhSachNCC.DataSource, "Dienthoai");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", gridControl_DoanhSachNCC.DataSource, "Email");

        }

        void cleartext()
        {
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";

        }

        private void UC_NhaCungCap_Load(object sender, EventArgs e)
        {
            gridControl_DoanhSachNCC.DataSource = blo.getAll();
            binding();
            lockbutton(true);
            locktext(false);
            rdbTimTheoMaNCC.Checked = true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            locktext(true);
            cleartext();
            txtMaNCC.Text = blo.NextID();
            txtTenNCC.Focus();
            kt = true;
            lockbutton(false);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            locktext(true);
            txtMaNCC.Enabled = true;
            txtTenNCC.Focus();
            kt = false;
            lockbutton(false);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = new DialogResult();
            h = MessageBox.Show("Ban Co Chac Muon Xoa Nha Cung Cap " + txtMaNCC.Text + " ra khoi danh sach", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h.ToString() == "OK")
            {
                if (!blo.deleteNCC(txtMaNCC.Text))
                {
                    MessageBox.Show(blo.Error, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Da Xoa Thanh Cong Nha Cung Cap " + txtTenNCC.Text, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            NhaCungCap_Load(sender, e);
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            gridControl_DoanhSachNCC.DataSource = blo.getAll();
            binding();
            lockbutton(true);
            locktext(false);
            rdbTimTheoMaNCC.Checked = true;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            if (kt == true)
            {
                if (txtTenNCC.Text == "")
                    MessageBox.Show("Khong Duoc Bo Trong Ten Nha Cung Cap", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (txtDiaChi.Text == "")
                    MessageBox.Show("Khong Duoc Bo Trong Dia Chi Nha Cung Cap", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (txtPhone.Text == "")
                    MessageBox.Show("Khong Duoc Bo Trong Dien Thoai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    bool kt1 = true;
                    ncc.MaNCC = txtMaNCC.Text;
                    ncc.TenNCC = txtTenNCC.Text;
                    ncc.Diachi = txtDiaChi.Text;
                    try
                    {
                        ncc.DienThoai = Convert.ToInt64(txtPhone.Text);
                    }
                    catch
                    {
                        kt1 = false;
                    }
                    ncc.Email = txtEmail.Text;
                    if (kt1 == false)
                        MessageBox.Show("Du Lieu Nhap Vao O So Dien Thoai Chua Dung", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        if (!blo.insertNV(ncc))
                        {
                            MessageBox.Show("Ma Nha Cung Cap Nay Da Ton Tai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Them Nha Cung Cap Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           NhaCungCap_Load(sender, e);
                        }
                }
            }
            else
            {
               if (txtTenNCC.Text == "")
                    MessageBox.Show("Khong Duoc Bo Trong Ten Nha Cung Cap", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (txtDiaChi.Text == "")
                    MessageBox.Show("Khong Duoc Bo Trong Dia Chi Nha Cung Cap", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (txtPhone.Text == "")
                    MessageBox.Show("Khong Duoc Bo Trong Dien Thoai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    bool kt1 = true;
                    ncc.MaNCC = txtMaNCC.Text;
                    ncc.TenNCC = txtTenNCC.Text;
                    ncc.Diachi = txtDiaChi.Text;
                    try
                    {
                        ncc.DienThoai = Convert.ToInt64(txtPhone.Text);
                    }
                    catch
                    {
                        kt1 = false;
                    }
                    ncc.Email = txtEmail.Text;
                    if (kt1 == false)
                        MessageBox.Show("Du Lieu Nhap Vao O So Dien Thoai Chua Dung", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        if (blo.updateNCC(ncc, txtMaNCC.Text))
                        {
                            MessageBox.Show("Sua Thong Tin Nha Cung Cap Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                            NhaCungCap_Load(sender, e);
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
            NhaCungCap_Load(sender, e);
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.InNhaCungCap();
            f.Show();
           
        }

        private void txt_TimTheoMaNCC_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DoanhSachNCC.DataSource = blo.searchMaNCC(txt_TimTheoMaNCC.Text);
            binding();
        }

        private void txt_TimTheoTenNCC_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DoanhSachNCC.DataSource = blo.searchTenNCC(txt_TimTheoTenNCC.Text);
            binding();
        }

        private void txt_TimTheoDiaChiNCC_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DoanhSachNCC.DataSource = blo.searchDiaChi(txt_TimTheoDiaChiNCC.Text);
            binding();
        }
    }
}
