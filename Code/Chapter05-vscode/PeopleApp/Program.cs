using Packt.Shared;
using System;
using static System.Console;

Person bob = new();
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.BucketList = WondersOfTheAncientWorld.StatueOfZeusAtOlympia | WondersOfTheAncientWorld.LighthouseOfAlexandria;

WriteLine(
 format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
 arg0: bob.Name,
 arg1: bob.BucketList,
 arg2: (int)bob.BucketList);