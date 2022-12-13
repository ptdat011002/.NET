using System;
using System.IO;
using System.Threading;

namespace KT
{
    internal class Program
    {
        public static bool check_changed = false;
        public static void CT1()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhap noi dung: ");
                    string a = Console.ReadLine();
                    File.AppendAllText("D:\\doc_file.txt", a);
                    check_changed = true;
                    if (a == "!") break;
                    Thread.Sleep(5);
                    //Console.ReadKey();
                }
                catch (Exception) { }
            }
        }
        public static void CT2()
        {
            while (true)
            {
                try
                {
                    if (check_changed == true)
                    {
                        string s = File.ReadAllText("D:\\doc_file.txt");
                        Console.WriteLine("Noi dung trong file: " + s);
                        if (s == "!") break;
                        Thread.Sleep(10);
                        check_changed = false;
                        //Console.ReadKey();
                    }
                }
                catch (Exception)
                { }
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(CT1);
            t1.Start();
            Thread t2 = new Thread(CT2);
            t2.Start();
        }
    }
}