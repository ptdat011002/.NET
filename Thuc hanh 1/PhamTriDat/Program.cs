using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamTriDat
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            solution.b1.bai1 hinhtamgiac = new solution.b1.bai1();
            hinhtamgiac.tamgiac();

            solution.b2.bai2 songuyen = new solution.b2.bai2();
            songuyen.nhapso();
            
            */
            Console.Write("nhap so luong sinh vien: ");
            int slsv = int.Parse(Console.ReadLine());

            solution.b4.sinhvien[] sv = new solution.b4.sinhvien[slsv];

            for (int i = 0; i < slsv; i++)
            {
                sv[i] = new solution.b4.sinhvien();
                sv[i].nhapsv();
            }

            for (int i = 0; i < slsv; i++)
            {
                sv[i].xuatsv();
            }

            Console.ReadKey();
        }
    }
}
