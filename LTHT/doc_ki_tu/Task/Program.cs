using System;
using System.Collections.Generic;
using System.Threading;

namespace Task
{
    internal class Program
    {
        public static bool check_changed = false;
        public static bool check = false;
        public static void Task1(object param)
        {
            List<char[]> lst1 = (List<char[]>)param;
            while (true)
            {
                try
                {
                    Console.Write("nhap ki tu: ");
                    string a = Console.ReadLine();
                    char[] b = a.ToCharArray();
                    lst1.Add(b);
                    check_changed = true;
                    if (a == "#") break;
                    check = true;
                }
                catch (Exception) { }
            }
        }
        public static void Task2(object param)
        {
            List<char[]> lst2 = (List<char[]>)param;
            while (true)
            {
                try
                {
                    foreach (char[] item in lst2)
                    {
                        if (check_changed == true)
                        {
                            Console.Write(item);
                        }
                        Thread.Sleep(100);
                    }
                    check_changed = false;
                }
                catch (Exception) { }
            }
        }
        static void Main(string[] args)
        {
            List<char[]> lst = new List<char[]>();
            Thread t1 = new Thread(new ParameterizedThreadStart(Task1));
            t1.Start(lst);
            Thread t2 = new Thread(new ParameterizedThreadStart(Task2));
            t2.Start(lst);
        }
    }
}
