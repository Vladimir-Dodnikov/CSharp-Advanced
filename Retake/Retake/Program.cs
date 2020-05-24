using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Retake
{
    class Program
    {
        static void Main()
        {
            var toys = new Dictionary<string, int>();
            toys.Add("Doll", 150);
            toys.Add("Wooden train", 250);
            toys.Add("Teddy bear", 300);
            toys.Add("Bicycle", 400);

            Stack<int> materials = new Stack<int>(
                Console.ReadLine()
                .Split(" ")
                .Select(int.Parse));

            Queue<int> magicValues = new Queue<int>(
                Console.ReadLine()
                .Split()
                .Select(int.Parse));

            var sortedCrafts = new SortedDictionary<string, int>();
            sortedCrafts.Add("Doll", 0);
            sortedCrafts.Add("Wooden train", 0);
            sortedCrafts.Add("Teddy bear", 0);
            sortedCrafts.Add("Bicycle", 0);

            while (materials.Count != 0 || magicValues.Count != 0)
            {
                if (materials.Count == 0 || magicValues.Count == 0)
                {
                    break;
                }

                int material = materials.Peek();
                int magicValue = magicValues.Peek();

                int calculatedSum = material * magicValue;

                if (material == 0)
                {
                    materials.Pop();
                }
                else if (magicValue == 0)
                {
                    magicValues.Dequeue();
                }
                else if (material < 0 || magicValue < 0)
                {
                    int sum = material + magicValue;
                    materials.Pop();
                    magicValues.Dequeue();

                    materials.Push(sum);
                }
                else if (!toys.ContainsValue(calculatedSum))
                {
                    magicValues.Dequeue();
                    material += 15;
                    materials.Pop();
                    materials.Push(material);
                }
                else
                {
                    int calculatedSum2 = material * magicValue;
                    if (toys["Doll"] == calculatedSum2)
                    {
                        sortedCrafts["Doll"]++;
                        materials.Pop();
                        magicValues.Dequeue();
                    }
                    else if (toys["Wooden train"] == calculatedSum2)
                    {
                        sortedCrafts["Wooden train"]++;

                        materials.Pop();
                        magicValues.Dequeue();
                    }
                    else if (toys["Teddy bear"] == calculatedSum2)
                    {
                        sortedCrafts["Teddy bear"]++;

                        materials.Pop();
                        magicValues.Dequeue();
                    }
                    else if (toys["Bicycle"] == calculatedSum2)
                    {
                        sortedCrafts["Bicycle"]++;

                        materials.Pop();
                        magicValues.Dequeue();
                    }
                }
            }

            if ((sortedCrafts["Doll"] > 0 && sortedCrafts["Wooden train"] > 0) ||
                (sortedCrafts["Teddy bear"] > 0 && sortedCrafts["Bicycle"] > 0))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }
            if (materials.Count > 0)
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
            }
            if (magicValues.Count > 0)
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magicValues)}");
            }

            foreach (var toy in sortedCrafts.Where(t => t.Value > 0))
            {
                Console.WriteLine($"{toy.Key}: {toy.Value}");
            }
        }
    }
}
