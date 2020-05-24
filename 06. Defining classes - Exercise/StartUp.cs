﻿using System;
using System.Reflection;

namespace OldestFamilyMember
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            var family = new Family();
            var membersNumber = int.Parse(Console.ReadLine());

            while (membersNumber > 0)
            {
                var personData = Console.ReadLine().Split();
                var member = new Person(personData[0], int.Parse(personData[1]));
                family.AddMember(member);

                membersNumber--;
            }

            var oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
