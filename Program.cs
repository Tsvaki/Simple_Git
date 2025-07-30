// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("What is your name?");
string? name = Console.ReadLine();
if (!string.IsNullOrEmpty(name))
{
    Console.WriteLine($"Hello, {name}!");
}
else
{
    Console.WriteLine("Hello, stranger!");
}