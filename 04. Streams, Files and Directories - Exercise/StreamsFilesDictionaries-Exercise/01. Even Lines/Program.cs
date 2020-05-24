using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _01._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            //var var reader = new StreamReader(@"../../../text.txt");
            //read all lines
            //reader.Close();

            int lineCount = 0;
            var symbolToReplace = new[] { "-", ",", ".", "!", "?" };
            //StringBuilder sb = new StringBuilder(); //- 1st option
            //List<string> lines = new List<string>(); // 2nd option
            using (var reader = new StreamReader(@"../../../text.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (lineCount %2 == 0)
                    {
                        //split line by space
                        var words = line.Split(' ');
                        //replace words in each symbol
                        for (int i = 0; i < words.Length; i++)
                        {
                            var currentWord = words[i];
                            foreach (var symbol in symbolToReplace)
                            {
                                currentWord = currentWord.Replace(symbol, "@");
                            }
                            words[i] = currentWord;
                        }
                        //reverse the order of the words
                        var result = string.Join(" ", words.Reverse());
                        //print result
                        Console.WriteLine(result);
                        //sb.AppendLine(result); //- 1st option
                        //lines.Add(result); // - 2nd option
                    }
                    lineCount++;
                }
            }
            //File.WriteAllText("otput.txt", sb.ToString());// - 1st option
            //File.WriteAllLines("output.txt", lines); // - 2nd option
        }
    }
}
