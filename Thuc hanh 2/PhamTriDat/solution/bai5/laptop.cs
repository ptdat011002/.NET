using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamTriDat.solution.BT5
{
    public class laptop : sanpham
    {
        private string CPU;
        private string RAM;
        private string GPU;
        private string manhinh;

        public laptop() { }
        public void nhaplaptop()
        {
            nhap();

            Console.Write("CPU: ");
            CPU = Console.ReadLine();
            Console.Write("RAM: ");
            RAM = Console.ReadLine();
            Console.Write("GPU: ");
            GPU = Console.ReadLine();
            Console.Write("Loai man hinh: ");
            manhinh = Console.ReadLine();
        }
        public void xuatlaptop()
        {
            xuat();

            Console.WriteLine($"{CPU}\t{RAM}\t{GPU}\t{manhinh}\t");
        }
    }
}
