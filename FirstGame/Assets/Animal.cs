using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour {


	public string name;

	public int foodCount;

	public bool food;
	
	public Text myUIText;
	// Use this for initialization
	
	void OnMouseDown()
	{
		if(name == "Cat"){
			myUIText.text = "Meow";
		}
		if(foodCount <= 0){
			myUIText.text = "The " + name + " needs food.";
		}

		if(food == true){
			myUIText.text = "Pet has food.";
		}
		//myUIText.text = "I have a " + name + ", the amount of food left is: " + foodCount;
	}
}
