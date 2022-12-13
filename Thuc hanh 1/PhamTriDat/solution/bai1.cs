using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamTriDat.solution.b1
{
    class bai1
    {
        public void tamgiac()
        {
            Console.WriteLine("nhap chieu cao h: ");
            int h = Convert.ToInt32(Console.ReadLine());
                for(int i=1; i <=h; i++)
                {
                    for(int j=1; j<=h; j++)
                    {
                        if(j<= h - i)
                        {
                            Console.Write("   ");
                        }
                        else
                        {
                            Console.Write("  *");
                        }
                    }
                    Console.WriteLine("\n");
                }          
                Console.WriteLine();
        }
    }
}
