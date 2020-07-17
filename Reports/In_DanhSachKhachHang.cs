using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project.Controller;

namespace Project.Reports
{
    public partial class In_DanhSachKhachHang : UserControl
    {
        public In_DanhSachKhachHang()
        {
            InitializeComponent();
        }

        KhachHang_Mod kh = new KhachHang_Mod();
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            khachHangBindingSource.DataSource = kh.LaydskhachHang();
            this.reportViewer1.RefreshReport();
        }
    }
}
