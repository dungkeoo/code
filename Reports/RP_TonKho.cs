﻿using System;
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
    public partial class RP_TonKho : UserControl
    {
        public RP_TonKho()
        {
            InitializeComponent();
        }
        XeMay_Mod xm = new XeMay_Mod();
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            matHangBindingSource.DataSource = xm.Laydsxemay();
            this.reportViewer1.RefreshReport();
        }
    }
}