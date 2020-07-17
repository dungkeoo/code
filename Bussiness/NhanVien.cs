using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Bussiness
{
    class NhanVien
    {
        private string _maNV;

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }
        private string _tenNV;

        public string TenNV
        {
            get { return _tenNV; }
            set { _tenNV = value; }
        }
        private string _gioiTinh;

        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }
        private string _namsinh;

        public string Namsinh
        {
            get { return _namsinh; }
            set { _namsinh = value; }
        }
        private string _chucVu;

        public string ChucVu
        {
            get { return _chucVu; }
            set { _chucVu = value; }
        }
        private long _luong;

        public long Luong
        {
            get { return _luong; }
            set { _luong = value; }
        }
        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private long _soDT;

        public long SoDT
        {
            get { return _soDT; }
            set { _soDT = value; }
        }

    }
}
