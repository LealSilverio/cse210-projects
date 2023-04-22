using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);
        string letter = " ";
             if (grade >=70)
            {
                if (grade >= 90)
                {
                    letter = "an A!";
                }
                else if (grade >= 80)
                {
                    letter = "a B";
                }
                else
                {
                    letter = "a C";
                }
                Console.WriteLine("Congrats! You passed the class");
            }
            else 
            {
                if (grade >= 60)
                {
                    letter = "a D";
                }
                else
                {
                    letter = "a F";
                }
                Console.WriteLine("You failed the class");
            }
            Console.WriteLine($"You got {letter}");
    }
}