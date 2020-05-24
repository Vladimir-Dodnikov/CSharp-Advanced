﻿using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        public static void Main()
        {
            var symbolCounts = GetSymbolCounts();
            PrintCounts(symbolCounts);
        }

        private static void PrintCounts(SortedDictionary<char, int> symbolCounts)
        {
            foreach (var kvp in symbolCounts)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }

        private static SortedDictionary<char, int> GetSymbolCounts()
        {
            var symbolCounts = new SortedDictionary<char, int>();
            string text = Console.ReadLine();
            foreach (var symbol in text)
            {
                if (!symbolCounts.ContainsKey(symbol))
                {
                    symbolCounts[symbol] = 0;
                }
                symbolCounts[symbol]++;
            }

            return symbolCounts;
        }
    }
}
