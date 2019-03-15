using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número de linhas: ");
            string r = Console.ReadLine();
            int row = Convert.ToInt32(r);
            Console.WriteLine("Insira o número de colunas: ");
            string c = Console.ReadLine();
            int columns = Convert.ToInt32(c);

            int[,] matrix = new int[row, columns];

            Console.WriteLine("Insere valor a guardar");
            string s1 = Console.ReadLine();
        }
    }
}
