using System;
using static System.Console;

namespace Packt.Shared{
    public class Person : Object
    {
        public WondersOfTheAncientWorld BucketList;
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}