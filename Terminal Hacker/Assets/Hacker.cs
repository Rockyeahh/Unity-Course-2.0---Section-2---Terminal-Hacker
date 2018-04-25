using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //ShowMainMenu(words);
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
	
	// Update is called once per frame
	void Update () {
		
	}
}
