using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject.Model
{
    public class PhongBan
    {
        // Tạo các Fields
        private string _MaPhong;
        private string _TenPhong;

        // Tạo các Properties để truy cập đến các Fields này
        public string MaPhong { get => _MaPhong; set => _MaPhong = value; }
        public string TenPhong { get => _TenPhong; set => _TenPhong = value; }
        
        public PhongBan() { }
    }
}
