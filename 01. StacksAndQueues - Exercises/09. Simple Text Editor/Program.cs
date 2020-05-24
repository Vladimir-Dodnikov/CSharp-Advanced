using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> history = new Stack<string>();
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(' ');
                int command = int.Parse(commandArgs[0]);
                switch (command)
                {
                    case 1:
                        history.Push(text.ToString());
                        text.Append(commandArgs[1]);
                        break;
                    case 2:
                        int count = int.Parse(commandArgs[1]);
                        history.Push(text.ToString());

                        if (count > text.Length)
                        {
                            text.Clear();
                            break;
                        }
                        text.Remove(text.Length - count, count);
                        break;
                    case 3:
                        int index = int.Parse(commandArgs[1]);
                        if (index <= text.Length && index > 0)
                        {
                            Console.WriteLine(text[index - 1]);
                        }
                        break;
                    case 4:
                        text.Clear();
                        text.Append(history.Pop());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
