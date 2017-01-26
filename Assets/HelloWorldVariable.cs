using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorldVariable : MonoBehaviour {

	private string _helloStr = "Hello Variable World!";
	public string YourName;
	
	// Use this for initialization
	void Start () {
		Debug.Log(_helloStr);
		Debug.Log("Your name is " + YourName);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
