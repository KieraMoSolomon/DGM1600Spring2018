using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour {

	//varibles are different data types that store different information
	//there can be int which are whole numbers
	//or float which are decimals but those take up more storage and can make the game run slower
	//or strings hold phrases
	public float damageDone;
	public string characterName;
	public int enemyHealth;
	public int enemyType; 
	public int characterHealth;
	public string name;

	public int foodCount;

	public Text myUIText;
	// Use this for initialization
	
	void OnMouseDown()
	{
		myUIText.text = "I have a " + name + ", the amount of food left is: " + foodCount;
	}
}
