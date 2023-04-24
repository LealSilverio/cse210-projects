using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        
        List<int> numbers = new List<int>();
        int number;
        
        do
        {
            Console.Write("Enter number: ");
            string userImput = Console.ReadLine();
            number = int.Parse(userImput);
            numbers.Add(number);
        } while (number != 0);
        
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int maxNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}