using UnityEngine;

public class GuessingGame : MonoBehaviour {

	public int Guess; // allows us to enter our guesses in the editor
	private int _secret; // this holds the secret number
	private int _lastGuess; // holds our last guess
	private int _numGuesses; // hold how many guesses we've used
	
	// Use this for initialization
	void Start () {
		// generate a random number 1-100
		_secret = new System.Random().Next(1,100);
		Debug.Log("Guess the secret number!");
	}
	
	// Update is called once per frame
	void Update () {
		if (Guess != _lastGuess) {
			_numGuesses++;
			_lastGuess = Guess;
			Debug.Log("Guessed " + _lastGuess);
			if (_lastGuess == _secret) {
				Debug.Log("You guessed it in " + _numGuesses + " guesses!");
			} else if (_lastGuess < _secret) {
				Debug.Log("higher...");
			} else {
				Debug.Log("Lower...");
			}
		}
	}
}
