using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference);

        scripture.ConvertStringtoWord();
        scripture.Display();
        Console.Write("Press enter to continue or type 'quit' to finish: ");
        var response = Console.ReadLine();
        while (Console.ReadKey().Key != ConsoleKey.Enter || response != "quit") { 

        };
        Console.Clear();


    }
}