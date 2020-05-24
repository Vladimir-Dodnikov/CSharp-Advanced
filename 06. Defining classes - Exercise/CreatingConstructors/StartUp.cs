using CreatingConstructors;
using System;
using System.Reflection;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            var person2 = new Person(2);
            var person3 = new Person("Gosho");
            var person4 = new Person("Tosho, 30");
            //Reflection
            //Type personType = typeof(Person);
            //ConstructorInfo emptyCtor = personType.GetConstructor(new Type[] { });
            //ConstructorInfo ageCtor = personType.GetConstructor(new[] { typeof(int) });
            //ConstructorInfo nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });
            //bool swapped = false;
            //if (nameAgeCtor == null)
            //{
            //    nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });
            //    swapped = true;
            //}

            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());

            //Person basePerson = (Person)emptyCtor.Invoke(new object[] { });
            //Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
            //Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) : (Person)nameAgeCtor.Invoke(new object[] { name, age });

            //Console.WriteLine("{0} {1}", basePerson.Name, basePerson.Age);
            //Console.WriteLine("{0} {1}", personWithAge.Name, personWithAge.Age);
            //Console.WriteLine("{0} {1}", personWithAgeAndName.Name, personWithAgeAndName.Age);
        }
    }
}
