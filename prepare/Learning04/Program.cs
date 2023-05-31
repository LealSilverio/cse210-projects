using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a.GetSummary());
        
        MathAssignment ma = new MathAssignment("Elizabeth Smith", "Fraction", "7.3", "8-9");
        Console.WriteLine(ma.GetSummary());
        Console.WriteLine(ma.GetHomeworkList());

        WritingAssignment wa = new WritingAssignment("Mary Waters","European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(wa.GetSummary());
        Console.WriteLine(wa.GetWritingInformation());
    }
}