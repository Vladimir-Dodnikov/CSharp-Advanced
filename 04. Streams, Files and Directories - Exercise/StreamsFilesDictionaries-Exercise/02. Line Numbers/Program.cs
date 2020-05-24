using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var punctuaionMarks = new[] { '-', ',', '.', '!', '?', '\'' };

            using (FileStream inputFile = File.OpenRead(@"../../../text.txt"))
            {
                byte[] buffer = new byte[inputFile.Length];
                inputFile.Read(buffer, 0, buffer.Length);
                var text = Encoding.UTF8.GetString(buffer).Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < text.Length; i++)
                {
                    var line = text[i];
                    var lettersCounter = 0;
                    var punctuationCounter = 0;
                    foreach (var symbol in line)
                    {
                        if (punctuaionMarks.Contains(symbol))
                        {
                            punctuationCounter++;
                        }
                        else if (Char.IsLetter(symbol))
                        {
                            lettersCounter++;
                        }
                    }
                    text[i] = $"Line {i + 1}: {text[i]} ({lettersCounter})({punctuationCounter})";
                }
                //Console.WriteLine(string.Join("\r\n", text));
                Directory.CreateDirectory("../../../output");
                File.WriteAllLines("../../../output/output.txt", text);
            }
        }
    }
}
