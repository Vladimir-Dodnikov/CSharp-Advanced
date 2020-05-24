using System;

namespace CustomLinkedList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var linkedList = new DoubleLinkedList<int>();
            linkedList.AddFirst(5);
            linkedList.AddFirst(10);
            linkedList.AddFirst(15);
            Console.WriteLine((int)linkedList.Head == 15);
            Console.WriteLine((int)linkedList.Tail == 5);
            Console.WriteLine(linkedList.Count == 3);

            linkedList.AddLast(20);
            linkedList.AddLast(25);

            linkedList.ForEach(Console.WriteLine, true);
            var arr = linkedList.ToArray();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine((int)linkedList.Head == 15);
            Console.WriteLine((int)linkedList.Tail == 25);
            Console.WriteLine(linkedList.Count == 5);

            Console.WriteLine((int)linkedList.RemoveFirst() == 15);
            Console.WriteLine((int)linkedList.RemoveLast() == 10);
            Console.WriteLine((int)linkedList.Head == 5);
            Console.WriteLine((int)linkedList.Count == 3);

            Console.WriteLine((int)linkedList.RemoveLast() == 25);
            Console.WriteLine((int)linkedList.RemoveLast() == 20);
            Console.WriteLine((int)linkedList.RemoveLast() == 5);
            Console.WriteLine((int)linkedList.Count == 0);
            try
            {
                Console.WriteLine(linkedList.Head);
                Console.WriteLine(false);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine(true);
            }
            linkedList = new DoubleLinkedList<int>();
            linkedList.AddLast(5);
            linkedList.AddLast(10);
            linkedList.AddLast(5);
            linkedList.AddLast(20);
            linkedList.AddLast(5);

            linkedList.Remove(5);

            Console.WriteLine((int)linkedList.Head == 10);
            Console.WriteLine((int)linkedList.Tail == 20);
            Console.WriteLine(linkedList.Contains(10));
            Console.WriteLine(linkedList.Contains(20));
            Console.WriteLine(linkedList.Contains(5) == false);
            Console.WriteLine(linkedList.Count == 2);

            linkedList.Clear();
            Console.WriteLine(linkedList.Count == 0);
            Console.WriteLine(linkedList.Contains(10) == false);
            Console.WriteLine(linkedList.Contains(20) == false);
            linkedList.AddLast(1234);
            linkedList.AddLast(5678);
            linkedList.AddLast(13579);
            linkedList.AddLast(2468);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
