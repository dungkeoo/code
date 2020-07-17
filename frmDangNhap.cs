using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using Project.Controller;
using System.Data.SqlClient;

namespace Project
{
    public partial class frmDangNhap : Form
    {

        DangNhap_Mod dn = new DangNhap_Mod();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Helper h = new Helper();
                SqlConnection con = h.GetConnect();
                con.Open();
                con.Close();
            }
            catch (Exception)
            {
                frmConnection f = new frmConnection();
                f.ShowDialog();
            }
            txtDangNhap.Focus();
            txt.Hide();
        }

        void ktQuyen()
        {
            txt.DataBindings.Clear();
            txt.DataBindings.Add("Text", dn.dt(txtDangNhap.Text, txtMatKhau.Text), "quyen");
            string quyenDN = txt.Text;
            if (quyenDN.Equals("admin") == true)
            {
                MessageBox.Show("Bạn Đã Đăng Nhập Quyền Admin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain admin = new frmMain();
             
               // admin.ribbonPage_QuanLy.Visible = false;
                admin.ribbonPage_NghiepVu.Visible = false;
                admin.ribbonPage_BaoCao.Visible = false;
                admin.ribbonPage_BaoTri.Visible = false;

               // admin.navBarGroup_QuanLy.Visible = false;
                admin.navBarGroup_NghiepVu.Visible = false;
                admin.navBarGroup_BaoCao.Visible = false;

                admin.barButtonItem_XeMay.Enabled = false;
                admin.barButtonItem_KhachHang.Enabled = false;
                admin.barButtonItem_NhaCungCap.Enabled = false;
                admin.barButtonItem_QuanLyNhap.Enabled = false;
                admin.barButtonItem_QuanLyXuat.Enabled = false;

                admin.navBarItem_XeMay.Enabled = false;
               // admin.narBarItem_KhachHang.Enabled = false;
                admin.navBarItem_KhachHang.Enabled = false;
                admin.navBarItem_NhaCungCap.Enabled = false;
                admin.navBarItem_QuanLyNhap.Enabled = false;
                admin.navBarItem_QuanLyXuat.Enabled = false;
                
                admin.Show();
                this.Hide();
            }
            else if (quyenDN.Equals("quanly") == true)
            {
                MessageBox.Show("Bạn Đã Đăng Nhập Quyền Quản Lý", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain quanly = new frmMain();
                quanly.barButtonItem_QuanTri.Enabled = false;
                quanly.navBarItem_QuanTri.Enabled = false;
                quanly.navBarGroup_NghiepVu.Visible = true;

                quanly.ribbonPage_NghiepVu.Visible = true;
                quanly.barButtonItem_XuatHang.Enabled = false;
                quanly.navBarItem_XuatHang.Enabled = false;

                

                quanly.Show();
                this.Hide();
            }
            else if (quyenDN.Equals("nhanvien") == true)
            {
                MessageBox.Show("Bạn Đã Đăng Nhập Quyền Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain nhanvien = new frmMain();


                nhanvien.barButtonI_phuchoi.Enabled = false;
                nhanvien.barButtonI_saoluu.Enabled = false;

                nhanvien.barButtonItem7.Enabled = false;
                nhanvien.navBarItem_NhapHang.Enabled = false;
                nhanvien.barButtonItem_NhapHang.Enabled = false;

                nhanvien.barButtonItem_QuanTri.Enabled = false;
                nhanvien.navBarItem_QuanTri.Enabled = false;

                nhanvien.barButtonItem_XeMay.Enabled = false;
                nhanvien.barButtonItem_NhanVien.Enabled = false;
                nhanvien.barButtonItem_NhaCungCap.Enabled = false;
                nhanvien.barButtonItem_QuanLyNhap.Enabled = false;
                nhanvien.barButtonItem_QuanLyXuat.Enabled = false;

                nhanvien.barButtonItem_BaoCaoDoanhThu.Enabled = false;
                nhanvien.barButtonItem_BaoCaoNhapHang.Enabled = false;
                nhanvien.barButtonItem_BaoCaoXuatHang.Enabled = false;

                nhanvien.navBarItem_XeMay.Enabled = false;
                nhanvien.navBarItem_NhanVien.Enabled = false;
                nhanvien.navBarItem_NhaCungCap.Enabled = false;
                nhanvien.navBarItem_QuanLyNhap.Enabled = false;
                nhanvien.navBarItem_QuanLyXuat.Enabled = false;

                nhanvien.navBarItem_BaoCaoDoanhThu.Enabled = false;
                nhanvien.navBarItem_BaoCaoNhapHang.Enabled = false;
                nhanvien.navBarItem_BaoCaoXuatHang.Enabled = false;


                          
                

                nhanvien.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Tài Khoản Này Không Hợp Lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        void dangnhap()
        {
            string tendn = txtDangNhap.Text;
            string matkhau = txtMatKhau.Text;

            if (txtDangNhap.Text == "")
            {
                MessageBox.Show("Bạn Phải Nhập Tên Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                if (txtMatKhau.Text == "")
                    MessageBox.Show("Bạn Phải Nhập Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    bool kt = true;
                    try
                    {
                        for (int i = 0; i < dn.getAll().Rows.Count; i++)
                        {
                            if (dn.getAll().Rows[i][0].ToString() == tendn && dn.getAll().Rows[i][1].ToString() == matkhau)
                            {
                                kt = false;
                                MessageBox.Show("Bạn Đã Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                              //  frmMain admin = new frmMain();
                             //   admin.Show();
                              //  this.Hide();
                                
                                 ktQuyen();
                            }
                        }
                        if (kt == true)
                            MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi Kết Nối Đến Cơ Sở Dữ Liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNhapLai_Click(object sender, EventArgs e)
        {
            txtDangNhap.Text = "";
            txtMatKhau.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dangnhap();
        }

        private void button_cauhinhdangnhap(object sender, EventArgs e)
        {
            frmConnection ct = new frmConnection();
            ct.Show();
        }

           

       
    }
}                

    
        