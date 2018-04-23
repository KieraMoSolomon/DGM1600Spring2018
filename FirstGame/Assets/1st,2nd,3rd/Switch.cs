using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	public string UserName;
	public int Age;

/* Switch statements are a better way to have multiple options that could happen.
They are better than having to do if else statements. They can have many different cases that
could happen and within those cases they will do something when that case is activated.
 */
	// Use this for initialization
	void Start () {
		switch (UserName)
		{
			case "Password":
				print("Password if correct.");
			break;
			case "LevelUp":
				print("You win! Next Level");
			break;
			case "BlackPanther":
				print("Made over 200 million this weekend!");
			break;
			default:
				print("Why don't you just tell me which movie you want to see?");
			break;
		}	
		switch(Age){
			case 21:
				print("You can drink");
				break;
			case 16:
				print("you can drive");
				break;
			default:
				print("You can eat");
				break;
		}
	}
	
}
