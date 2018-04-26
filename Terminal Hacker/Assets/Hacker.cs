using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    // Game state.
    int level;
    enum Screen {MainMenu, Password, Win};
    Screen currentScreen = Screen.MainMenu; // Declares a variable to use in the class. Then it intializes it with a new value by using Screen.MainMenu, so that it starts at the main menu.

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
      //  if (input == "1")
      //  {
       //     print("You chose level 1");
           // print(input == "1"); // prints whatever the string is. Somehow it only does this after you hit return. Why?
                                 // print if the input or string is the same as 1. It could and should be done as a boolean because it deals in true and false.
                                 // It knows how to print true and false because it is a core part of ==.
       // }

        if (input == "menu")
        {
            ShowMainMenu();
        } // TODO: Handle differently depending on the screen.
        else if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else if (input == "HAL")
        {
            Terminal.WriteLine("Good morning, Dave.");
        }
        else {
            Terminal.WriteLine("Please choose a valid level Dave."); // if they don't pick 1, 2, 3, menu or HAL.
        }
    }

    private void StartGame()
    {
        // He placed currentScreen = Screen.Password; here, which makes it so that you don't need repeated code above.
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password: ");
    }
}
