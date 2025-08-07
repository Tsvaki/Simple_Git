
Console.WriteLine("Hello, World!");
Console.WriteLine("What is your name?");
// Read user input
string? name = Console.ReadLine();
if (!string.IsNullOrEmpty(name))
{
    Console.WriteLine($"Hello, {name}! This is demo code for a console application.");
}
else
{
    Console.WriteLine("Hello, stranger! Are lost ? You should not be here. Code is dangerous!");
}