// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("What is your name?");
string? name = Console.ReadLine();
if (!string.IsNullOrEmpty(name))
{
    Console.WriteLine($"Hello, {name}! This is demo code for a console application.");
}
else
{
    Console.WriteLine("Hello, stranger! Are lost you should not be here.");
}