using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class Person : Object
    {
        public readonly string HomePlanet = "Earth";

        public const string Species = "Homo Sapien";

        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        public void Deconstruct(out string name, out DateTime dob)
        {
            name = Name;
            dob = DateOfBirth;
        }
        public void Deconstruct(out string name,
         out DateTime dob, out WondersOfTheAncientWorld fav)
        {
            name = Name;
            dob = DateOfBirth;
            fav = BucketList;
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameters cannot have a default
            // AND must be initialized inside the method
            z = 99;
            // increment each parameter
            x++;
            y++;
            z++;
        }
    }
}