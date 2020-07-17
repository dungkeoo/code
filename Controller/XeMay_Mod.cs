using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Project.Connection;
using Project.Bussiness;

namespace Project.Controller
{
    class XeMay_Mod
    {
        GetData data = new GetData();


        public string NextID()
        {
            return Utilities.NextID(data.GetLastID("mathang", "mahang"), "MH");
        }

        private string _error;

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public int soluong(string mahang)
        {
            int i = 0;
            string select = "select soluong from MatHang Where MaHang='" + mahang + "'";
            try
            {
                DataTable dt = data.getdata(select);
                i = Convert.ToInt16(dt.Rows[0][0]);
            }
            catch
            {
                Error = data.Error;
            }
            return i;
        }
        public long layGiaBan(string ma)
        {
            long a = 0;
            string select = "select dgBan from MatHang where mahang='" + ma + "'";
            DataTable dt = new DataTable();
            dt = data.getdata(select);
            try
            {
                a = Convert.ToInt64(dt.Rows[0][0]);
            }
            catch (Exception e)
            {
                Error = e.Message;
            }
            return a;
        }


        public DataTable getAll()
        {
            string select = "select mahang,tenhang,nhasx,soluong,dgban,donvitinh,thongtinbaohanh,mota from mathang";
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


        public DataTable getAllBH()
        {
            string select = "select THOIGIANBH,SONGAYBH from BH";
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

        public bool insertHang(XeMay hang)
        {
            string strInsert = "insert into MatHang values( ";
            strInsert += "'" + hang.MaHang + "',";
            strInsert += "N'" + hang.TenHang + "',";
            strInsert += "'" + hang.NhaSX + "',";
            strInsert += "'" + hang.SoLuong + "',";
            strInsert += "'" + hang.Gia + "',";
            strInsert += "'" + hang.BaoHanh + "',";
            strInsert += "'" + hang.DvTinh + "',";
            strInsert += "N'" + hang.MoTa + "')";
            if (!data.UpdateData(strInsert))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public bool updateHang(XeMay hang, string ma)
        {
            string strUpdate = "update Mathang set ";
            strUpdate += "tenhang=N'" + hang.TenHang + "',";
            strUpdate += "nhaSX='" + hang.NhaSX + "',";
            strUpdate += "soluong='" + hang.SoLuong + "',";
            strUpdate += "dgBan='" + hang.Gia + "',";
            strUpdate += "Thongtinbaohanh='" + hang.BaoHanh + "',";
            strUpdate += "donvitinh='" + hang.DvTinh + "',";
            strUpdate += "mota=N'" + hang.MoTa + "' ";
            strUpdate += "where mahang='" + ma + "'";

            if (!data.UpdateData(strUpdate))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }


        public bool deleteHang(string ma)
        {
            string delete = "delete  from mathang where mahang='" + ma + "'";
            if (!data.UpdateData(delete))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

    
        public DataTable Laydsxemay()
        {
            string sql = "select * from MatHang";
            return data.getdata(sql);
        }


        public DataTable searchNhaSanXuat(string key)
        {
            string select = "select mahang,tenhang,nhasx,soluong,dgban,donvitinh,thongtinbaohanh,mota from MatHang where nhasx like '%" + key + "%'";
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

        public DataTable searchTenXe(string key)
        {
            string select = "select mahang,tenhang,nhasx,soluong,dgban,donvitinh,thongtinbaohanh,mota from MatHang where tenhang like '%" + key + "%'";
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

        public DataTable searchMaLoaiXe(string key)
        {
            string select = "select mahang,tenhang,nhasx,soluong,dgban,donvitinh,thongtinbaohanh,mota from MatHang where mahang like '%" + key + "%'";
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

