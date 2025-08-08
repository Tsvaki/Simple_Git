
internal class Program
{
    private static void Main(string[] args)
    {
        /// <summary> This is a simple console application that demonstrates basic input and output operations, arithmetic calculations, and string manipulations.</summary>
        /// <remarks> It prompts the user for their name, performs some arithmetic operations, and displays the results.</remarks>
        /// <author>Ronald Tsvaki</author>
        /// <date>2023-10-01</date>
        /// version>1.0</version>
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
        // Demonstrating basic arithmetic operations
        // Variables for arithmetic operations
        int x = 10;
        int y = 5;
        // Variables for string concatenation
        string A = "abcd", B = "efgh";
        Console.WriteLine("");
        Console.WriteLine($"Sum of {x} and {y} is: {x + y}");
        Console.WriteLine($"Concatenation of {A} and {B} is: {A + B}");
        Console.WriteLine($"BOMDAS {y} and {x} is: {x / y * x}");

        Console.WriteLine("");

        Console.WriteLine("-----Short Hand ------ ");
        Console.WriteLine($" {x} add one x++ =  {++x}");
        Console.WriteLine($" {y} add one y-- =  {--y}"); 
        // Add XML comment to explain the purpose of the code
    }
}