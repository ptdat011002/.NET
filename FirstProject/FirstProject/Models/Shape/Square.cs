using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Models.Shape
{
    public class Square : Shape
    {
        private int a;
        public Square() { }
        public void Nhap()
        {
            a = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"{a} x {a}");
        }
        public float getArea()
        {
            return a * a;
        }
    }
}
