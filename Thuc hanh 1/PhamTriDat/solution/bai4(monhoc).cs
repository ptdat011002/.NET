using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamTriDat.solution.b4
{
    public class MonHoc
    {
        private int maMH;
        private string tenMH;
        private int soTC;
        public MonHoc() { }
        public MonHoc(int maMH, string tenMH, int soTC)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.soTC = soTC;
        }
        public virtual void nhap()
        {
            Console.Write("ma mon hoc: ");
            maMH = int.Parse(Console.ReadLine());
            Console.Write("ten mon hoc: ");
            tenMH = Console.ReadLine();
            Console.Write("so tin chi: ");
            soTC = int.Parse(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine($"{maMH}\t {tenMH}\t {soTC}\t");
        }
        public int GetSTC()
        {
            return soTC;
        }
    }
}
