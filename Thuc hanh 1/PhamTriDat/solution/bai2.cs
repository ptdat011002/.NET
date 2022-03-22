using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamTriDat.solution.b2
{
    class bai2
    {
       public void nhapso()
        {
            Console.Write("Nhap mot so bat ki tu 0 den 9: ");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 0:
                    Console.WriteLine("khong");
                    break;
                case 1:
                    Console.WriteLine("mot");
                    break;
                case 2:
                    Console.WriteLine("hai");
                    break;
                case 3:
                    Console.WriteLine("ba");
                    break;
                case 4:
                    Console.WriteLine("bon");
                    break;
                case 5:
                    Console.WriteLine("nam");
                    break;
                case 6:
                    Console.WriteLine("sau");
                    break;
                case 7:
                    Console.WriteLine("bay");
                    break;
                case 8:
                    Console.WriteLine("tam");
                    break;
                case 9:
                    Console.WriteLine("chin");
                    break;
                default:
                    Console.WriteLine("nhap so khong chinh xac");
                    break;
            }
        }
    }
}
