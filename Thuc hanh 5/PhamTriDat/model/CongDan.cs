using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamTriDat.model
{
    class CongDan
    {
        private string _MaCD;
        private string _MaPhuong;
        private string _TenCD;
        private string _CMND;
        private string _GioiTinh;
        private int _NamSinh;
        private string _SoDienThoai;

        public string MaCD { get => _MaCD; set => _MaCD = value; }
        public string MaPhuong { get => _MaPhuong; set => _MaPhuong = value; }
        public string TenCD { get => _TenCD; set => _TenCD = value; }
        public string CMND { get => _CMND; set => _CMND = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public int NamSinh { get => _NamSinh; set => _NamSinh = value; }
        public string SoDienThoai { get => _SoDienThoai; set => _SoDienThoai = value; }

        public CongDan() { }
    }
}
