public class Menu 
{
    string _userChoice;

    public void DisplayMenu()
    {
        Console.Write(_userChoice);
        string[] options = {"1", "2", "3", "4"};
        while(_userChoice != "4")
    {   
        while(options.Contains(_userChoice) == false)
        {
            Console.Write("Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit\n Select a choice from the Menu: ");
            _userChoice = Console.ReadLine() ?? String.Empty;
            switch (_userChoice)
            {
                case "1":
                    Breathing b = new Breathing();
                    b.Display(); 
                    break;
                case "2":
                    Reflection r = new Reflection();
                    r.Display();
                    break;
                case "3":
                    Listing l = new Listing();
                    l.Display();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
            }
            _userChoice = " ";
        }
        
    }
    }
}