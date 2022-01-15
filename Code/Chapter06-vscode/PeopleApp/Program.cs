using Packt.Shared;
using static System.Console;

Person harry = new() { Name = "Harry" };
Person mary = new() { Name = "Mary" };
Person jill = new() { Name = "Jill" };

Person baby1 = mary.ProcreateWith(harry);
baby1.Name = "Gary";

Person baby2 = Person.Procreate(harry, jill);
Person baby3 = harry * mary;

WriteLine($"{harry.Name} has {harry.Children.Count} children.");
WriteLine($"{mary.Name} has {mary.Children.Count} children.");
WriteLine($"{jill.Name} has {jill.Children.Count} children.");
WriteLine(
 format: "{0}'s first child is named \"{1}\".",
 arg0: harry.Name,
 arg1: harry.Children[0].Name);

WriteLine($"5! is {Person.Factorial(5)}");

harry.Shout += Harry_Shout;

harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

static void Harry_Shout(object? sender, EventArgs e)
{
    if (sender is null || sender is not Person) return;
    Person p = (Person)sender;
    WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
}

Person[] people =
{
 new() { Name = "Simon" },
 new() { Name = "Jenny" },
 new() { Name = "Adam" },
 new() { Name = "Richard" }
};
WriteLine("Initial list of people:"); 
foreach (Person p in people)
{
 WriteLine($" {p.Name}");
}
WriteLine("Use Person's IComparable implementation to sort:");
Array.Sort(people);
foreach (Person p in people)
{
 WriteLine($" {p.Name}");
}
