using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
	//this declares what start will do
	void Start () {
		print("Cats are awful.");
		print("Not a fan of cats");
	}
	
	void OnMouseDown()
	{
		print("Meow");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
