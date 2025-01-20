// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine("Hello");
await Task.Delay(500);
Console.WriteLine("Guys");

/*string? s = Console.ReadLine();

int returnValue = int.Parse(s ?? "-1");
return returnValue;*/

StringBuilder builder = new();
builder.AppendLine("The following arguments are passed:");
Console.WriteLine($"{args.Length}");

// Display the command line arguments using the args variable.
foreach (var arg in args)
    builder.AppendLine($"Argument={arg}");
        
Console.WriteLine(builder.ToString());


Person person1 = new Person("Thomas", 31);
Console.WriteLine($"Initial");
Console.WriteLine($"Person1: name: {person1.name}, age: {person1.age}");
Console.WriteLine();

Person person2 = person1;
Console.WriteLine($"Assign person2 = person1");
Console.WriteLine($"Person1: name: {person1.name}, age: {person1.age}");
Console.WriteLine($"Person2: name: {person2.name}, age: {person2.age}");
Console.WriteLine();

person2.name = "Anna";
Console.WriteLine($"Change person2's name");
Console.WriteLine($"Person1: name: {person1.name}, age: {person1.age}");
Console.WriteLine($"Person2: name: {person2.name}, age: {person2.age}");
