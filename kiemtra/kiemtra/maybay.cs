using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtra
{
    class maybay
    {
        private string _mamaybay;
        private string _tenmaybay;
        private int _namsanxuat;
        private string _hangsanxuat;
        private string _khuvucdo;

        public string Mamaybay { get => _mamaybay; set => _mamaybay = value; }
        public string Tenmaybay { get => _tenmaybay; set => _tenmaybay = value; }
        public int Namsanxuat { get => _namsanxuat; set => _namsanxuat = value; }
        public string Hangsanxuat { get => _hangsanxuat; set => _hangsanxuat = value; }
        public string Khuvucdo { get => _khuvucdo; set => _khuvucdo = value; }

        public maybay() { }
    }
}
