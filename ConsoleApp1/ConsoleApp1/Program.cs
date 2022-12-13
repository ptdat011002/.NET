using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Read
            String S = Console.ReadLine();
            Console.WriteLine("S = " + S);

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " + " + b + "= " + (a + b));
            Console.ReadKey();
        }
    }
}
