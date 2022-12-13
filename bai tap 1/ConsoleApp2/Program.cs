using System;

namespace ConsoleApp2
{
    class Program
    {
        static void PhuongTrinh(double a, double b)
        {
            if (a == 0 && b != 0)
            {
                Console.WriteLine(" Phuong trinh vo nghiem ");
            }
            else if (b == 0)
            {
                Console.WriteLine(" Phuong trinh vo so nghiem ");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine(" Nghiem phuong trinh la : " + x);
            }
        }

        static int GiaiThua(int n)
        {
            int GT = 1;
            for (int i = 1; i <= n; i++)
            {
                GT = GT * i;
            }

            return GT;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a va b : ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            PhuongTrinh(a, b);

            Console.WriteLine("Nhap n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int kq = GiaiThua(n);
            Console.WriteLine("n! : " + kq);
        }
    }
}




