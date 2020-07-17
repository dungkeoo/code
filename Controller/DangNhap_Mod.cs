using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Project.Controller
{
    public class DangNhap_Mod
    {
        string Error;
        Project.Connection.GetData data = new Project.Connection.GetData();



        public DataTable dt(string dn, string mk)
        {
            string select = "select quyen from TaiKhoan where taikhoan='" + dn + "' and matkhau='" + mk + "'";
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

        public DataTable getAll()
        {
            string select = "select * from TaiKhoan ";
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

