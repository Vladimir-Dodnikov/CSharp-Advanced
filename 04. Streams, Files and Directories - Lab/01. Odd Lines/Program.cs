using System;
using System.IO;

namespace _01._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader input = new StreamReader("Input.txt"))
            {
                int counter = 0;
               
                while (!input.EndOfStream)
                {
                    var line = input.ReadLine();
                    if (counter %2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    counter++;
                }
            }
        }
    }
}
