using System;

class Program
{
    static void Main(string[] args)
    {
    Job job1 = new Job();
    job1.jobTitle = "Software Engineer";
    job1.company = "Microsoft";
    job1.startYear = 2019; 
    job1.endYear = 2022;


    Job job2 = new Job();
    job2.jobTitle = "Manager";
    job2.company = "Apple";
    job2.startYear = 2022; 
    job2.endYear = 2023;

    Resume member1 = new Resume();
    member1.name = "Allison Rose";
    
    member1.jobs.Add(job1);
    member1.jobs.Add(job2);

    member1.Display();
    }
}