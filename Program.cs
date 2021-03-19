using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] multiTable = new int[10,10];
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n");
                for(int j = 1; j <= 10; j++)
                {
                    multiTable[i-1, j-1] = i * j;
                    // Console.WriteLine(multiTable[i-1, j-1]); 
                        // writeline prints the values in separate line

                    Console.Write((i * j).ToString() + "\t");
                }
            }
        }
    }
}
