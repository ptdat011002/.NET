using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class nhanvat
    {
        // tạo các fields
        private string _Tennhanvat;
        private string _Quocgia;
        private int _Sosao;
        private string _Vision;
        // tạo các properties để truy cập đến các fields này
        public string Tennhanvat { get => _Tennhanvat; set => _Tennhanvat = value; }
        public string Quocgia { get => _Quocgia; set => _Quocgia = value; }
        public int Sosao { get => _Sosao; set => _Sosao = value; }
        public string Vision { get => _Vision; set => _Vision = value; }

        public nhanvat() { }
    }
}
