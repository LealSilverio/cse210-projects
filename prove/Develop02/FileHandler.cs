using System.IO;

public class FileHandler
{

  string _filename = "people.txt";
  List<Entry> _entries = ReadFromFile();
  Entry _e;

  public FileHandler()
  { 
    foreach (Entry _e in _entries)
    {
      _e.Display();
    }
  }
  public void SaveFile(List<Entry> _entries)
  {  
    
    using (StreamWriter outputFile = new StreamWriter(_filename))
    {
        foreach (Entry _e in _entries)
        {
          outputFile.WriteLine(_e.Stringify());
        }
    }
  }
  public static List<Entry> ReadFromFile()
  {
      List<Entry> entry = new List<Entry>();
      return entry;
  }
}