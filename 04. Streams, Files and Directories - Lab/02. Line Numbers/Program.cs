using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("Input.txt"))
            {
                using(var writer = new StreamWriter("D:../../../Output.txt"))
                {
                    int count = 1;
                    while (!reader.EndOfStream)
                    {
                        writer.WriteLine($"{count}. {reader.ReadLine()}");
                        count++;
                    }
                }
            }
        }
    }
}
