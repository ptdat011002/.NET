using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamTriDat.solution.b4
{
    public class sinhvien
    {
        private int masv;
        private String tensv;
        private int soluongTC;
        private tinchi[] TC;
        public sinhvien() { }
        public void nhapsv()
        {
            Console.Write("ma sinh vien: ");
            soluongTC = int.Parse(Console.ReadLine());
            Console.Write("ten sinh vien: ");
            tensv = Console.ReadLine();
            Console.Write("so luong mon da dang ki: ");
            soluongTC = int.Parse(Console.ReadLine());
            TC = new tinchi[soluongTC];
            for (int i = 0; i < soluongTC; i++)
            {
                TC[i] = new tinchi();
                TC[i].nhap();
            }
        }
        public float TongKet()
        {
            float kq = 0;
            int STC = 0;
            for (int i = 0; i < soluongTC; i++)
            {
                kq = kq + TC[i].GetDTB() * TC[i].GetSTC();
                STC = STC + TC[i].GetSTC();
            }
            if (STC != 0)
            {
                kq = kq / STC;
            }
            return kq;
        }
        public void XepLoaiSV()
        {
            if (TongKet() < 6)
            {
                Console.WriteLine("xep loai trung binh");
            }
            else if (TongKet() < 8 && TongKet() >= 6)
            {
                Console.WriteLine("xep loai kha");
            }
            else
            {
                Console.WriteLine("xep loai gioi");
            }
        }
        public void xuatsv()
        {
            Console.WriteLine($"{masv}\t {tensv}\t {soluongTC}\t");
            for (int i = 0; i < soluongTC; i++)
            {
                TC[i].xuat();
            }
            Console.WriteLine(TongKet());
            XepLoaiSV();
        }
    }
}
