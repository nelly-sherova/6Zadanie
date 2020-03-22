using System;

namespace _6Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            Console.Write("k = ");
            k = Convert.ToInt32(Console.ReadLine());
            int c;
            c = (k+7)%7;
            Console.WriteLine(c);
        }
    }
}
