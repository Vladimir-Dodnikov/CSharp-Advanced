using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputSongs = Console.ReadLine().Split(", ");

            Queue<string> songs = new Queue<string>(inputSongs);

            while (songs.Count > 0)
            {
                string input = Console.ReadLine();

                var command = input.Split(new[] { ' ' }, 2);

                switch (command[0])
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string toAddSong = command[1];
                        if (!songs.Contains(toAddSong))
                        {
                            songs.Enqueue(toAddSong);
                        }
                        else
                        {
                            Console.WriteLine($"{toAddSong} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
