using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
namespace de07
{
    internal class Program
    {
        public static string c;
        public static bool check_changed = false;
        public static void timer1()
        {
            while(true)
            {
                try
                {
                    Console.Write("a : ");
                    string a = Console.ReadLine();
                    c = a;
                    Console.WriteLine("a = " + c);
                    
                    if (c == "!") break;
                    Thread.Sleep(7);
                }
                catch(Exception)
                { }
            }
        }
        public static void timer2()
        {
            while(true)
            {
                try
                {                  
                        Console.Beep();
                        if (c == "!") break;
                        Thread.Sleep(10);
                }
                catch(Exception)
                { }
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(timer1);
            t1.Start();
            Thread t2 = new Thread(timer2);
            t2.Start();
        }
    }
}
