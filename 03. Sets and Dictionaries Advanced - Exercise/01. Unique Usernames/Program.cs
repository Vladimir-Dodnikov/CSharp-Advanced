using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var uniqueUsernames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                uniqueUsernames.Add(Console.ReadLine().Trim());
            }

            Console.WriteLine(string.Join("\n", uniqueUsernames));
        }
    }
}
