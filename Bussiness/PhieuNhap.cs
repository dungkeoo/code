using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Bussiness
{
    class PhieuNhap
    {
        private string _maPN;

        public string MaPN
        {
            get { return _maPN; }
            set { _maPN = value; }
        }
        private string _ngayNhap;

        public string NgayNhap
        {
            get { return _ngayNhap; }
            set { _ngayNhap = value; }
        }
        private string _maNCC;

        public string MaNCC
        {
            get { return _maNCC; }
            set { _maNCC = value; }
        }
        private string _maNV;

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }
    }
}
