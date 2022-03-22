using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models.Shape
{
    /*
    public abstract class Shape
    {
        public abstract void nhap();
        public abstract void xuat();
        public abstract float getArea();
    }
    */
    public interface Shape
    {
        void nhap();
        void xuat();
        float getArea();
    }
    public class Circle : Shape
    {
        private float r;
        public Circle() { }
        public /*override*/ float getArea()
        {
            return (float)Math.PI * r * r;
        }
        public void nhap()
        {
            r = float.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine($"({r})");
        }
    }
    public class Square : Shape
    {
        private int a;
        public Square() { }
        public float getArea()
        {
            return a * a;
        }
        public void nhap()
        {
            a = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine($"{a} x {a}");
        }

        static void Main(string[] args)
        {
            Models.Shape.Shape obj = new Models.Shape.Circle();
            obj.nhap();
            obj.xuat();
            Console.WriteLine("Dien tich hinh tron : " + obj.getArea());
            obj = new Models.Shape.Square();
            obj.nhap();
            obj.xuat();
            Console.WriteLine("Dien tich hinh vuong : " + obj.getArea());
            Console.ReadKey();
        }
    }  
}
