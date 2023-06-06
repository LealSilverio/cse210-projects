public class Menu 
{
    int _userChoice;

    public void DisplayMenu()
    {
        Console.Write(_userChoice);
        int[] options = {1, 2, 3, 4};
        while(_userChoice != 4)
    {   
        while(_userChoice == 0)
        {
            Console.Write("Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit\n Select a choice from the Menu: ");
            _userChoice = Console.Read();
        }
        switch (_userChoice)
        {
            case 1:
                Console.Write("Case 1");
                break;
            case 2:
                Console.Write("Case 2");
                break;
            case 3:
                Console.Write("Case 3");
                break;
            case 4:
                Environment.Exit(0);
                break;
        }
    }
    }
}