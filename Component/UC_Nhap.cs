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
    public partial class UC_Nhap : UserControl
    {
        public UC_Nhap()
        {
            InitializeComponent();
        }

        NhapHang_Mod nhapblo = new NhapHang_Mod();

        private void UC_Nhap_Load(object sender, EventArgs e)
        {
            gridControl_DanhSachNhapHang.DataSource = nhapblo.GetDanhSachNhapHang();
            gridControl_DanhSachNhapHang.Refresh();
            radioButton_TimTheoMPN.Checked = true;
        }

        private void txt_TimTheoMPN_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachNhapHang.DataSource = nhapblo.SearchTenNV(txt_TimTheoMPN.Text);
         //   gridControl_DanhSachNhapHang.Refresh();


        }

        private void txt_TimTheoTenNCC_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachNhapHang.DataSource = nhapblo.SearchTenNCC(txt_TimTheoTenNCC.Text);
          //  gridControl_DanhSachNhapHang.Refresh();
        }

        private void txt_TimTheoTenNV_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DanhSachNhapHang.DataSource = nhapblo.SearchTenNV(txt_TimTheoTenNV.Text);
           // gridControl_DanhSachNhapHang.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gridControl_DanhSachNhapHang.DataSource = nhapblo.GetDanhSachNhapHang();
            gridControl_DanhSachNhapHang.Refresh();
            radioButton_TimTheoMPN.Checked = true;
        }
    }
}
