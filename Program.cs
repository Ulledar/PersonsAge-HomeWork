using System;
using static System.Console;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Alice", "Johnson", new DateTime(1990, 1, 1), Gender.Female);
            WriteLine(person.ToString());
            WriteLine("An now she is " + person.Age + " years old");
            person.AdoptPet("Baron");
            person.AdoptPet("Murchik");
            WriteLine(person.ToString() + " Does she have pets : " + (person.HasPets ? "Yes" : "No"));
            WriteLine(person.GetPetsName());
        }
    }
}
