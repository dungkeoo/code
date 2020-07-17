using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Project.Connection;
using Project.Controller;
using Project.Bussiness;
namespace Project.Controller
{
    class XuatHang_Mod
    {
        GetData data = new GetData();
        public string Error;
        XeMay_Mod hang = new XeMay_Mod();


        public string NextID()
        {
            return Utilities.NextID(data.GetLastID("PXuat","MaPx"),"MAPX");
        }


        public DataTable getAll(string ma)
        {
            string select = "select PXuat.MaPx [Mã Phiếu Xuất], ngayxuat[Ngày Xuất], tennhanvien [Nhân Viên], tenkhachhang [Khách Hàng],tenhang [Tên Hàng], slxuat [Số Lượng Xuất],dongiaxuat [Đơn Giá Xuất],thue[Thuế], slxuat*dongiaxuat as [Thành Tiền] from (((nhanvien inner join pxuat on pxuat.manhanvien=nhanvien.manhanvien)inner join khachhang on khachhang.makhachhang=pxuat.makhachhang)inner join ctpxuat on ctpxuat.mapx=pxuat.mapx)inner join mathang on mathang.mahang=ctpxuat.mahang where pxuat.mapx='" + ma + "'";
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

        public DataTable getDanhSachXuatHang()
        {
            string select = "select PXuat.MaPx [Mã Phiếu Xuất], ngayxuat[Ngày Xuất], tennhanvien [Nhân Viên], tenkhachhang [Khách Hàng],tenhang [Tên Hàng], slxuat [Số Lượng Xuất],dongiaxuat [Đơn Giá Xuất],thue[Thuế], slxuat*dongiaxuat as [Thành Tiền] from (((nhanvien inner join pxuat on pxuat.manhanvien=nhanvien.manhanvien)inner join khachhang on khachhang.makhachhang=pxuat.makhachhang)inner join ctpxuat on ctpxuat.mapx=pxuat.mapx)inner join mathang on mathang.mahang=ctpxuat.mahang";
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

       

        public bool insertPX(PhieuXuat px)
        {
            string insert = "insert Pxuat values(";
            insert += "'" + px.MaPX + "',";
            insert += "'" + px.Ngayxuat + "',";
            insert += "'" + px.MaNV + "',";
            insert += "'" + px.MaKH + "')";
            if (!data.UpdateData(insert))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public bool insertCTPX(ChiTietPhieuXuat ctpx)
        {
            string insert = "insert CTPxuat values(";
            insert += "'" + ctpx.MaPX + "',";
            insert += "'" + ctpx.MaHang + "',";
            insert += "'" + ctpx.SoLuong + "',";
            insert += "'" + ctpx.DonGia + "',";
            insert += "'" + ctpx.Thue + "')";
            if (!data.UpdateData(insert))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public bool updateCTPX(ChiTietPhieuXuat ctpx, string mapx, string mah)
        {
            string update = "update CTPxuat set ";
            update += "SLXuat='" + ctpx.SoLuong + "',";
            update += "DonGiaXuat='" + ctpx.DonGia + "',";
            update += "Thue= '" + ctpx.Thue + "' ";
            update += "where MaPX='" + mapx + "'";
            update += "and MaHang='" + mah + "'";
            if (!data.UpdateData(update))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }
        public bool deleteCTPX(string mapx, string mah)
        {
            string delete = "delete from CTPXuat where mapx='" + mapx + "' and mahang='" + mah + "'";
            if (!data.UpdateData(delete))
            {
                Error = data.Error;
                return false;
            }
            return true;
        }

        public DataTable SearchMaPX(string ma)
        {
            string select = "select PXuat.MaPx [Mã Phiếu Xuất], ngayxuat[Ngày Xuất], tennhanvien [Nhân Viên], tenkhachhang [Khách Hàng],tenhang [Tên Hàng], slxuat [Số Lượng Xuất],dongiaxuat [Đơn Giá Xuất],thue[Thuế], slxuat*dongiaxuat as [Thành Tiền] from (((nhanvien inner join pxuat on pxuat.manhanvien=nhanvien.manhanvien)inner join khachhang on khachhang.makhachhang=pxuat.makhachhang)inner join ctpxuat on ctpxuat.mapx=pxuat.mapx)inner join mathang on mathang.mahang=ctpxuat.mahang where pxuat.mapx  like '%" + ma + "%'";
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

        public DataTable SearchTenKH(string ma)
        {
            string select = "select PXuat.MaPx [Mã Phiếu Xuất], ngayxuat[Ngày Xuất], tennhanvien [Nhân Viên], tenkhachhang [Khách Hàng],tenhang [Tên Hàng], slxuat [Số Lượng Xuất],dongiaxuat [Đơn Giá Xuất],thue[Thuế], slxuat*dongiaxuat as [Thành Tiền] from (((nhanvien inner join pxuat on pxuat.manhanvien=nhanvien.manhanvien)inner join khachhang on khachhang.makhachhang=pxuat.makhachhang)inner join ctpxuat on ctpxuat.mapx=pxuat.mapx)inner join mathang on mathang.mahang=ctpxuat.mahang where tenkhachhang  like '%" + ma + "%'";
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
            string select = "select PXuat.MaPx [Mã Phiếu Xuất], ngayxuat[Ngày Xuất], tennhanvien [Nhân Viên], tenkhachhang [Khách Hàng],tenhang [Tên Hàng], slxuat [Số Lượng Xuất],dongiaxuat [Đơn Giá Xuất],thue[Thuế], slxuat*dongiaxuat as [Thành Tiền] from (((nhanvien inner join pxuat on pxuat.manhanvien=nhanvien.manhanvien)inner join khachhang on khachhang.makhachhang=pxuat.makhachhang)inner join ctpxuat on ctpxuat.mapx=pxuat.mapx)inner join mathang on mathang.mahang=ctpxuat.mahang where tennhanvien  like '%" + ma + "%'";
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

        public DataTable view(string mapx)
        {
            string select = "select * from v_PXuat where maPx='" + mapx + "'";
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
