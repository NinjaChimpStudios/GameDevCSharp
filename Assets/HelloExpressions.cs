using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloExpressions : MonoBehaviour {

	public int One;
	public int Two;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Add: " + (One + Two));
		Debug.Log("Subtract: " + (One - Two));
		Debug.Log("Multiply: " + (One * Two));
		Debug.Log("Divide: " + (One / Two));
		Debug.Log("Modulus: " + (One % Two));
		Debug.Log("Increment: " + (One++));
		Debug.Log("Decrement: " + (Two--));

		if (One > Two) {
			Debug.Log("One is bigger");
		} else if (One < Two){
			Debug.Log("Two is bigger");
		} else {
			Debug.Log("One and Two are the same");
		}
		
	}
}
