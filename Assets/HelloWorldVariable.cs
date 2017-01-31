using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorldVariable : MonoBehaviour {

	private string _helloStr = "Hello Variable World!";
	public string YourName;
	public int AnInt = 5;
	public float AFloat = 4;
	public bool TrueFalse = true;
	
	// Use this for initialization
	void Start () {
		Debug.Log(_helloStr);
		Debug.Log("Your name is " + YourName);
		string ScopeStr = "Testing Scope";
		Debug.Log(ScopeStr);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
