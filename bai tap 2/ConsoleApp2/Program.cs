using System;

namespace ConsoleApp2
{
    class Program
    {
        static void MangNhieuChieuRectagular()
        {
            int[,] a;
            int m, n;
            Console.Write("Nhap so hang m = ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot n = ");
            n = Convert.ToInt32(Console.ReadLine());

            a = new int[m, n];
            Console.WriteLine("Nhap cac phan tu cua ma tran: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Ma tran vua nhap la: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
            int max = a[0, 0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }
            Console.WriteLine("Gia tri lon nhat trong ma tran la : " + max);

            int min = a[0, 0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }
            }
            Console.WriteLine("Gia tri nho nhat trong ma tran la : " + min);
        }

        static void MangNhieuChieuJaggle()
        {
            int[][] a;
            int m;
            Console.Write("Nhap so hang: ");
            m = Convert.ToInt32(Console.ReadLine());
            a = new int[m][];
            for (int i = 0; i < m; i++)
            {
                int n;
                Console.Write($"Nhap so cot cua hang {i}:  ");
                n = Convert.ToInt32(Console.ReadLine());
                a[i] = new int[n];

                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i}][{j}] = ");
                    a[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Ma tran vua nhap la: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    sum = sum + a[i][j];
                }
            }
            Console.WriteLine("Tong cua ma tran: " + sum);
        }
        static void Main(string[] args)
        {
            MangNhieuChieuRectagular();
            MangNhieuChieuJaggle();
            Console.ReadKey();
        }
    }
}
