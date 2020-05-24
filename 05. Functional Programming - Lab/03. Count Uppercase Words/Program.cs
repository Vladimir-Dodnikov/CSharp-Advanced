using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var words = text.Split(new char[] { ' ', '.', ',', '-', '?', '!', ':', ';' }, 
                StringSplitOptions.RemoveEmptyEntries);

            var capitalWords = words.Where(x => char.IsUpper(x[0]));

            Console.WriteLine(string.Join("\r\n", capitalWords));
        }
    }
}
