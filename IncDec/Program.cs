using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 6;
            int c = a++ + b++;
            int d = 65;
            int e = 32;
            int f = ++d + ++e;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = (a+1) + (b+1) = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("e = " + e);
            Console.WriteLine("f = ++d + ++e = " + f);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
