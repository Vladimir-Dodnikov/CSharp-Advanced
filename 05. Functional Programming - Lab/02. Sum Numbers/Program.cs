using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int> parser = x => int.Parse(x);    //.Select(parser)
            var line = Console.ReadLine().Split(", ").Select(Parse);

            Console.WriteLine(line.Count());
            Console.WriteLine(line.Sum());
        }
        static int Parse(string str)
        {
            int number = 0;
            foreach (var ch in str)
            {
                number *= 10; //за двуцифрени
                number += ch - '0';
            }
            return number;
        }
    }
}
