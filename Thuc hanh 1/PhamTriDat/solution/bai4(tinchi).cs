using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamTriDat.solution.b4
{
    public class tinchi : MonHoc
    {
        private float diemTp;
        private float diemthi;
        public tinchi() { }
        public tinchi(float diemTp, float diemthi, int maMH, string tenMH, int soTC) : base(maMH, tenMH, soTC)
        {
            this.diemTp = diemTp;
            this.diemthi = diemthi;
        }
        public virtual void nhap()
        {
            base.nhap();

            Console.Write("diem thanh phan: ");
            diemTp = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("diem thi: ");
            diemthi = (float)Convert.ToDouble(Console.ReadLine());
        }
        public virtual void xuat()
        {
            base.xuat();

            Console.WriteLine($"{diemTp}\t {diemthi}\t");
        }
        public float GetDTB()
        {
            return (float)(diemTp * 0.3 + diemthi * 0.7);
        }
    }
}
