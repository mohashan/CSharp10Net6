using Packt.Shared;
using System;
using static System.Console;

BankAccount.InterestRate = 0.012M; // store a shared value
BankAccount jonesAccount = new(); // C# 9.0 and later
jonesAccount.AccountName = "Mrs. Jones"; 
jonesAccount.Balance = 2400;
WriteLine(format: "{0} earned {1:C} interest.",
 arg0: jonesAccount.AccountName,
 arg1: jonesAccount.Balance * BankAccount.InterestRate);
BankAccount gerrierAccount = new(); 
gerrierAccount.AccountName = "Ms. Gerrier"; 
gerrierAccount.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
 arg0: gerrierAccount.AccountName,
 arg1: gerrierAccount.Balance * BankAccount.InterestRate);
 var bob = new Person{
     Name = "bob smith",
     Children = new List<Person>{
         new Person{ Name = "child 1"},
         new Person{ Name = "child 2"},
     },
 };
 WriteLine($"{bob.Name} is a {Person.Species} and his home planet is {bob.HomePlanet}.");
var fruit = bob.GetNamedFruit();
WriteLine($"{fruit.Name}, {fruit.Number} there are.");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
var thing2 = (bob.Name, bob.Children.Count); 
WriteLine($"{thing2.Name} has {thing2.Count} children.");

