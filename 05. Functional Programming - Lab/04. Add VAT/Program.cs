using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse);
                //.Select(x=>x*1.20M)

            var numWithVAT = numbers.Select(c => c * 1.20M);

            Console.WriteLine(string.Join("\r\n", numWithVAT));
        }
    }
}
