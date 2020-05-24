using System;

namespace GenericBoxOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = new Box<string>(Console.ReadLine());
                Console.WriteLine(input.ToString());
            }
        }
    }
}
