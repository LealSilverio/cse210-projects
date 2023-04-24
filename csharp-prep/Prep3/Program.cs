using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Guess My Number");

        Random randomNumber = new Random(); 
        int number = randomNumber.Next(1, 100);
        int guess;

        do
        {
            Console.Write("What is your guess? ");
            string userImput = Console.ReadLine();
            guess = int.Parse(userImput);
    
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
        } while (guess != number);

        if (guess == number)
        {
            Console.WriteLine("You got it! Nice!!");
        }
    }   
}