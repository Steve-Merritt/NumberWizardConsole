using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int guess = 500;
    int max = 1000;
    int min = 1;

    // Use this for initialization
    void Start ()
    {
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number.");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);

        Debug.Log("Tell me if your number is higher or lower than my guess of " + guess);
        Debug.Log("Up = Higher, Down = Lower, Enter = Correct");

        max += 1;
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Cool!");
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("New Guess: " + guess);
    }
}
