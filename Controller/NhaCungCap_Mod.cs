using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.Connection;
using Project.Bussiness;
using System.Data;

namespace Project.Controller
{
    class NhaCungCap_Mod
    {
        public string NextID()
        {
            return Utilities.NextID(data.GetLastID("NhaCungCap", "manhacungcap"), "NCC");
        }

        
        private string _error;
        GetData data = new GetData();
        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public DataTable getAll()
        {
            string select = "select manhacungcap,tennhacungcap,Diachi,Dienthoai,Email from NhaCungCap";
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
        public DataTable searchMaNCC(string key)
        {
            string select = "select manhacungcap,tennhacungcap,Diachi,Dienthoai,Email from NhaCungCap where manhacungcap like '%" + key + "%'";
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
        public DataTable searchTenNCC(string key)
        {
            string select = "select manhacungcap,tennhacungcap,Diachi,Dienthoai,Email from NhaCungCap where TenNhaCungCap like '%" + key + "%'";
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
            string select = "select manhacungcap,tennhacungcap,Diachi,Dienthoai,Email from NhaCungCap where Diachi like '%" + key + "%'";
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


        public bool insertNV(NhaCungCap ncc)
        {
            string insert = "insert into NhaCungCap values(";
            insert += "'" + ncc.MaNCC + "',";
            insert += "N'" + ncc.TenNCC + "',";
            insert += "N'" + ncc.Diachi + "',";
            insert += "'" +"0"+ ncc.DienThoai + "',";
            insert += "'" + ncc.Email + "')";
            if (!data.UpdateData(insert))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public bool updateNCC(NhaCungCap ncc, string ma)
        {
            string update = "update NhaCungCap set ";
            update += "TenNhacungcap=N'" + ncc.TenNCC + "',";
            update += "DiaChi=N'" + ncc.Diachi + "',";
            update += "DienThoai='" + "0" + ncc.DienThoai + "',";
            update += "Email='" + ncc.Email + "' ";
            update += "where MaNhaCungCap='" + ma + "'";
            if (!data.UpdateData(update))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public DataTable Laydsnhacungcap()
        {
            string sql = "select * from NhaCungCap";
            return data.getdata(sql);
        }

        public bool deleteNCC(string ma)
        {
            string delete = "delete from NhaCungCap where MaNhaCungCap='" + ma + "'";
            if (!data.UpdateData(delete))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }
    }
}
