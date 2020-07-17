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
    public partial class In_DanhSachNhanVien : UserControl
    {
        public In_DanhSachNhanVien()
        {
            InitializeComponent();
        }

        NhanVien_Mod nv = new NhanVien_Mod();

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            nhanVienBindingSource.DataSource = nv.Laydsnhanvien();
            this.reportViewer1.RefreshReport();

        }
    }
}
