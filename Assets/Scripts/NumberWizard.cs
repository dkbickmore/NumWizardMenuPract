using UnityEngine.UI;
using UnityEngine;
using System.Collections;
//need in order to import text to UI from code

public class NumberWizard : MonoBehaviour {
	//test
	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 10;


	// Use this for initialization
	void Start () {
		StartGame ();
		
	}

	public Text text;

	void StartGame	() {

		max = 1000;
		min = 1;
		guess = Random.Range(min, max);
		
		/*
		print ("=====================================================================================================");
		print ("welcome to Number Wizard. It's my first game mother fucker. Get ready to get your world rocked. Hard.");
		print ("Pick a number in your head, but dont tell me. Or do because i cant hear you, ovi.");


		print ("The highest numer you can pick is " + max );
		print ("The lowest numer you can pick is " + min );

		print ("Is the number higher or lower than " + guess + "?");
		print ("up arrow = higher, down arrow = lower, or the enter = equal.");
		print ("=====================================================================================================");
		max = max + 1;
		*/
	}
			
	
	// Update is called once per frame
	/*void Update ()	{

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("higher huuh?");
			min = guess;
			NextGuess ();						 

		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("lower huuh?");
			max = guess;
			NextGuess ();					

		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I win, bitch");
			guess = 500;
			StartGame ();
		}

	}
	*/

	public void GuessHigher ()
	{
		min = guess;
		NextGuess ();
	}

	public void GuessLower ()
	{
		max = guess;
		NextGuess ();
	}

	void NextGuess ()	{
		guess = (min + max) / 2;
		text.text = guess.ToString();
		maxGuessesAllowed -- 1;

		if (maxGuessesAllowed == 0)
			Application.LoadLevel("Win");
		//print ("Higher or lower than " + guess + "?");
		//print ("up arrow = higher, down arrow = lower, or the enter = equal.");
	}
}
