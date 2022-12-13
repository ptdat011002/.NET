using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstProject.Models;

namespace FirstProject
{
    class Program
    {
        static void Mang1Chieu()
        {
            int[] a;
            int n;
            Console.Write("Nhap n = ");
            n = Convert.ToInt32(Console.ReadLine());
            a = new int[n];

            Console.WriteLine("Nhap cac phan tu cua mang: ");
            // Duyệt từ a[0] => a[n]
            for (int i=0; i<n; i++)
            {
                // Xét trường hợp a[i]
                Console.Write($"a[{i}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Cac phan tu mang la: ");
            for(int i=0; i<n; i++)
            {
                Console.Write($"{a[i]}\t");
            }
        }

        static void MangNhieuChieuRectagular()
        {
            int[,] a;
            int m, n;
            Console.Write("Nhap so hang m = ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot n = ");
            n = Convert.ToInt32(Console.ReadLine());

            // Cấp phát bộ nhớ cho ma trận
            a = new int[m, n];

            Console.WriteLine("Nhap cac phan tu cua ma tran:");
            // Duyệt từ hàng 0 => hàng m - 1;
            for (int i = 0; i < m; i++)
            {
                // Xét hàng thứ i
                // Duyệt từ cột 0 => cột n - 1 của hàng i
                for (int j = 0; j < n; j++)
                {
                    // Xét hàng i, cột j
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
        }

        static void MangNhieuChieuJaggle()
        {
            int[][] a;
            int m;
            Console.Write("Nhap so hang m = ");
            m = Convert.ToInt32(Console.ReadLine());
            // Cấp phát cho chỉ số hàng
            a = new int[m][];
            // Xét từ hàng 0 => hàng m - 1;
            for (int i = 0; i < m; i++)
            {
                // Xét hàng thứ i
                // Cấp phát bộ nhớ cho các cột của hàng thứ i
                int n;
                Console.Write($"Nhap so cột của hàng {i}: n = ");
                n = Convert.ToInt32(Console.ReadLine());
                // Cấp phát bộ nhớ cho các cột của hàng thứ i
                a[i] = new int[n];

                // Duyệt từ cột 0 => cột n - 1 của hàng i
                for (int j = 0; j < n; j++)
                {
                    // Xét với a[i][j]
                    Console.Write($"a[{i}][{j}] = ");
                    a[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Ma tran vua nhap la: ");
            for (int i = 0; i < m; i++)
            {
                // Vì chỉ số cột của từng hàng là khác nhau
                // Lấy số lượng phần tử của mảng thông qua thuộc tính Length
                /*for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }*/
                foreach(int item in a[i])
                {
                    // Xét với mỗi item trong mảng a[i]
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            // Tạo 1 danh sách Sinh viên để quản lý
            List<SinhVien> lst = new List<SinhVien>();
            for(int i=0; i<3; i++)
            {
                // Tạo 1 sinh viên
                SinhVien obj = new SinhVien();
                obj.Nhap();
                // Thêm sinh viên này vào danh sách
                lst.Add(obj);
            }

            for(int i=0; i<lst.Count; i++)
            {
                lst[i].Xuat();
            }



            //try
            //{
            //    // Phuong trinh ax + b = 0
            //    int a = 0, b = 1;
            //    Console.Write("Nhap a = ");
            //    a = int.Parse(Console.ReadLine());
            //    if (a % 2 == 0)
            //    {
            //        throw new Exception("A khong duoc la so chan!");
            //    }
            //    Console.Write("Nhap b = ");
            //    b = int.Parse(Console.ReadLine());
            //    int x = -b / a;
            //    Console.WriteLine($"Phuong trinh co nghiem x = {x}");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            //Console.WriteLine("Giai phuong trinh thanh cong!");
            Console.ReadKey();
        }
    }
}
