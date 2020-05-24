using System;

namespace _01._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            //Action<string> printAction = item => Console.WriteLine(item);
            Action<string> printAction = Console.WriteLine; //short type
            
            foreach (var name in names)
            {
                printAction(name);
            }
        }
    }
}
