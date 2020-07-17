using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project.Controller;
using Project.Bussiness;

namespace Project.Component
{
    public partial class UC_BaoHanh : UserControl
    {
        public UC_BaoHanh()
        {
            InitializeComponent();
        }

        BaoHanh_Mod blo = new BaoHanh_Mod();
        bool kt = true;
        BaoHanh luuvet = new BaoHanh();
        XeMay_Mod xm = new XeMay_Mod();
        KhachHang_Mod kh = new KhachHang_Mod();
        
        void lockbutton(bool an)
        {
            btThem.Enabled = an;
            btSua.Enabled = an;
            btXoa.Enabled = an;
            btLuu.Enabled = !an;
            btHuy.Enabled = !an;
            btIn.Enabled = an;
        }

        void locktext(bool an)
        {
            txt_phieubh.Enabled = false;
            cmbNgaymua.Enabled = an;
            cmb_makh.Enabled = an;
            txt_somay.Enabled = an;
            txt_sokhung.Enabled = an;
            cmb_maxe.Enabled = an;
            cmb_thoigianbh.Enabled = an;
            txt_trangthai.Enabled = false;
        }

        private void binding()
        {
           txt_phieubh.DataBindings.Clear();
            txt_phieubh.DataBindings.Add("Text", grid_baohanh.DataSource, "MAPHIEUBH");
            cmb_makh.DataBindings.Clear();
            cmb_makh.DataBindings.Add("Text", grid_baohanh.DataSource, "MAKHACHHANG");
            cmb_maxe.DataBindings.Clear();
            cmb_maxe.DataBindings.Add("Text", grid_baohanh.DataSource, "MAHANG");
            txt_sokhung.DataBindings.Clear();
            txt_sokhung.DataBindings.Add("Text", grid_baohanh.DataSource, "SOKHUNG");
            txt_somay.DataBindings.Clear();
            txt_somay.DataBindings.Add("Text", grid_baohanh.DataSource, "SOMAY");
            cmbNgaymua.DataBindings.Clear();
            cmbNgaymua.DataBindings.Add("Text", grid_baohanh.DataSource, "NGAYMUA");
            txt_trangthai.DataBindings.Clear();
            txt_trangthai.DataBindings.Add("Text", grid_baohanh.DataSource, "THOIGIANBH");
        }
        void cleartext()
        {
            txt_sokhung.Text = "";
            txt_somay.Text = "";
        }

        private void UC_BaoHanh_Load(object sender, EventArgs e)
        {
            grid_baohanh.DataSource = blo.getAll();
            binding();
            lockbutton(true);
            locktext(false);
            // rdbTimTheoMaNCC.Checked = true;

            cmbNgaymua.Text = DateTime.Today.ToShortDateString();

            cmb_makh.DataSource = kh.getAll();
            cmb_makh.DisplayMember = "tenkhachhang";
            cmb_makh.ValueMember = "makhachhang";

            cmb_maxe.DataSource = xm.getAll();
            cmb_maxe.DisplayMember = "tenhang";
            cmb_maxe.ValueMember = "mahang";

            cmb_thoigianbh.DataSource = xm.getAllBH();
            cmb_thoigianbh.DisplayMember = "THOIGIANBH";
            cmb_thoigianbh.ValueMember = "SONGAYBH";

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            BaoHanh pbh = new BaoHanh();

            DateTime Ngay = Convert.ToDateTime(cmbNgaymua.Text);
            String NgayDeLuu = Ngay.ToString("MM/dd/yyyy");
            string result = DateTime.ParseExact(NgayDeLuu, "mm/dd/yyyy", null).AddDays(Convert.ToInt32(cmb_thoigianbh.SelectedValue.ToString())).ToString("mm/dd/yyyy");                     
          //  blo.insertPhieubaohanh(pbh);


           if (txt_sokhung.Text == "")
                MessageBox.Show("Không được bỏ trống số khung", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txt_somay.Text == "")
                MessageBox.Show("Không được bỏ trống số máy", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                bool kt1 = true;
                bool kt2 = true;
                bool kt3 = true;
                             
            pbh.MaPhieuBH = txt_phieubh.Text;
            pbh.MaKhachHang = cmb_makh.SelectedValue.ToString();
            pbh.MaHang = cmb_maxe.SelectedValue.ToString();
            pbh.SoKhung = txt_sokhung.Text;
            pbh.SoMay = txt_somay.Text;
            pbh.NgayMua = cmbNgaymua.Text;
            pbh.ThoiGianBH = result;


                if (kt1 == false)
                    MessageBox.Show("Số điện thoại không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (kt2 == false)
                    MessageBox.Show("Năm sinh không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (kt3 == false)
                    MessageBox.Show("Giá trị nhập vào lương không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    if (kt == true)
                    {
                        if (!blo.insertPhieubaohanh(pbh))
                        {
                            MessageBox.Show("Lỗi hệ thống, Không lưu được", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm bảo hành thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UC_BaoHanh_Load(sender, e);
                        }
                    }
                    else
                    {
                        if (!blo.updatePhieubaohanh(pbh, txt_phieubh.Text))
                        {
                            MessageBox.Show(blo.Error, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sửa bảo hành thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UC_BaoHanh_Load(sender, e);
                        }
                    }

            }      
        }                       
              
                    
       private void btHuy_Click(object sender, EventArgs e)
        {
            UC_BaoHanh_Load(sender, e);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            cmbNgaymua.Text = DateTime.Today.ToShortDateString();
            locktext(true);
            cleartext();
            txt_phieubh.Text = blo.NextID();
            txt_sokhung.Focus();
            kt = true;
            lockbutton(false);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            locktext(true);
            txt_phieubh.Enabled = true;
            txt_sokhung.Focus();
            kt = false;
            lockbutton(false);

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = new DialogResult();
            h = MessageBox.Show("Bạn muốn xóa phiếu bảo hành có mã :" + txt_phieubh.Text + "ra khỏi hệ thống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h.ToString() == "OK")
            {
                if (!blo.deletephieubaohanh(txt_phieubh.Text))
                {
                    MessageBox.Show(blo.Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã xóa thành công phiếu bảo hành " + txt_phieubh.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            UC_BaoHanh_Load(sender, e);
        }


        private void btIn_Click(object sender, EventArgs e)
        {
            // frmMain f = new frmMain();
            //  f.InNhaCungCap();
            // f.Show();
        }

        private void Timkiemmakhachhang(object sender, EventArgs e)
        {
            grid_baohanh.DataSource = blo.searchMakhachHang(txt_Timtheomakhahchang.Text);
            binding();

        }

        private void Timkiemsokhung(object sender, EventArgs e)
        {
            grid_baohanh.DataSource = blo.searchMakhachHang(txt_timtheosokhung.Text);
            binding();
        }

        private void Timtheosomay(object sender, EventArgs e)
        {
            grid_baohanh.DataSource = blo.searchsokhung(txt_timtheosokhung.Text);
            //grid_baohanh.DataSource = blo.searchMakhachHang(txt_timtheosomay.Text);
            binding();
        }
    }
}
