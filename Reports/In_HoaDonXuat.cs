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
    public partial class In_HoaDonXuat : Form
    {
        string mahd = "";
        public In_HoaDonXuat(string mpx)
        {
            InitializeComponent();
            mahd = mpx;
        }

      

       // BaoCaoNhapXuat_Mod bc = new BaoCaoNhapXuat_Mod();
        XuatHang_Mod xh = new XuatHang_Mod();

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           // vpxuatBindingSource.DataSource = bc.Laydsxuathang();
            vpxuatBindingSource.DataSource = xh.view(mahd);
            this.reportViewer1.RefreshReport();

        }
    }
}
