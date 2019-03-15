using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 6;
            //Implementa +1 apenas depois de fazer todas as operações com a var
            int c = a++ + b++;
            int d = 65;
            int e = 32;
            //Implementa +1 antes de fazer qualquer operação com a var
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
