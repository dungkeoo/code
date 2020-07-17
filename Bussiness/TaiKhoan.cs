using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Bussiness
{
    public class TaiKhoan
    {
        string _tenTK;

        public string TenTK
        {
            get { return _tenTK; }
            set { _tenTK = value; }
        }
        string _matKhau;

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }
        string _diachi;

        public string Diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        long _dienthoai;

        public long Dienthoai
        {
            get { return _dienthoai; }
            set { _dienthoai = value; }
        }
        string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        string _quyenDN;

        public string QuyenDN
        {
            get { return _quyenDN; }
            set { _quyenDN = value; }
        }

    }
}
