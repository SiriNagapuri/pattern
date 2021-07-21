using System;

namespace pattern
{
    class Program
    {
        // No Need to Add test cases for simple program file
        static void Main(string[] args)
        {
            Console.Write("Number of rows : ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Number of symbols : ");
            int symbol = int.Parse(Console.ReadLine());

            //looping number of rows 
            for (int i = 0; i < row; i++)
            {
                //displaying number of symbols in same row 
                for (int j = 0; j < symbol; j++)
                {
                    Console.Write("/\\");
                }
                Console.WriteLine();
                if (i != row - 1)
                {
                    Console.Write("|");

                    //looping symbol*2 times to dispaly a space
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
