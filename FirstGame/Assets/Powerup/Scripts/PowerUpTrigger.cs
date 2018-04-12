using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PowerUpTrigger : MonoBehaviour {

	public PowerUpBase PowerUp;
	public Image healthLevel;
	public Text scoreDisplay;


	private void OnTriggerEnter(Collider obj) {
		healthLevel.fillAmount += PowerUp.powerLevel;
		
		/*if(healthLevel.fillAmount == 0 && PowerUp.name == "Death"){
			obj.GetComponent<CharacterControllerLearn>().MovePattern = PowerUp.MovePattern;
			gameObject.SetActive(false);
		}*/
		switch(PowerUp.name){
			case "Death":
				if(healthLevel.fillAmount == 0){
				obj.GetComponent<CharacterControllerLearn>().MovePattern = PowerUp.MovePattern;
				gameObject.SetActive(false);
				}
			break;
			case "Faster":
				obj.GetComponent<CharacterControllerLearn>().MovePattern = PowerUp.MovePattern;
				gameObject.SetActive(false);
			break;
			case "HigherJump":
				obj.GetComponent<CharacterControllerLearn>().MovePattern = PowerUp.MovePattern;
				gameObject.SetActive(false);
			break;
			case "Points":
				scoreDisplay.text = "Score: " + PowerUp.score.ToString();
				gameObject.SetActive(false);
			break;
			case "3Points":
				scoreDisplay.text = "Score: " + PowerUp.score.ToString();
				gameObject.SetActive(false);
			break;
			case "5Points":
				scoreDisplay.text = "Score: " + PowerUp.score.ToString();
				gameObject.SetActive(false);
			break;
			case "10Points":
				scoreDisplay.text = "Score: " + PowerUp.score.ToString();
				gameObject.SetActive(false);
			break;
			case "HealthBonus":
				gameObject.SetActive(false);
			break;

		}
	}


}
