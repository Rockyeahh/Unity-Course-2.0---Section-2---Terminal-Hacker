using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	void Start () {
        ShowMainMenu("Hello Ben");
    }

    void ShowMainMenu(string greeting) // The parameter is used so that it is used.
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting); // It knows greeting is a string because of the string in the above line.
        Terminal.WriteLine("Welcome to Terminal Hacker, human.");
        Terminal.WriteLine("Press 1 An MPs email passwords");
        Terminal.WriteLine("Press 2 Brenda's laptop");
        Terminal.WriteLine("Press 3 Money Corp Server");
        Terminal.WriteLine("Choose a target:");
    }

    void OnUserInput(string input)
    {
        print(input == "1"); // prints whatever the string is. Somehow it only does this after you hit return. Why?
                             // print if the input or string is the same as 1. It could and should be done as a boolean because it deals in true and false.
                             // It knows how to print true and fals because it is a core part of ==.
    }
	
}
