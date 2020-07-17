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
    public partial class In_HoaDonNhap : Form
    {
        string ma = "";        
        public In_HoaDonNhap(string mahd)
        {
            InitializeComponent();

            ma = mahd;
        }

        NhapHang_Mod nh = new NhapHang_Mod();
        //BaoCaoNhapXuat_Mod bc = new BaoCaoNhapXuat_Mod();

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           // vpnhapBindingSource.DataSource = bc.Laydsnhaphang();
            vpnhapBindingSource.DataSource = nh.view(ma);
            this.reportViewer1.RefreshReport();

        }
    }
}
