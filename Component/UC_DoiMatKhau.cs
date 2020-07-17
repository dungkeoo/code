using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project.Controller;

namespace Project.Component
{
    public partial class UC_DoiMatKhau : UserControl
    {
        public UC_DoiMatKhau()
        {
            InitializeComponent();
        }
        private void UserControl_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txt_MatKhauCu.Focus();
        }
     
        QuanTri_Mod blo = new QuanTri_Mod();

                                    
        void nhap()
        {
            string tk =  txt_DangNhap.Text;
          
            // MessageBox.Show("Nhắc Lại Mật Khẩu Chưa Đúng: "+tk, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string mk = txt_MatKhauCu.Text;
            string mkmoi = txt_MatKhauMoi.Text;
            string nhaclai = txt_NhapLaiMatKhauMoi.Text;
            if (txt_MatKhauCu.Text == "")
                MessageBox.Show("Hãy Nhập Mật Khẩu", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
            else if (txt_MatKhauMoi.Text == "")
                MessageBox.Show("Mật Khẩu Mới Không Được Để Trống", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (mkmoi != nhaclai)
                MessageBox.Show("Nhắc Lại Mật Khẩu Chưa Đúng", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                bool ktra = true;
                for (int i = 0; i < blo.getAll().Rows.Count; i++)
                    if (blo.getAll().Rows[i][0].ToString() == tk && blo.getAll().Rows[i][1].ToString() == mk)
                    {
                        ktra = false;
                    }
                if (ktra == false)
                {
                    if (!blo.updateMK(mkmoi, tk))
                    {
                        MessageBox.Show(blo.Error, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    else
                        MessageBox.Show("  Đổi Mật Khẩu Thành Công ", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lb_TrangThai.Text = "Đã đổi mật khẩu thành công !";
                }
                else
                    MessageBox.Show("Bạn Nhập Sai Tên Đăng Nhập Hoặc Mật Khẩu", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
              

            }
        }

       

       
        private void btDoiMatKhau_Click(object sender, EventArgs e)
        {
            nhap();
           // string tk = txtDN.Text;
           // Console.WriteLine("TEN DANG NHAP: " + tvt());
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txt_DangNhap.Text = "";
            txt_MatKhauCu.Text = "";
            txt_MatKhauMoi.Text = "";
            txt_NhapLaiMatKhauMoi.Text = "";
            lb_TrangThai.Text = "Mật khẩu chưa được thay đổi !";
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void txtDN_TextChanged(object sender, EventArgs e)
        {

        }

            
    }
}
