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
    public partial class In_DanhSachNhaCungCapcs : UserControl
    {
        public In_DanhSachNhaCungCapcs()
        {
            InitializeComponent();
        }

        NhaCungCap_Mod ncc = new NhaCungCap_Mod();

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            nhaCungCapBindingSource.DataSource = ncc.Laydsnhacungcap();
            this.reportViewer1.RefreshReport();
        }
    }
}
