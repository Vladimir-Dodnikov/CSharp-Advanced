using DefinningClasses;
using System;
using System.Reflection;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            //MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            //if (oldestMemberMethod == null || addMemberMethod == null)
            //{
            //    throw new Exception();
            //}

            Family family = new Family();
            var count = int.Parse(Console.ReadLine());

            while (count > 0)
            {
                var personData = Console.ReadLine().Split();
                var member = new Person(personData[0], int.Parse(personData[1]));
                family.AddMember(member);

                count--;
            }

            Person oldestMember = family.GetOldestPerson();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
