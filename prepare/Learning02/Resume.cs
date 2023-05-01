using System;

public class Resume
{
  public string name;
  public List<Job> jobs = new List<Job>();

  public void Display()
  {
    Console.WriteLine($"Name: {name}");
    Console.WriteLine("Jobs: ");

    foreach (Job j in jobs)
    {
      j.Display();
    }
  }
}
