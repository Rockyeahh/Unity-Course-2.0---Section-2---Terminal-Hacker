using UnityEngine;

public class Hacker : MonoBehaviour {

    //Game configuration data.
    string[] level1Passwords = { "Password", "I'm Smart", "Mistress1", "Mistress2", "Dungeon" };
    string[] level2Passwords = { "Queen Of The Fools", "Jeeves", "Cliff Lover", "Bloody Church Again", "Spider Prince" };
    string[] level3Passwords = { "Stock Market AI", "Cayman Islands", "Richer Today, Richer Tomorrow", "Guernsey", "Virgin Islands" };

    // Game state.
    int level;
    enum Screen {MainMenu, Password, Win};
    Screen currentScreen; // Declares a variable to use in the class.
    string password;

	void Start () {
        ShowMainMenu();
        // I could also set Screen.MainMenu here.
    }

    void ShowMainMenu() // The parameter is used so that it is used.
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        //Terminal.WriteLine(greeting); // It knows greeting is a string because of the string in the above line. The above greeting in ShowMainMenu(string greeting) was removed.
        MainMenuTextDisplay();
    }

    private static void MainMenuTextDisplay()
    {
        Terminal.WriteLine("Hello, Dave.");
        Terminal.WriteLine("Welcome to Terminal Hacker, human.");
        Terminal.WriteLine("Press 1 An MPs email passwords");
        Terminal.WriteLine("Press 2 Brenda's laptop");
        Terminal.WriteLine("Press 3 Money Corp Server");
        Terminal.WriteLine("Choose a target:");
    }

    void OnUserInput(string input)
    {

        if (input == "menu") // We can always go directly to the main menu if we need/want to.
        {
            ShowMainMenu();
        }
        else if (input == "quit" ||input == "exit" || input == "close")
        {
            Application.Quit();
            Terminal.WriteLine("Dave, exit the web browser by pressing the X symbol.");
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        } else if (currentScreen == Screen.Password)
        {
            Password(input);
        }
      
    }

    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");
        if (isValidLevelNumber)
        {
            level = int.Parse(input); // What is Parse? Why use it?
            AskForPassword();
        } else if (input == "HAL") // Easter egg.
        {
            Terminal.WriteLine("Good morning, Dave.");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level Dave."); // if they don't pick 1, 2, 3, menu or HAL.
            Terminal.WriteLine("Type menu to return to the Menu.");
        }
    }

    void AskForPassword()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("Type menu to return to the Menu.");
        SetRandomPassword();
        Terminal.WriteLine("Enter your password:                   Hint: " + password.Anagram());
    }

    void SetRandomPassword()
    {
        switch (level)
        {
            case 1: // What is case?
                password = level1Passwords[Random.Range(0, level1Passwords.Length)]; // Length used like this makes it grab the max. No idea why or how it does that.
                break; // Needed to complete the switch statement.
            case 2:
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            case 3:
                password = level3Passwords[Random.Range(0, level3Passwords.Length)];
                break;
            default:
                Debug.LogError("Panic! This an invalid level number.");
                break;
        }
    }

    void Password(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            AskForPassword();
            // We could call Start Game again from here. = I was right as he did that later in section 2. (start game was changed to ask for password.)
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
        Terminal.WriteLine("Type menu to return to the Menu.");
    }

    void ShowLevelReward()
    {
        switch (level)
        {
            case 1:
                Terminal.WriteLine("Congratulations, Dave.");
                ASCIIart1();
                break;
            case 2:
                Terminal.WriteLine("Just what do you think you're doing, Dave?");
                ASCIIart2();
                break;
            case 3:
                Terminal.WriteLine("Dave, stop. Stop, will you? Stop, Dave. Will you stop, Dave? Stop, Dave. I'm afraid. ");
                ASCIIart3();
                break;
            default:
                Debug.LogError("Panic! This is not a valid win state.");
                break;
        }

    }

    private static void ASCIIart1()
    {
        // Write line allows for this ASCII art as a hack but it's not the normal way that you would it into your game. You'd be better off making it with the Unity UI.
        Terminal.WriteLine(@"
-_-
                                   ");
    }
    private static void ASCIIart2()
    {
        Terminal.WriteLine(@"
^    ^    ^   ^
| | | | | | | |
 * * * * * * * 
| | | | | | | |
|_____________|
                                   ");
    }
    private static void ASCIIart3()
    {
        Terminal.WriteLine(@"
$$$$$$$
                                   ");
    }
}
