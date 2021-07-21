using System;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of rows : ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Number of symbols : ");
            int symbol = int.Parse(Console.ReadLine());
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < symbol; j++)
                {
                    Console.Write("/\\");
                }
                Console.WriteLine();
                if (i != row - 1)
                {
                    Console.Write("|");
                    for (int k = 2; k < symbol * 2; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }
            }
        }
    }
}
