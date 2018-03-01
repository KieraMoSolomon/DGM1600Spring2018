using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTrigger : MonoBehaviour {

	public PowerUpBase myPowerUp;
	public Player myPlayer;

	void OnTriggerEnter() {
		AddPower(myPowerUp);
	}

	void AddPower(PowerUpBase powerUp){
		//Do work
		//print(powerUp.powerLevel);
		myPlayer.Health += myPowerUp.powerLevel;
	}

}
