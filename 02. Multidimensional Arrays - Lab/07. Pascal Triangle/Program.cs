using System;

namespace _07._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var pascalTriangle = new long[n][];

            for (int i = 0; i < n; i++)
            {
                pascalTriangle[i] = new long[i + 1];
            }

            for (int i = 0; i < n; i++)
            {
                pascalTriangle[i][0] = 1;       //every 1st element in row
                pascalTriangle[i][pascalTriangle[i].Length - 1] = 1; //every last el in a row

                for (int j = 1; j < pascalTriangle[i].Length - 1; j++)
                {
                    pascalTriangle[i][j] = pascalTriangle[i - 1][j] + 
                                           pascalTriangle[i - 1][j - 1];
                }
            }

            foreach (var array in pascalTriangle)
            {
                foreach (var element in array)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
