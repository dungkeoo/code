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
    public partial class RP_HangBanChay : UserControl
    {
        public RP_HangBanChay()
        {
            InitializeComponent();
        }

        BaoCaoNhapXuat_Mod bc = new BaoCaoNhapXuat_Mod();
        void gancombo()
        {
            int year = DateTime.Now.Year;
            
            for (int i = 1; i <= 12; i++)
            {
                cb_Thang.Items.Add(i);
            }
            for (int j = 2017; j <= year; j++)
           
            cb_Nam.Items.Add(j);
            cb_Nam.SelectedIndex = 0;
            cb_Thang.SelectedIndex = 0;
        }

        private void RP_HangBanChay_Load(object sender, EventArgs e)
        {
            gancombo();
        }

        private void bt_Xem_Click(object sender, EventArgs e)
        {
            vhangbanchayBindingSource.DataSource = bc.hangbanchay(cb_Nam.Text, cb_Thang.Text);
            this.reportViewer1.RefreshReport();

        }

          }
}
