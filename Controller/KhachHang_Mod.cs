using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.Connection;
using Project.Bussiness;
using System.Data;

namespace Project.Controller
{
    class KhachHang_Mod
    {
        private string _error;
        GetData data = new GetData();
        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public string NextID()
        {
            return Utilities.NextID(data.GetLastID("KhachHang", "makhachhang"), "KH");
        }


        public DataTable getAll()
        {
            string select = "select makhachhang,tenkhachhang,Diachi,Dienthoai,Email from KhachHang";
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
      public DataTable searchMaKH(string key)
        {
            string select = "select makhachhang,tenkhachhang,Diachi,Dienthoai,Email from KhachHang where MaKhachHang like '%" + key + "%'";
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
        public DataTable searchTenKH(string key)
        {
            string select = "select makhachhang,tenkhachhang,Diachi,Dienthoai,Email from KhachHang where TenKhachHang like '%" + key + "%'";
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

        public DataTable searchDiaChi(string key)
        {
            string select = "select makhachhang,tenkhachhang,Diachi,Dienthoai,Email from KhachHang where Diachi like '%" + key + "%'";
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


        public bool insertKH(KhachHang khach)
        {
            string insert = "insert into KhachHang values(";
            insert += "'" + khach.MaKH + "',";
            insert += "N'" + khach.TenKH + "',";
            insert += "N'" +  khach.DiaChi + "',";
            insert += "'" + "0" + khach.DienThoai + "',";
            insert += "'" + khach.Email + "')";
            if (!data.UpdateData(insert))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public bool updateKH(KhachHang khach, string ma)
        {
            string update = "update khachhang set ";
            update += "TenKhachHang=N'" + khach.TenKH + "',";
            update += "DiaChi=N'" + khach.DiaChi + "',";
            update += "DienThoai='" + "0" + khach.DienThoai + "',";
            update += "Email='" + khach.Email + "' ";
            update += "where MaKhachHang='" + ma + "'";
            if (!data.UpdateData(update))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public DataTable LaydskhachHang()
        {
            string sql = "select * from KhachHang";
            return data.getdata(sql);
        }

        public bool deleteKH(string ma)
        {
            string delete = "delete from KhachHang where MaKhachhang='" + ma + "'";
            if (!data.UpdateData(delete))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }
    }
}
