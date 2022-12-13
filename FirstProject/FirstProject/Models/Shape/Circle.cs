using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Models.Shape
{
    public class Circle : Shape
    {
        private float r;
        public Circle() { }
        public void Nhap()
        {
            r = float.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"({r})");
        }
        public float getArea()
        {
            return (float)Math.PI * r * r;
        }
    }
}
