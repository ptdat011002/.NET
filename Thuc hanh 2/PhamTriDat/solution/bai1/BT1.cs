using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamTriDat.solution.BT1
{
    class Bai1
    {
        public void tinh()
        {
            Console.WriteLine("nhap a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a >= 0 && b >= 0)
            {
                if(a == 0 && b == 0)
                {
                    Console.WriteLine("khong co UCLN va BCNN");
                }
                else if(a == 0 || b == 0)
                {
                    Console.WriteLine("khong co BCNN");
                    Console.WriteLine("UCLN = " + (a == 0 ? b : a));
                }
                else
                {
                    int Boi = a * b;
                    while(a != b)
                    {
                        if(a > b)
                        {
                            a -= b;
                        }
                        else
                        {
                            b -= a;
                        }
                    }
                    Console.WriteLine("UCLN = " + a);
                    Console.WriteLine("BCNN = " + Boi / a);
                }
            }
            else
            {
                Console.WriteLine("a, b phai la so nguyen duong");
            }
        }
    }
}
