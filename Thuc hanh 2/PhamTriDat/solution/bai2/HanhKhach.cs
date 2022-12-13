using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamTriDat.solution.BT2
{
    class HanhKhach : Nguoi
    {
        private int sove;
        public HanhKhach() { }
        List<VeMayBay> lst = new List<VeMayBay>();
        public void nhaphk()
        {
            base.nhap();
            Console.WriteLine("nhap so ve da mua: ");
            sove = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sove; i++)
            {
                VeMayBay obj = new VeMayBay();
                obj.nhapve();
                lst.Add(obj);
            }
        }

        public int GetTongTien()
        {
            int tong = 0;
            for (int i = 0; i < sove; i++)
            {
                tong = (int)(tong + lst[i].Getgiave());
            }
            return tong;
        }
        public void xuathk()
        {
            base.xuat();
            Console.WriteLine($"{sove}\t");
            for (int i = 0; i < lst.Count; i++)
            {
                lst[i].xuatve();
            }
            Console.WriteLine(GetTongTien());
        }
    }
}
