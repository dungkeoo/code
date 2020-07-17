using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Project.Connection;
using Project.Bussiness;

namespace Project.Controller
{
    class NhanVien_Mod
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
            return Utilities.NextID(data.GetLastID("NhanVien", "Manhanvien"), "NV");
        }


        public DataTable getAll()
        {
            string select = "select Manhanvien,tennhanvien,namsinh,gioitinh,dienthoai,diachi,chucvu,luongcoban from NhanVien";
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

        public bool insertNV(NhanVien nv)
        {
            string strInsert = "insert into NhanVien values( ";
            strInsert += "'" + nv.MaNV + "',";
            strInsert += "N'" + nv.TenNV + "',";
            strInsert += "'" + nv.Namsinh + "',";
            strInsert += "'" + nv.GioiTinh + "',";
            strInsert += "'" + "0" + nv.SoDT + "',";
            strInsert += "N'" + nv.DiaChi + "',";
            strInsert += "N'" + nv.ChucVu + "',";
            strInsert += "'" + nv.Luong + "')";
            if (!data.UpdateData(strInsert))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public bool updateNV(NhanVien nv, string ma)
        {
            string strUpdate = "update NhanVien set ";
            strUpdate += "tennhanvien=N'" + nv.TenNV + "',";
            strUpdate += "namsinh='" + nv.Namsinh + "',";
            strUpdate += "gioitinh='" + nv.GioiTinh + "',";
            strUpdate += "dienthoai='" + "0" + nv.SoDT + "',";
            strUpdate += "diachi=N'" + nv.DiaChi + "',";
            strUpdate += "chucvu=N'" + nv.ChucVu + "',";
            strUpdate += "luongcoban='" + nv.Luong + "' ";
            strUpdate += "where manhanvien='" + ma + "'";

            if (!data.UpdateData(strUpdate))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }


        public bool deleteNV(string ma)
        {
            string delete = "delete  from nhanvien where manhanvien='" + ma + "'";
            if (!data.UpdateData(delete))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

    

        public DataTable Laydsnhanvien()
        {
            string sql = "select * from nhanvien";
            return data.getdata(sql);
        }


       public DataTable searchTen(string key)
        {
            string select = "select Manhanvien,tennhanvien,namsinh,gioitinh,dienthoai,diachi,chucvu,luongcoban from nhanvien where tennhanvien like '%" + key + "%'";
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

        public DataTable searchMa(string key)
        {
            string select = "select Manhanvien,tennhanvien,namsinh,gioitinh,dienthoai,diachi,chucvu,luongcoban from nhanvien where Manhanvien like '%" + key + "%'";
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
            string select = "select Manhanvien,tennhanvien,namsinh,gioitinh,dienthoai,diachi,chucvu,luongcoban from nhanvien where diachi like '%" + key + "%'";
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
