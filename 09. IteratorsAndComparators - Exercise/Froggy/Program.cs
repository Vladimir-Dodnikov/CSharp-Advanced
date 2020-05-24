using System;
using System.Linq;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            Lake lake = new Lake(Console.ReadLine().Split(", ").Select(int.Parse));

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
