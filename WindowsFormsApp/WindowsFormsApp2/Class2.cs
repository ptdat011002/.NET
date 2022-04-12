using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Class2
    {
        private string _MaSanPham;
        private string _TenSanPham;
        private int _SoLuongTon;
        private DateTime _NgaySanXuat;
        private DateTime _NgayHetHan;
        private string _NhaCungCap;

        public string MaSanPham { get => _MaSanPham; set => _MaSanPham = value; }
        public string TenSanPham { get => _TenSanPham; set => _TenSanPham = value; }
        public int SoLuongTon { get => _SoLuongTon; set => _SoLuongTon = value; }
        public DateTime NgaySanXuat { get => _NgaySanXuat; set => _NgaySanXuat = value; }
        public DateTime NgayHetHan { get => _NgayHetHan; set => _NgayHetHan = value; }
        public string NhaCungCap { get => _NhaCungCap; set => _NhaCungCap = value; }

        public Class2() { }
    }
}
