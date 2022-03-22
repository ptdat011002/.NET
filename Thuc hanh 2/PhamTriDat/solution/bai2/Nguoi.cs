using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamTriDat.solution.BT2
{
    class Nguoi
    {
        private string hoten;
        private string gioitinh;
        private int tuoi;
        public Nguoi() { }
        public void nhap()
        {
            Console.WriteLine("nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.WriteLine("nhap gioi tinh: ");
            gioitinh = Console.ReadLine();
            Console.WriteLine("nhap tuoi: ");
            tuoi = Convert.ToInt32(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine($"{hoten}\t{gioitinh}\t{tuoi}\t");
        }
    }
}
