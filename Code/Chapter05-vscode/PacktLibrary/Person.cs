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
    }
}