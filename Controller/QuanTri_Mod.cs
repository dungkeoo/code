using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Project.Bussiness;

namespace Project.Controller
{
    public class QuanTri_Mod
    {
        public string Error;
        Project.Connection.GetData data = new Project.Connection.GetData();

        public DataTable getAll()
        {
            string select = "select TaiKhoan,MatKhau,DienThoai,DiaChi,Email,Quyen from TaiKhoan";
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
        public bool insertTK(TaiKhoan tk)
        {
            string insert = "insert into TaiKhoan values(";
            insert += "'" + tk.TenTK + "',";
            insert += "'" + tk.MatKhau + "',";
            insert += "'" + "0"+tk.Dienthoai+ "',";
            insert += "N'" + tk.Diachi + "',";
            insert += "'" + tk.Email + "',";
            insert += "'" + tk.QuyenDN + "')";
            if (!data.UpdateData(insert))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public bool updateTK(TaiKhoan tk, string ten, string mk)
        {
            string update = "update TaiKhoan set ";
            update += "DiaChi=N'" + tk.Diachi + "',";
            update += "DienThoai='" + "0" + tk.Dienthoai + "',";
            update += "Email='" + tk.Email + "',";
            update += "Quyen='" + tk.QuyenDN + "' ";
            update += "Where TaiKhoan='" + ten + "' ";
            update += "and MatKhau='" + mk + "'";
            if (!data.UpdateData(update))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public bool deleteTK(string ten)
        {
            string delete = "delete from taikhoan where taikhoan='" + ten + "'";
            if (!data.UpdateData(delete))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public DataTable searchTen(string key)
        {
            string select = "select TaiKhoan,MatKhau,DienThoai,DiaChi,Email,Quyen from TaiKhoan where TaiKhoan like '%" + key + "%'";
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
            string select = "select TaiKhoan,MatKhau,DienThoai,DiaChi,Email,Quyen from TaiKhoan where DiaChi like '%" + key + "%'";
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

        public DataTable searchEmail(string key)
        {
            string select = "select TaiKhoan,MatKhau,DienThoai,DiaChi,Email,Quyen from TaiKhoan where Email like '%" + key + "%'";
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

        public bool updateMK(string ma, string ten)
        {
            string update = "update TaiKhoan set Matkhau='" + ma + "' where taikhoan='" + ten + "'";
            if (!data.UpdateData(update))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }
    }
}
