using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Bussiness
{
    class XeMay
    {
        private string _maHang;
        private string _tenHang;
        private string _nhaSX;
        private int _soLuong;
        private long _gia;
        private string _baoHanh;
        private string _dvTinh;
        private string _moTa;
       

        public string MaHang
        {
            get { return _maHang; }
            set { _maHang = value; }
        }

        public string TenHang
        {
            get { return _tenHang; }
            set { _tenHang = value; }
        }

        public string NhaSX
        {
            get { return _nhaSX; }
            set { _nhaSX = value; }
        }

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }


        public long Gia
        {
            get { return _gia; }
            set { _gia = value; }
        }

        public string BaoHanh
        {
            get { return _baoHanh; }
            set { _baoHanh = value; }
        }

        public string DvTinh
        {
            get { return _dvTinh; }
            set { _dvTinh = value; }
        }

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }

    
    }
}
