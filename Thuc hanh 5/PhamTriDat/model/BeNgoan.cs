using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamTriDat.model
{
    class BeNgoan
    {
		private string _MaBN;
		private string _MaLop;
		private string _TenBeNgoan;
		private DateTime _NgaySinh;
		private string _GioiTinh;
	    private string _HoTenBo;
	    private string _HoTenMe;
	    private string _DiaChi;

        public string MaBN { get => _MaBN; set => _MaBN = value; }
        public string MaLop { get => _MaLop; set => _MaLop = value; }
        public string TenBeNgoan { get => _TenBeNgoan; set => _TenBeNgoan = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string HoTenBo { get => _HoTenBo; set => _HoTenBo = value; }
        public string HoTenMe { get => _HoTenMe; set => _HoTenMe = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }

        public BeNgoan() { }
    }
}
