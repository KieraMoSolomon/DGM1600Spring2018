using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSwitch : MonoBehaviour {

	public PowerUpBase MyPowerUp;

	// Use this for initialization
	void Start () {
		switch (MyPowerUp.powerLevel)
		{
			case 100:
				print("you just got more ammo");
			break;
			case 1000:
				print("You hit a special, and get 1000 ammo.");
			break;
		}	
	}
	
}
