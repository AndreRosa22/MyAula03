using System;

namespace PrecorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            //Pede uma string
            Console.WriteLine("Insere uma frase");
            string s = Console.ReadLine();
            //Pede um char
            Console.WriteLine("Insere um char");
            string cSTR = Console.ReadLine();
            c = cSTR[0];

            //Imprime string
            //Precorre string
            foreach (char cInString in s)
            {
                if (cInString != c)
                {
                    Console.Write(cInString);
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
