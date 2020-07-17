using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.Connection;
using Project.Bussiness;
using System.Data;

namespace Project.Controller
{
    class QLNhapHang_Mod
    {
        GetData data = new GetData();
        string _error;


        public string NextID()
        {
            return Utilities.NextID(data.GetLastID("PNhap", "MaPn"), "MAPN");
        }
        
        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public DataTable GetAll()
        {
            string select = "select pnhap.mapn , ngaynhap , tennhanvien , tennhacungcap ,tenhang, slnhap ,dongianhap ,thue , slnhap*dongianhap as thanhtien from (((nhanvien inner join pnhap on pnhap.manhanvien=nhanvien.manhanvien)inner join nhacungcap on nhacungcap.manhacungcap=pnhap.manhacungcap)inner join ctpnhap on ctpnhap.mapn=pnhap.mapn)inner join mathang on mathang.mahang=ctpnhap.mahang";
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


        public DataTable view(string mahd)
        {
            string select = "select * from v_PNhap where Mapn='" + mahd + "'";
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


        public bool insertPN(PhieuNhap pn)
        {
            string insert = "insert into Pnhap values(";
            insert += "'" + pn.MaPN + "',";
            insert += "'" + pn.NgayNhap + "',";
            insert += "'" + pn.MaNV + "',";
            insert += "'" + pn.MaNCC + "')";
            if (!data.UpdateData(insert))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public bool insertCTPN(ChiTietPhieuNhap ct)
        {
            string insert = "insert into CTPNhap values(";
            insert += "'" + ct.MaPN + "',";
            insert += "'" + ct.MaHang + "',";
            insert += "'" + ct.SoLuong + "',";
            insert += "'" + ct.DonGia + "',";
            insert += "'" + ct.Thue + "')";
            if (!data.UpdateData(insert))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public bool updateCTPN(ChiTietPhieuNhap ct, string map, string mah)
        {
            string update = "update CTPNhap set ";
            update += "SLNhap='" + ct.SoLuong + "',";
            update += "DonGiaNhap='" + ct.DonGia + "',";
            update += "Thue='" + ct.Thue + "'";
            update += "where MaPN='" + map + "' and ";
            update += "MaHang='" + mah + "'";
            if (!data.UpdateData(update))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public bool deleteCTPN(string map, string mah)
        {
            string delete = "delete from CTPNhap where maPN='" + map + "' and mahang='" + mah + "'";
            if (!data.UpdateData(delete))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public DataTable GetDanhSachNhapHang()
        {
            string select = "select PNhap.MaPn [Mã Phiếu Nhập], ngaynhap [Ngày Nhập], tennhanvien [Nhân Viên], tennhacungcap [Nhà Cung Cấp],tenhang [Tên Hàng], slnhap [Số Lượng],dongianhap [Đơn Giá],thue [Thuế], slnhap*dongianhap as [Thành Tiền] from (((nhanvien inner join pnhap on pnhap.manhanvien=nhanvien.manhanvien)inner join nhacungcap on nhacungcap.manhacungcap=pnhap.manhacungcap)inner join ctpnhap on ctpnhap.mapn=pnhap.mapn)inner join mathang on mathang.mahang=ctpnhap.mahang ";
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

        public DataTable SearchMAPN(string ma)
        {
            string select = "select PNhap.MaPn [Mã Phiếu Nhập], ngaynhap [Ngày Nhập], tennhanvien [Nhân Viên], tennhacungcap [Nhà Cung Cấp],tenhang [Tên Hàng], slnhap [Số Lượng],dongianhap [Đơn Giá],thue [Thuế], slnhap*dongianhap as [Thành Tiền] from (((nhanvien inner join pnhap on pnhap.manhanvien=nhanvien.manhanvien)inner join nhacungcap on nhacungcap.manhacungcap=pnhap.manhacungcap)inner join ctpnhap on ctpnhap.mapn=pnhap.mapn)inner join mathang on mathang.mahang=ctpnhap.mahang where pnhap.mapn  like '%" + ma + "%'";
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

        public DataTable SearchTenNCC(string ma)
        {
            string select = "select PNhap.MaPn [Mã Phiếu Nhập], ngaynhap [Ngày Nhập], tennhanvien [Nhân Viên], tennhacungcap [Nhà Cung Cấp],tenhang [Tên Hàng], slnhap [Số Lượng],dongianhap [Đơn Giá],thue [Thuế], slnhap*dongianhap as [Thành Tiền] from (((nhanvien inner join pnhap on pnhap.manhanvien=nhanvien.manhanvien)inner join nhacungcap on nhacungcap.manhacungcap=pnhap.manhacungcap)inner join ctpnhap on ctpnhap.mapn=pnhap.mapn)inner join mathang on mathang.mahang=ctpnhap.mahang where tennhacungcap  like '%" + ma + "%'";
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

        public DataTable SearchTenNV(string ma)
        {
            string select = "select PNhap.MaPn [Mã Phiếu Nhập], ngaynhap [Ngày Nhập], tennhanvien [Nhân Viên], tennhacungcap [Nhà Cung Cấp],tenhang [Tên Hàng], slnhap [Số Lượng],dongianhap [Đơn Giá],thue [Thuế], slnhap*dongianhap as [Thành Tiền] from (((nhanvien inner join pnhap on pnhap.manhanvien=nhanvien.manhanvien)inner join nhacungcap on nhacungcap.manhacungcap=pnhap.manhacungcap)inner join ctpnhap on ctpnhap.mapn=pnhap.mapn)inner join mathang on mathang.mahang=ctpnhap.mahang where tennhanvien  like '%" + ma + "%'";
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
