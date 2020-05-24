using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04._Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = File.ReadAllLines(@"..\..\..\FileOne.txt").ToList();
            //list.AddRange(File.ReadAllLines(@"..\..\..\FileTwo.txt"));
            //list.Sort();
            //File.WriteAllLines(@"..\..\..\Output.txt", list);

            List<string> lines = new List<string>();
            using (var readerOne = new StreamReader("D:../../../FileOne.txt"))
            {
                while (!readerOne.EndOfStream)
                {
                    lines.Add(readerOne.ReadLine());
                }
            }
            using (var readerTwo = new StreamReader("D:../../../FileTwo.txt"))
            {
                while (!readerTwo.EndOfStream)
                {
                    lines.Add(readerTwo.ReadLine());
                }
            }

            lines.Sort();
            using (var writer = new StreamWriter("D:../../../FileThree.txt"))
            {
                writer.WriteLine(string.Join(Environment.NewLine, lines));
            }
        }
    }
}
