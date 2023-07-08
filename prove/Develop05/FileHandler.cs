using System.IO;

public class FileHandler
{
  string _default = "goals.txt";
  
  public void Save(List<Goal> goals)
  {  
    string filename = PromptFilename();
    using (StreamWriter outputFile = new StreamWriter(filename))
    {
        foreach (Goal g in goals)
        {
          outputFile.WriteLine(g.Stringify());
        }
        Console.WriteLine("File Saved Successfully");
    }
  }
  public List<Goal> Load(List<Goal> goals)
  {
    string filename = PromptFilename();
    string[] lines = System.IO.File.ReadAllLines(filename);
    foreach (string line in lines)
    {
      string[] parts = line.Split("~~");
      if (parts[0] == "SimpleGoal")
      {
        Simple s = new Simple();
        s.CreateFromList(parts);
        goals.Add(s);
      } 
      else if (parts[0] == "EternalGoal")
      {
        Eternal e = new Eternal();
        e.CreateFromList(parts);
        goals.Add(e);
      } 
      else if (parts[0] == "ChallengeGoal")
      {
        Challenge c = new Challenge();
        c.CreateFromList(parts);
        goals.Add(c);
      } 
    }
    Console.WriteLine("File Loaded Successfully");
    return goals;
  }
  public string PromptFilename()
  {
    Console.Write("What is the filename for the goal file? (press Enter for default name) ");
    string filename = Console.ReadLine();
    if (filename == string.Empty)
    {
      filename = _default;
    }
    return filename;
  }
}