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
            solution.BT1.Bai1 Tinhso = new solution.BT1.Bai1();
            Tinhso.tinh();
            */

            Console.Write("nhap so luong hanh khach: ");
            int slhk= int.Parse(Console.ReadLine());
            solution.BT2.HanhKhach[] hk = new solution.BT2.HanhKhach[slhk];
            for (int i = 0; i < slhk; i++)
            {
                hk[i] = new solution.BT2.HanhKhach();
                hk[i].nhaphk();
            }
            for (int i = 0; i < slhk; i++)
            {
                hk[i].xuathk();
            }
            for (int i = 0; i < slhk; i++)
            {
                for (int j = 1; j < slhk; j++)
                {
                    if (hk[i].GetTongTien() < hk[j].GetTongTien())
                    {
                        solution.BT2.HanhKhach temp = new solution.BT2.HanhKhach();
                        temp = hk[i];
                        hk[i] = hk[j];
                        hk[j] = temp;
                    }
                }
            }
            Console.Write("danh sach hanh khach sau khi sap xep: ");
            for (int i = 0; i < slhk; i++)
            {
                hk[i].xuathk();
            }
            /*
            Console.WriteLine("Nhap so luong: ");
            int n = Convert.ToInt32(Console.ReadLine());
            solution.BT5.sanpham[] sanpham = new solution.BT5.laptop[n];
            for (int i = 0; i < sanpham.Length; i++)
            {
                sanpham[i] = new solution.BT5.laptop();
                sanpham[i].nhap();
            }
            for (int i = 0; i < n; i++)
            {
                sanpham[i].xuat();
            }

            sanpham = new solution.BT5.Tivi[n];
            for (int i = 0; i < sanpham.Length; i++)
            {
                sanpham[i] = new solution.BT5.Tivi();
                sanpham[i].nhap();
            }
            for (int i = 0; i < n; i++)
            {
                sanpham[i].xuat();
            }
            sanpham = new solution.BT5.Dieuhoa[n];
            for (int i = 0; i < sanpham.Length; i++)
            {
                sanpham[i] = new solution.BT5.Dieuhoa();
                sanpham[i].nhap();
            }
            for (int i = 0; i < n; i++)
            {
                sanpham[i].xuat();
            }
            */
            Console.ReadKey();
        }
    }
}
