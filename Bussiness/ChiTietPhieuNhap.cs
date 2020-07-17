using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Bussiness
{
    class ChiTietPhieuNhap
    {
        private string _maPN;

        public string MaPN
        {
            get { return _maPN; }
            set { _maPN = value; }
        }
        private string _MaHang;

        public string MaHang
        {
            get { return _MaHang; }
            set { _MaHang = value; }
        }
        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        private long _donGia;

        public long DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }
        private float _thue;

        public float Thue
        {
            get { return _thue; }
            set { _thue = value; }
        }
    }
}
