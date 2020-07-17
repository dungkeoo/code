using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using Project.Component;
using Project.Reports;


namespace Project
{
    public partial class frmMain : RibbonForm

    {
        
        AddTab.TabAdd clsAddTab = new AddTab.TabAdd();
        
        
        #region "Code cho nut Close xtraTabControl"
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {// Đóng tab đang focus trên TAb Cha
            xtraTabControl1.TabPages.RemoveAt(xtraTabControl1.SelectedTabPageIndex);
        }
        private void xtraTabControl1_ControlAdded(object sender, ControlEventArgs e)
        {// Khi add vào thì Focus tới ngay Tab vừa Add
            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
        }
        #endregion


        
        public frmMain()
        {
            InitializeComponent();
            InitSkinGallery();
          
          
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

       private void Form1_Load(object sender, EventArgs e)
      {
        clsAddTab.AddTab(xtraTabControl1, "", "About", new UC_GioiThieu());
      }

      
        private void btthaydoimatkhaudn_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Đổi Mật Khẩu Đăng Nhập Chương Trình")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
              //    xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
                }
            }
            if (t == 1)
            {
          //   xtraTabControl1_CloseButtonClick(sender,  e);
            // xtraTabControl1_ControlAdded(sender, e);
            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Đổi Mật Khẩu Đăng Nhập Chương Trình", new UC_DoiMatKhau());
            }
            siInfo.Caption = "Bạn đang xem tab Đổi Mật Khẩu Đăng Nhập Chương Trình";
        }

        private void btThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
             int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Thông Tin Về Chương Trình")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Thông Tin Về Chương Trình", new UC_GioiThieu());
            }
            siInfo.Caption = "Bạn đang xem tab Thông Tin Về Chương Trình";
        }

        private void btBaoCaoNhapHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Báo Cáo Nhập Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Báo Cáo Nhập Hàng", new RP_NhapHang());
            }
            siInfo.Caption = "Bạn đang xem tab Báo Cáo Nhập Hàng";
        }

        private void btBaoCaoXuatHang_ItemClick(object sender, ItemClickEventArgs e)
        {

            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Báo Cáo Xuất Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Báo Cáo Xuất Hàng", new RP_XuatHang());
            }
            siInfo.Caption = "Bạn đang xem tab Báo Cáo Xuất Hàng";
        }

        private void btBaoCaoDoanhThu_ItemClick(object sender, ItemClickEventArgs e)
        {


            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Báo Cáo Doanh Thu")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Báo Cáo Doanh Thu", new RP_DoanhThu());
            }
            siInfo.Caption = "Bạn đang xem tab Báo Cáo Doanh Thu";
        }

        private void btBaoCaoHangBanChay_ItemClick(object sender, ItemClickEventArgs e)
        {


            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Báo Cáo Hàng Bán Chạy")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Báo Cáo Hàng Bán Chạy", new RP_HangBanChay());
            }
            siInfo.Caption = "Bạn đang xem tab Báo Cáo Hàng Bán Chạy";
        }

        private void btHangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {


            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản Lý Xe Máy")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Xe Máy", new UC_XeMay());
            }
            siInfo.Caption = "Bạn đang xem tab Quản Lý Xe Máy";
        }

        private void btKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản Lý Khách Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Khách Hàng", new UC_KhachHang());
            }
            siInfo.Caption = "Bạn đang xem tab Quản Lý Khách Hàng";
        }

        private void btNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {

            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản Lý Nhân Viên")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Nhân Viên", new UC_NhanVien());
            }
            siInfo.Caption = "Bạn đang xem tab Quản Lý Nhân Viên";
        }

        private void btNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản Lý Nhà Cung Cấp")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Nhà Cung Cấp", new UC_NhaCungCap());
            }
            siInfo.Caption = "Bạn đang xem tab Quản Lý Nhà Cung Cấp";
        }

        private void btNhapHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản Lý Nhập Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Nhập Hàng", new UC_NhapHang());
            }
            siInfo.Caption = "Bạn đang xem tab Quản Lý Nhập Hàng";
        }

        private void btXuatHang_ItemClick(object sender, ItemClickEventArgs e)
        {

            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản Lý Xuất Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Xuất Hàng", new UC_XuatHang());
            }
            siInfo.Caption = "Bạn đang xem tab Quản Lý Xuất Hàng";
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản Trị Tài Nguyên")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản Trị Tài Nguyên", new UC_QuanTri());
            }
            siInfo.Caption = "Bạn đang xem tab Quản Trị Tài Nguyên";
        }

        private void btThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult h = new DialogResult();
            h = MessageBox.Show("Bạn Có Thực Sự Muốn Thoát", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h.ToString() == "OK")
                Application.Exit();

        }

        private void XuLyThoat(object sender, FormClosingEventArgs e)
        {
           // DialogResult h = new DialogResult();
          //  h = MessageBox.Show("Bạn Có Thực Sự Muốn Thoát", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
          //  if (h.ToString() == "OK")
          //      Application.Exit();

        }

        private void XuLyDong(object sender, FormClosedEventArgs e)
        {
          //  DialogResult h = new DialogResult();
          //  h = MessageBox.Show("Bạn Có Thực Sự Muốn Thoát", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
          //  if (h.ToString() == "OK")
          //      Application.Exit();

        }

        private void DongTab(object sender, EventArgs e)
        {
            xtraTabControl1.TabPages.RemoveAt(xtraTabControl1.SelectedTabPageIndex);
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void btHangTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {
  int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Hàng Tồn Kho")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Hàng Tồn Kho", new RP_TonKho());
            }
            siInfo.Caption = "Bạn đang xem tab Hàng Tồn Kho";
        
        }
  
        // In Nha Cung cap---------------------------------------------------------------------------------

        public void InNhaCungCap()
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "In Danh Sách Nhà Cung Cấp")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "In Danh Sách Nhà Cung Cấp", new In_DanhSachNhaCungCapcs());
            }
            siInfo.Caption = "Bạn đang xem tab In Danh Sách Nhà Cung Cấp";
        }


        // in Khach Hang

        public void InKhachHang()
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "In Danh Sách Khách Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "In Danh Sách Khách Hàng", new In_DanhSachKhachHang());
            }
            siInfo.Caption = "Bạn đang xem tab In Danh Sách Khách Hàng";
        }

        // In Xe May

        public void InDanhSachXeMay()
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "In Danh Sách Xe Máy")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "In Danh Sách Xe Máy", new In_DanhSachXeMay());
            }
            siInfo.Caption = "Bạn đang xem tab In Danh Sách Xe Máy";
        }

        // In Hoa Don Nhap

     
        // in hoa don xuat

        // in nhan vien

        public void InNhanVien()
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "In Danh Sách Nhân Viên")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Danh Sách Nhân Viên", new In_DanhSachNhanVien());
            }
            siInfo.Caption = "Bạn đang xem tab Danh Sách Nhân Viên";
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult h = new DialogResult();
            h = MessageBox.Show("Bạn Có Thực Sự Muốn Đăng Xuất", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h.ToString() == "OK")
            {
                frmDangNhap f = new frmDangNhap();
                f.Show();
                this.Hide();
            }

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
             int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Danh Sách Xuất Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Danh Sách Xuất Hàng", new UC_Xuat());
            }
            siInfo.Caption = "Bạn đang xem tab Danh Sách Xuất Hàng";
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
               int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Danh Sách Nhập Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Danh Sách Nhập Hàng", new UC_Nhap());
            }
            siInfo.Caption = "Bạn đang xem tab Danh Sách Nhập Hàng";
        }

        private void QuanTri_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản Trị Tài Nguyên")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản Trị Tài Nguyên", new UC_QuanTri());
            }
            siInfo.Caption = "Bạn đang xem tab Quản Trị Tài Nguyên";
        }

        private void DoiMatKhau_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Đổi Mật Khẩu Đăng Nhập Chương Trình")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                    //    xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
                }
            }
            if (t == 1)
            {
                //   xtraTabControl1_CloseButtonClick(sender,  e);
                // xtraTabControl1_ControlAdded(sender, e);
            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Đổi Mật Khẩu Đăng Nhập Chương Trình", new UC_DoiMatKhau());
            }
            siInfo.Caption = "Bạn đang xem tab Đổi Mật Khẩu Đăng Nhập Chương Trình";
        }

        private void DangXuat_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DialogResult h = new DialogResult();
            h = MessageBox.Show("Bạn Có Thực Sự Muốn Đăng Xuất", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h.ToString() == "OK")
            {
                frmDangNhap f = new frmDangNhap();
                f.Show();
                this.Hide();
            }

        }

        private void Thoat_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DialogResult h = new DialogResult();
            h = MessageBox.Show("Bạn Có Thực Sự Muốn Thoát", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h.ToString() == "OK")
                Application.Exit();

        }

        private void NhaCungCap_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản Lý Nhà Cung Cấp")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Nhà Cung Cấp", new UC_NhaCungCap());
            }
            siInfo.Caption = "Bạn đang xem tab Quản Lý Nhà Cung Cấp";
        }

        private void XeMay_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản Lý Xe Máy")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Xe Máy", new UC_XeMay());
            }
            siInfo.Caption = "Bạn đang xem tab Quản Lý Xe Máy";
        }

        private void KhachHang_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản Lý Khách Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Khách Hàng", new UC_KhachHang());
            }
            siInfo.Caption = "Bạn đang xem tab Quản Lý Khách Hàng";
        }

        private void NhanVien_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản Lý Nhân Viên")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Nhân Viên", new UC_NhanVien());
            }
            siInfo.Caption = "Bạn đang xem tab Quản Lý Nhân Viên";
        }

        private void QuanLyXuat_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Danh Sách Xuất Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Danh Sách Xuất Hàng", new UC_Xuat());
            }
            siInfo.Caption = "Bạn đang xem tab Danh Sách Xuất Hàng";
        }

        private void QuanLyNhap_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Danh Sách Nhập Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Danh Sách Nhập Hàng", new UC_Nhap());
            }
            siInfo.Caption = "Bạn đang xem tab Danh Sách Nhập Hàng";
        }

        private void NhapHang_Click(object sender, EventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản Lý Nhập Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Nhập Hàng", new UC_NhapHang());
            }
            siInfo.Caption = "Bạn đang xem tab Quản Lý Nhập Hàng";
        }

        private void XuatHang_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản Lý Xuất Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Xuất Hàng", new UC_XuatHang());
            }
            siInfo.Caption = "Bạn đang xem tab Quản Lý Xuất Hàng";
        }

        private void BaoCaoNhapHang_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Báo Cáo Nhập Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Báo Cáo Nhập Hàng", new RP_NhapHang());
            }
            siInfo.Caption = "Bạn đang xem tab Báo Cáo Nhập Hàng";
        }

        private void BaoCaoXuatHang_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Báo Cáo Xuất Hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Báo Cáo Xuất Hàng", new RP_XuatHang());
            }
            siInfo.Caption = "Bạn đang xem tab Báo Cáo Xuất Hàng";
        }

        private void BaoCaoDoanhThu_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Báo Cáo Doanh Thu")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Báo Cáo Doanh Thu", new RP_DoanhThu());
            }
            siInfo.Caption = "Bạn đang xem tab Báo Cáo Doanh Thu";
        }

        private void BaoCaoHangBanChay_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Báo Cáo Hàng Bán Chạy")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Báo Cáo Hàng Bán Chạy", new RP_HangBanChay());
            }
            siInfo.Caption = "Bạn đang xem tab Báo Cáo Hàng Bán Chạy"; 
        }

        private void BaoCaoHangTonKho_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Hàng Tồn Kho")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Hàng Tồn Kho", new RP_TonKho());
            }
            siInfo.Caption = "Bạn đang xem tab Hàng Tồn Kho";
        }

        private void barButtonI_saoluu_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Sao lưu dữ liệu")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Sao lưu dữ liệu", new UC_Saoluu());
            }
            siInfo.Caption = "Bạn đang xem tab Sao lưu dữ liệu";
        }

        private void barButtonI_phuchoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Phục hồi dữ liệu")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Phục hồi dữ liệu", new UC_Phuchoi());
            }
            siInfo.Caption = "Bạn đang xem tab Phục hồi dữ liệu";
        }

        private void barButtonItem4_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Bảo hành")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Bảo hành", new UC_BaoHanh());
             
            }
            siInfo.Caption = "Bạn đang xem tab Bảo hành";
           
        }

    
        private void barButtonItem7_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản lý hóa đơn nhập hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản lý hóa đơn nhập hàng", new UC_QLNhapHang());

            }
            siInfo.Caption = "Bạn đang xem tab Quản lý hóa đơn nhập hàng";
        }

        private void barButtonItem5_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Nội dung bảo hành")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
              clsAddTab.AddTab(xtraTabControl1, "", "Nội Dung Bảo hành", new UC_Chitietbaohanh());
            }
            siInfo.Caption = "Bạn đang xem tab Nội dung bảo hành";
           
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản lý hóa đơn xuất hàng")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản lý hóa đơn xuất hàng", new UC_QLXuatHang());
            }
            siInfo.Caption = "Bạn đang xem tab Quản lý hóa đơn xuất hàng";
        }

    
        }
        }

     
        
        
        
      
       

    
