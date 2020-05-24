using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            //Func<int[], int> minFunc = inputNUmber => input.Min();
            Func<int[], int> minFunc = FindMinNumber();

            Console.WriteLine(minFunc(ints));
        }

        private static Func<int[], int> FindMinNumber() //extension metod
        {
            return arr =>
            {
                int min = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (min > arr[i])
                    {
                        min = arr[i];
                    }
                }

                return min;
            };
        }
    }
}
