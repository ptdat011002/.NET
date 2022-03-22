using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamTriDat.solution.BT5
{
    public class Dieuhoa : sanpham
    {
        private string congsuat;
        private string haichieu;

        public Dieuhoa() { }
        public void nhapdh()
        {
            nhap();

            Console.Write("Cong suat: ");
            congsuat = Console.ReadLine();
            Console.Write("Hai chieu: ");
            congsuat = Console.ReadLine();
        }
        public void xuatdh()
        {
            xuat();

            Console.WriteLine($"{congsuat}\t{haichieu}\t");
        }
    }
