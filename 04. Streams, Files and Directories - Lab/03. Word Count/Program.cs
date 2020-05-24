using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            using (var reader = new StreamReader("D:../../../words.txt"))
            {
                string[] text = reader.ReadLine().Split(" ");
                for (int i = 0; i < text.Length; i++)
                {
                    int count = 0;
                    var word = text[i];
                    words.Add(word, 0);
                    using (var read = new StreamReader("D:../../../text.txt"))
                    {
                        while (!read.EndOfStream)
                        {
                            if (read.ReadLine().ToLower().Contains(word))
                            {
                                count++;
                            }
                        }
                    }
                    words[word]=count;
                }

                using (var writer = new StreamWriter("D:../../../Outpout.txt"))
                {
                    foreach (var word in words.OrderByDescending(x=>x.Value))
                    {
                        writer.WriteLine($"{word.Key} - {word.Value}");
                    }
                }
            }
        }
    }
}
