using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Project.Connection;
using Project.Bussiness;

namespace Project.Controller
{
    class BaoHanh_Mod
    {
        GetData data = new GetData();
        private string _error;

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public string NextID()
        {
            return Utilities.NextID(data.GetLastID("PhieuBaoHanh", "MAPHIEUBH"), "MABH");
        }


        public DataTable getAll()
        {
            string select = "select * from PhieuBaoHanh";
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

        public bool insertPhieubaohanh(BaoHanh bh)
        {
            string strInsert = "insert into PhieuBaoHanh values( ";
            strInsert += "'" + bh.MaPhieuBH + "',";
            strInsert += "'" + bh.MaKhachHang + "',";
            strInsert += "'" + bh.MaHang + "',";
            strInsert += "'" + bh.SoKhung + "',";
            strInsert += "'" + bh.SoMay + "',";
            strInsert += "'" + bh.NgayMua + "',";
            strInsert += "'" + bh.ThoiGianBH + "')";
            if (!data.UpdateData(strInsert))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public bool updatePhieubaohanh(BaoHanh nv, string ma)
        {
            string strUpdate = "update PhieuBaoHanh set ";
            strUpdate += "MAPHIEUBH='" + nv.MaPhieuBH + "',";
            strUpdate += "MAKHACHHANG='" + nv.MaKhachHang + "',";
            strUpdate += "MAHANG='" + nv.MaHang + "',";
            strUpdate += "SOKHUNG='" + nv.SoKhung + "',";
            strUpdate += "SOMAY='" + nv.SoMay + "',";
            strUpdate += "NGAYMUA='" + nv.NgayMua + "',";
            strUpdate += "THOIGIANBH='" + nv.ThoiGianBH + "' ";
            strUpdate += "where MAPHIEUBH='" + ma + "'";
            
            if (!data.UpdateData(strUpdate))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }


        public bool deletephieubaohanh(string ma)
        {
            string delete = "delete  from PhieuBaoHanh where MAPHIEUBH ='" + ma + "'";
            if (!data.UpdateData(delete))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }



        public DataTable Laydsphieubaohanh()
        {
            string sql = "select * from PhieuBaoHanh";
            return data.getdata(sql);
        }


        public DataTable searchMakhachHang(string key)
        {
            string select = "select * from PhieuBaoHanh where MAKHACHHANG like '%" + key + "%'";
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

        public DataTable searchsokhung(string key)
        {
            string select = "select * from PhieuBaoHanh where SOKHUNG like '%" + key + "%'";
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

        public DataTable searchSoMay(string key)
        {
            string select = "select * from PhieuBaoHanh where SOMAY like '%" + key + "%'";
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
