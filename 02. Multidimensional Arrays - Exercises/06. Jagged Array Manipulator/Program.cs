using System;
using System.Linq;

namespace _06._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedArr = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                jaggedArr[i] = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();
            }

            Analyze(jaggedArr);

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandInfo = command.Split();
                int targetRow = int.Parse(commandInfo[1]);
                int targetCol = int.Parse(commandInfo[2]);
                int value = int.Parse(commandInfo[3]);

                if (!IsInside(jaggedArr, targetRow, targetCol))
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (command.StartsWith("Add "))
                {
                    jaggedArr[targetRow][targetCol] += value;
                }
                else if (command.StartsWith("Subtract "))
                {
                    jaggedArr[targetRow][targetCol] -= value;
                }


                command = Console.ReadLine();
            }

            foreach (var row in jaggedArr)
            {
                Console.WriteLine(string.Join(" ", row));
            }
            
        }
        //////////////////// generic proverka za jagged dali e validen
        private static bool IsInside(double[][] jaggedArr, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < jaggedArr.Length &&
                   targetCol >= 0 && targetCol < jaggedArr[targetRow].Length;
        }

        private static void Analyze(double[][] jaggedArr)
        {
            for (int row = 0; row < jaggedArr.Length - 1; row++)
            {
                if (jaggedArr[row].Length == jaggedArr[row +1].Length)  //taka se sravnqva celia red
                {
                    for (int col = 0; col < jaggedArr[row].Length; col++)
                    {
                        jaggedArr[row][col] *= 2;
                        jaggedArr[row + 1][col] *= 2;   // za dolnia red
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArr[row].Length; col++)
                    {
                        jaggedArr[row][col] /= 2;       // samo za gornia, poneje ne znaem kolko golqm e dolnia
                    }

                    for (int col = 0; col < jaggedArr[row +1].Length; col++)
                    {
                        jaggedArr[row + 1][col] /= 2;
                    }
                }
            }
        }
    }
}
