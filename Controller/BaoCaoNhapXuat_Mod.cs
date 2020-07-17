using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Project.Connection;

namespace Project.Controller
{
    class BaoCaoNhapXuat_Mod
    {
        public string Error;
        GetData data = new GetData();
        public DataTable xuatnamthang(string nam, string thang)
        {
            string select = " select * from v_DanhSachPXuat where Tháng='" + thang + "' and Năm ='" + nam + "'";
            try
            {
                return data.getdata(select);
            }
            catch
            {
                Error = data.Error;
                return null;
            }
        }


        public DataTable nhapnamthang(string nam, string thang)
        {
            string select = " select * from v_DanhSachPNhap where Tháng='" + thang + "' and Năm ='" + nam + "'";
            try
            {
                return data.getdata(select);
            }
            catch
            {
                Error = data.Error;
                return null;
            }
        }

        public DataTable doanhthu(string nam, string thang)
        {
            string select = " select * from v_dthu where Tháng='" + thang + "' and Năm ='" + nam + "'";
            try
            {
                return data.getdata(select);
            }
            catch
            {
                Error = data.Error;
                return null;
            }
        }


        public DataTable Laydsnhaphang()
        {
            string sql = "select * from v_pnhap";
            return data.getdata(sql);
        }

        public DataTable Laydsxuathang()
        {
            string sql = "select * from v_pxuat";
            return data.getdata(sql);
        }

        public DataTable hangbanchay(string nam, string thang)
        {
            string select = " select * from v_hangbanchay where Tháng='" + thang + "' and Năm ='" + nam + "'";
            try
            {
                return data.getdata(select);
            }
            catch
            {
                Error = data.Error;
                return null;
            }
        }
    }
}
