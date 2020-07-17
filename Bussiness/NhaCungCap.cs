using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Bussiness
{
    class NhaCungCap
    {
        private string _maNCC;

        public string MaNCC
        {
            get { return _maNCC; }
            set { _maNCC = value; }
        }
        private string _tenNCC;

        public string TenNCC
        {
            get { return _tenNCC; }
            set { _tenNCC = value; }
        }
        private string _diachi;

        public string Diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
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
