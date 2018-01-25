using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour {


	public string name;

	public int foodCount;

	public Text myUIText;
	// Use this for initialization
	
	void OnMouseDown()
	{
		myUIText.text = "I have a " + name + ", the amount of food left is: " + foodCount;
	}
}
