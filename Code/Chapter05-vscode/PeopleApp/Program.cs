﻿using Packt.Shared;
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
 };
 WriteLine($"{bob.Name} is a {Person.Species} and his home planet is {bob.HomePlanet}.");
 (string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

