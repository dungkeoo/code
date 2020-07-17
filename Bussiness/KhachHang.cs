using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Bussiness
{
    class KhachHang
    {
        private string _maKH;

        public string MaKH
        {
            get { return _maKH; }
            set { _maKH = value; }
        }
        private string _tenKH;

        public string TenKH
        {
            get { return _tenKH; }
            set { _tenKH = value; }
        }
        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private long _dienThoai;

        public long DienThoai
        {
            get { return _dienThoai; }
            set { _dienThoai = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
