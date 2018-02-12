using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour {

	//varibles are different data types that store different information
	//there can be int which are whole numbers
	//or float which are decimals but those take up more storage and can make the game run slower
	//or strings hold phrases
	//public float damageDone;
	//public string characterName;
	//public int enemyHealth;
	//public int enemyType; 
	//public int characterHealth;
	public string animalName;

	public int foodCount;

	public bool food;
	
	public Text myUIText;
	// Use this for initialization
	
	void OnMouseDown()
	{
		//if statements are true or false questions
		//if (*this is true*){
			//do this block of code
			//}
		//however if the argument is false then it will not even look into the code block
		
		
		//else clauses are used to follow an if statement
		//they are the code that happens when the if is false
		//You do not always need an else clause but it could come in handy
		//if you have more than a true or false that you are 
		//checking it is not a wise choice to go with an if statement in the first place
		if(animalName == "Cat"){
			myUIText.text = "Meow";
		}
		else{
			myUIText.text = "Wrong";
		}
		if(foodCount <= 0){
			myUIText.text = "The " + name + " needs food.";
		}
		else{
			print("How dare you think you are out of food");
		}

		if(food == true){
			myUIText.text = "Pet has food.";
		}else
		{
			print("The pet is starving");
		}
		if(1+2 == 3){
			print("3 is a magic number");
		}
		
		if(foodCount > 0){
			myUIText.text = "the pet still has food";
		}else
		{
			print("The pet is dead");
		}
		if(4+1 == 5){
			print("you're a dummy.");
		}
		if(animalName == "Dog"){
			print("bark");
		}else{
			print("dogs suck");
		}
		if(animalName == "fish"){
			print("blub blub");
		}
		if(animalName == "Sheep"){
			print("baaah");
		}
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			print("Jump for joy!");
		}
		}
		//myUIText.text = "I have a " + name + ", the amount of food left is: " + foodCount;
	}

