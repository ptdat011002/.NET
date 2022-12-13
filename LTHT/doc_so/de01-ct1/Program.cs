using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace de01_ct1
{
    internal class Program
    {
        public static void ct1()
        {
            var rd = new Random();
            while (true)
            {
                try
                {
                    
                    var num = rd.Next(0,int.MaxValue);
                    Console.WriteLine(num);
                    File.WriteAllText("D:\\de01.txt", num.ToString());
                    if (num % 1024 == 0) break;
                }
                catch(Exception)
                { }
            }
        }
        public static void ct2()
        {
            while (true)
            {
                try
                {
                    var s = File.ReadAllText("D:\\de01.txt");
                    Console.WriteLine(s);
                    int a = int.Parse(s);
                    if (a % 1024 == 0) break;
                }
                catch (Exception)
                { }
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(ct1);
            t1.Start();
            Thread t2 = new Thread(ct2);
            t2.Start();
        }
    }
}
