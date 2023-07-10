using System;

class Program
{
    static void Main(string[] args)
    {   
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference);

        scripture.ConvertStringToWord();
        Console.Write(reference.Display());
        scripture.Display();
        Console.Write("\nPress enter to continue or type 'quit' to finish: ");
        var response = Console.ReadLine();
        while (response != "quit") { 
            Console.Clear();
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Write(reference.Display());
                scripture.HideRandomWord();
                Console.Write("\n\nPress enter to continue or type 'quit' to finish: ");
                response = Console.ReadLine();
            }
        }
    }
}