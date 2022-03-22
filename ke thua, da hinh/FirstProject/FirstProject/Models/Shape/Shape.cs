using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Models.Shape
{
    /*public abstract class Shape
    {
        public abstract void Nhap();
        public abstract void Xuat();
        public abstract float getArea();
    }
    */
    public interface Shape
    {
        void Nhap();
        void Xuat();
        float getArea();
    }
}
