using System;
using System.Linq;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var listyIterator = new ListyIterator<string>(Console.ReadLine().Split().Skip(1));

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                try
                {
                    switch (input)
                    {
                        case "Move":
                            Console.WriteLine(listyIterator.Move());
                            break;
                        case "Print":
                            listyIterator.Print();
                            break;
                        case "HasNext":
                            Console.WriteLine(listyIterator.HasNext);
                            break;
                        case "PrintAll":
                            Console.WriteLine(string.Join(" ", listyIterator));
                            break;
                    }
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
