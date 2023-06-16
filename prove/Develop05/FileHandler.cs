using System.IO;

public class FileHandler
{
  string _filename = "file.txt";
  
  public void WriteFile(List<Goal> goals)
  {  
    using (StreamWriter outputFile = new StreamWriter(_filename))
    {
        foreach (Goal g in goals)
        {
          outputFile.WriteLine("it works?");
        }
    }
  }
  public List<Goal> ReadFromFile()
  {
    string[] lines = System.IO.File.ReadAllLines(_filename);
    List<Goal> goals = new List<Goal>();
    foreach (string line in lines)
    {
      string[] parts = line.Split("~~");
    }
    return goals;
  }
}