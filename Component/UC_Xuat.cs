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
    public partial class UC_Xuat : UserControl
    {
        public UC_Xuat()
        {
            InitializeComponent();
        }


        XuatHang_Mod xuatblo = new XuatHang_Mod();

        private void UC_Xuat_Load(object sender, EventArgs e)
        {
            gridControl_DanhSachXuatHang.DataSource = xuatblo.getDanhSachXuatHang();
            gridControl_DanhSachXuatHang.Refresh();
            radioButton_TimTheoMPX.Checked = true;
        }

        private void txt_TimTheoMPX_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachXuatHang.DataSource = xuatblo.SearchMaPX(txt_TimTheoMPX.Text);
            DataTable tb = xuatblo.SearchMaPX(txt_TimTheoMPX.Text);
          // radioButton_TimTheoMPX.Checked = true;
        }

        private void txt_TimTheoTenNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachXuatHang.DataSource = xuatblo.SearchTenNV(txt_TimTheoTenNhanVien.Text);
          //  radioButton_TimTheoTenNhanVien.Checked = true;
        }

        private void txt_TimTheoTenKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachXuatHang.DataSource = xuatblo.SearchTenKH(txt_TimTheoTenKhachHang.Text);
         //   radioButton_TimTheoTenKhachHang.Checked = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gridControl_DanhSachXuatHang.DataSource = xuatblo.getDanhSachXuatHang();
            gridControl_DanhSachXuatHang.Refresh();
            radioButton_TimTheoMPX.Checked = true;
        }
    }
}
