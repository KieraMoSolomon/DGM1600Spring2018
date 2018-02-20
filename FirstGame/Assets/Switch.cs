using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	public string UserName;

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
	}
	
}
