using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamTriDat.solution.BT5
{
        public class sanpham
        {
            private string ma;
            private string hangsx;
            private int gianhap;
            private int giaban;
            private int soluong;

            public sanpham() { }

            public void nhap()
            {
                Console.Write("\n Ma san pham: ");
                ma = Console.ReadLine();
                Console.Write("Hang san xuat: ");
                hangsx = Console.ReadLine();
                Console.Write("gia nhap: ");
                gianhap = Convert.ToInt32(Console.ReadLine());
                Console.Write("gia ban: ");
                giaban = Convert.ToInt32(Console.ReadLine());
                Console.Write("so luong: ");
                soluong = Convert.ToInt32(Console.ReadLine());
            }
            public void xuat()
            {
                Console.WriteLine($"{ma}\t{hangsx}\t{gianhap}\t{giaban}\t{soluong}\t");
            }
        }
 }
