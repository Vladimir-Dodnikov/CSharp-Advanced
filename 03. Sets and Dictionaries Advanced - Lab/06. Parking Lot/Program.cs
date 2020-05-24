using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carPlates = new HashSet<string>();

            string[] command = Console.ReadLine().Split(", ");

            while (command[0] != "END")
            {
                string action = command[0];
                string carPlate = command[1];

                if (action == "IN")
                {
                    carPlates.Add(carPlate);
                }
                else if (action == "OUT")
                {
                    carPlates.Remove(carPlate);
                }

                command = Console.ReadLine().Split(", ");

            }

            if (carPlates.Count > 0)
            {
                foreach (var plate in carPlates)
                {
                    Console.WriteLine(plate);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
