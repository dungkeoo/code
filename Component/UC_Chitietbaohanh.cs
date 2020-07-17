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
    public partial class UC_Chitietbaohanh : UserControl
    {
        public UC_Chitietbaohanh()
        {
            InitializeComponent();
        }

        ChiTietBaoHanh_Mod blo = new ChiTietBaoHanh_Mod();
        BaoHanh_Mod bhm = new BaoHanh_Mod();
        bool kt = true;
        ChiTietBaoHanh luuvet = new ChiTietBaoHanh();

        private void binding()
        {
            txtmaphieubh.DataBindings.Clear();
            txtmaphieubh.DataBindings.Add("Text", gridControl_danhsachcttbh.DataSource, "MAPHIEUBH");
            txtMachitietbh.DataBindings.Clear();
            txtMachitietbh.DataBindings.Add("Text", gridControl_danhsachcttbh.DataSource, "MACTBH");
            txt_thoigianbh.DataBindings.Clear();
            txt_thoigianbh.DataBindings.Add("Text", gridControl_danhsachcttbh.DataSource, "NGAYBH");
            txtnoidungbh.DataBindings.Clear();
            txtnoidungbh.DataBindings.Add("Text", gridControl_danhsachcttbh.DataSource, "NOIDUNGBH");
         

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
            txtMachitietbh.Enabled = false;
            txtmaphieubh.Enabled = an;
            txtnoidungbh.Enabled = an;
            txt_thoigianbh.Enabled = an;
            
        }

        void cleartext()
        {
            txtmaphieubh.Text = "";
            txtnoidungbh.Text = "";
        }
            
        private void btThem_Click(object sender, EventArgs e)
        {
            locktext(true);
            cleartext();
            txtMachitietbh.Text = blo.NextID();
            txtmaphieubh.Focus();
            kt = true;
            lockbutton(false);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            locktext(true);
            txtnoidungbh.Focus();
            kt = false;
            lockbutton(false);
        }

        private void UC_Chitietbaohanh_Load(object sender, EventArgs e)
        {

            gridControl_danhsachcttbh.DataSource = blo.getAll();
            binding();
            lockbutton(true);
            locktext(false);
            // rdbTimTheoMaNhanVien.Checked = true;

            txtmaphieubh.DataSource = bhm.getAll();
            txtmaphieubh.DisplayMember = "MAPHIEUBH";
            txtmaphieubh.ValueMember = "MAPHIEUBH";

        }

        private void btIn_Click(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = new DialogResult();
            h = MessageBox.Show("Bạn có chắc muốn xóa " + txtMachitietbh.Text + " ra khỏi danh sách chi tiết bảo hành", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h.ToString() == "OK")
            {
                if (!blo.deleteCTPBH(txtMachitietbh.Text))
                {
                    MessageBox.Show(blo.Error, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã xóa mã chi tiết phiếu bảo hành thành công " + txtMachitietbh.Text, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            UC_Chitietbaohanh_Load(sender, e);
        }

        
        private void btLuu_Click(object sender, EventArgs e)
        {

            ChiTietBaoHanh tk = new ChiTietBaoHanh();
            if (txtmaphieubh.Text == "")
                MessageBox.Show("Hãy mã phiếu bảo hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtnoidungbh.Text == "")
                MessageBox.Show("Hãy Nhập Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           else
            {
                bool a = true;
                tk.MaCTBH = txtMachitietbh.Text;
                tk.MaPhieuBH = txtmaphieubh.Text;
                tk.NgayBH = txt_thoigianbh.Text;
                tk.NoiDungBH = txtnoidungbh.Text;
                try
                {
                    
                }
                catch
                {
                    a = false;
                }
                
                if (a == false)
                {
                    MessageBox.Show("Số Điện Thoại Chưa Đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (kt == true)
                    {
                        if (!blo.insertChitietBH(tk))
                            MessageBox.Show("Tên Tài Khoản Này Đã Tồn Tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            MessageBox.Show("Đã Thêm Tài Khoản Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         
                            UC_Chitietbaohanh_Load(sender, e);
                        }
                    }
                    else
                    {
                        if (!blo.updateChitietBH(tk, txtMachitietbh.Text, txtmaphieubh.Text))
                            MessageBox.Show(blo.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            MessageBox.Show("Đã Sửa Tài Khoản Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           UC_Chitietbaohanh_Load(sender, e);
                        }
                    }
                }
            }
        }

        

        private void btHuy_Click(object sender, EventArgs e)
        {
            UC_Chitietbaohanh_Load(sender, e);
        }

       

    }
    }

