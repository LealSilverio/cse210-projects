using System.IO;

public class FileHandler
{
  string _filename = "file.txt";
  
  public void WriteFile(List<Entry> _entries)
  {  
    using (StreamWriter outputFile = new StreamWriter(_filename))
    {
        foreach (Entry _e in _entries)
        {
          outputFile.WriteLine(_e.Stringify());
        }
    }
  }
  public List<Entry> ReadFromFile()
  {
    string[] lines = System.IO.File.ReadAllLines(_filename);
    List<Entry> _entries = new List<Entry>();
    foreach (string line in lines)
    {
      string[] parts = line.Split("~~");
      Entry e = new Entry();
      e.EntryList(parts);
      _entries.Add(e);
    }
    return _entries;
  }
}