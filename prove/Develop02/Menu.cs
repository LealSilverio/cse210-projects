public class Menu
{

  Journal _journal = new Journal();
  FileHandler _fileHandler = new FileHandler();

  public void Display()
  {
    string response = "";
    string[] options = {"N","D","S","L","Q"};
    while(response!="Q")
    {
      while(options.Contains(response)==false)
      {
        Console.WriteLine("\nWelcome to the Journal Program!\nPlease select one of the following choices: ");
        Console.Write("[N]ew Entry\n[D]isplay Journal\n[S]ave Journal\n[L]oad File\n[Q]uit\n\nWhat do you like to do? ");
        response = Console.ReadLine() ?? String.Empty;
        response = response.ToUpper();
      }
      switch (response)
      {
        case "Q":
          Environment.Exit(0);
          break;
        case "N":
          // New Entry
          _journal.NewEntry();
          break;
        case "D":
          //Display Journal
          _journal.ShowAllEntries();
          break;
        case "S":
          //Save journal
          _fileHandler.WriteFile(_journal.GetEntries());
          Console.WriteLine("Saved");
          break;
        case "L":
          //Load Journal 
          List<Entry> entries = _fileHandler.ReadFromFile();
          _journal.LoadEntries(entries);
          Console.WriteLine("Loaded");
          break;
      }
      response= "";
    }
  }
}