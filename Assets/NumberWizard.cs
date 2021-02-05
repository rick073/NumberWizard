using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
	public int max = 1000;
	public int min = 1;
	public int guess = 500;
	// Start is called before the first frame update
	void Start()
	{
		Debug.Log("Hello, please think of a number. Min: " + min +" Max: " + max);
		Debug.Log("Is your number higher or lower than " + guess + "?");
		max += 1;
	}

	// Update is called once per frame
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			NextGuess();
		}
		else if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			max = guess;
			NextGuess();
			
		}
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			max = 1000;
			min = 1;
			guess = 500;

			Debug.Log("Hurray I guessed right.");
			Debug.Log("Please think of another number. Min: " + min + " Max: " + max);
			Debug.Log("Is your number higher or lower than " + guess + "?");
			Debug.Log("Higher = Up, Lower = Down, Enter = Correct.");
			max += 1;
		}
	}

	void NextGuess()
	{
		guess = (max + min) / 2;

		Debug.Log("Is your number higher or lower than " + guess + "?");
		Debug.Log("Higher = Up, Lower = Down, Enter = Correct.");
	}
}
