using Packt.Shared;
using System;
using static System.Console;

ImmutableAnimal oscar = new("Oscar", "Labrador");
var (who, what) = oscar; // calls Deconstruct method 
WriteLine($"{who} is a {what}.");