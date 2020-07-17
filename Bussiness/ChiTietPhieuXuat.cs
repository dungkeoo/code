using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Bussiness
{
    class ChiTietPhieuXuat
    {

 private string _maPX;

        public string MaPX
        {
            get { return _maPX; }
            set { _maPX = value; }
        }
        private string _maHang;

        public string MaHang
        {
            get { return _maHang; }
            set { _maHang = value; }
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
