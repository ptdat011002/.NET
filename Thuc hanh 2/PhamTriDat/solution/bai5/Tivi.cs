using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamTriDat.solution.BT5
{
        public class Tivi : sanpham
        {
            private float kichthuoc;
            private string hedh;
            private string chucnang;

            public Tivi() { }
            public void nhapTivi()
            {
                nhap();

                Console.Write("Kich thuoc: ");
                kichthuoc = (float)Convert.ToDouble(Console.ReadLine());
                Console.Write("He dieu hanh: ");
                hedh = Console.ReadLine();
                Console.Write("Chuc nang: ");
                chucnang = Console.ReadLine();
            }
            public void xuatTivi()
            {
                xuat();

                Console.WriteLine($"{kichthuoc}\t{hedh}\t{chucnang}\t");
            }
        }
 }
