using System;
using System.Collections;
using System.Collections.Generic;
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
        bool isValidLevelNumber = (input == "1" || input == "2");
        if (isValidLevelNumber)
        {
            level = int.Parse(input); // What is Parse? Why use it?
            StartGame();
        }

      //  if (input == "1")
     //   {
      //      level = 1;
     //       StartGame();
     //       password = level1Passwords[0]; // TODO Make it random later. I think he wants the password you have to work out random.
     //       Terminal.WriteLine("Hint: sswordPa"); // TODO This text hint would need to follow the correct password as it is chosen from the array.
      //  }
      //  else if (input == "2")
      //  {
      //      level = 2;
      //      StartGame();
      //      password = level2Passwords[0];
      //      Terminal.WriteLine("Hint: sloof heT fuQeen O");
      //  }
      //  else if (input == "3")
      //  {
      //      level = 3;
      //      StartGame();
     //   }
        else if (input == "HAL") // Easter egg.
        {
            Terminal.WriteLine("Good morning, Dave.");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level Dave."); // if they don't pick 1, 2, 3, menu or HAL.
        }
    }

    void StartGame()
    {
        // He placed currentScreen = Screen.Password; here, which makes it so that you don't need repeated code above.
        currentScreen = Screen.Password;
        //Terminal.WriteLine("You have chosen level " + level);
        Terminal.ClearScreen();
        switch (level)
        {
            case 1: // What is case?
                password = level1Passwords[0];
                    break; // Needed to complete the switch statement.
            case 2:
                password = level2Passwords[1];
                    break;
            default:
                Debug.LogError("Panic! This an invalid level number.");
                break;
        }
        Terminal.WriteLine("Please enter your password: ");
    }

    void Password(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("Congratulations, Dave.");
        } else
        {
            Terminal.WriteLine("Incorrect. Try again, Dave.");
            // Could call Start Game again from here.
        }
    }

}
