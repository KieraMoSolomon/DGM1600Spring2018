using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTrigger : MonoBehaviour {

	public PowerUpBase powerUpTransfer;
	public Player myPlayer;

	void OnTriggerEnter(Collider obj) {
		print(obj.name);
	}

	/*void AddPower(PowerUpBase powerUp){
		//Do work
		//print(powerUp.powerLevel);
		myPlayer.Health += myPowerUp.powerLevel;
	}*/

}
