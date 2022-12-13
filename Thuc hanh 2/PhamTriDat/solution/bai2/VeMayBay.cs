using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamTriDat.solution.BT2
{
    class VeMayBay
    {
        private string tenchuyen;
        private string ngaybay;
        private int giave;

        public VeMayBay() { }
        public void nhapve()
        {
            Console.WriteLine("nhap ten chuyen bay: ");
            tenchuyen=Console.ReadLine();
            Console.WriteLine("nhap ngay bay: ");
            ngaybay = Console.ReadLine();
            Console.WriteLine("nhap gia ve bay: ");
            giave = Convert.ToInt32(Console.ReadLine());
        }
        public void xuatve()
        {
            Console.WriteLine($"{tenchuyen}\t{ngaybay}\t{giave}\t");
        }
        public float Getgiave()
        {
            return giave;
        }
    }
}
