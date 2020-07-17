using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Project.Connection;
using Project.Bussiness;

namespace Project.Controller
{
    class ChiTietBaoHanh_Mod
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
            return Utilities.NextID(data.GetLastID("CTBaoHanh", "MACTBH"), "MACTBH");
        }


        public DataTable getAll()
        {
            string select = "select * from CTBaoHanh";
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

        public bool insertChitietBH(ChiTietBaoHanh nv)
        {
            string strInsert = "insert into CTBaoHanh values( ";
            strInsert += "'" + nv.MaCTBH + "',";
            strInsert += "'" + nv.MaPhieuBH + "',";
            strInsert += "'" + nv.NgayBH + "',";
            strInsert += "N'" + nv.NoiDungBH + "')";
            if (!data.UpdateData(strInsert))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public bool updateChitietBH(ChiTietBaoHanh nv, string ma1, string ma2)
        {
            string strUpdate = "update CTBaoHanh set ";
            strUpdate += "MACTBH='" + nv.MaCTBH+ "',";
            strUpdate += "MAPHIEUBH='" + nv.MaPhieuBH + "',";
            strUpdate += "NGAYBH='" + nv.NgayBH + "',";
            strUpdate += "NOIDUNGBH=N'" + nv.NoiDungBH + "'";
            strUpdate += "where MACTBH='" + ma1 + "'";
            strUpdate += "and MAPHIEUBH='" + ma2 + "'";
            if (!data.UpdateData(strUpdate))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }


        public bool deleteCTPBH(string ma)
        {
            string delete = "delete  from CTBaoHanh where MACTBH='" + ma + "'";
            if (!data.UpdateData(delete))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }



        public DataTable LaydsCTBH()
        {
            string sql = "select * from CTBaoHanh";
            return data.getdata(sql);
        }


        public DataTable searchmabh(string key)
        {
            string select = "select * from CTBaoHanh where MACTBH like '%" + key + "%'";
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

        public DataTable searchmachitietbh(string key)
        {
            string select = "select * from CTBaoHanh where MACTBH like '%" + key + "%'";
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

        public DataTable searchngaybh(string key)
        {
            string select = "select * from CTBaoHanh where NGAYBH like '%" + key + "%'";
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
