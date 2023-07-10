using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to our local fitness center!\n");

        List<Exercise> exercises = new List<Exercise>();

        Running r = new Running();
        Cycling c = new Cycling();
        Swimming s = new Swimming();
    
        exercises.Add(r);
        exercises.Add(c);
        exercises.Add(s);

        foreach (Exercise e in exercises)
        {
            e.setData();
            e.Display(e);
            Console.WriteLine(string.Empty);
        }
    }
}