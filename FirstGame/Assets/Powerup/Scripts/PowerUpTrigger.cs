using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PowerUpTrigger : MonoBehaviour {

	public PowerUpBase PowerUp;
	public Image healthLevel;
	public enum PowerUpNames {Death, Faster, HigherJump, Points, ThreePoints, FivePoints, TenPoints, HealthBoost};
 

	private void OnTriggerEnter(Collider obj) {
		
		//PowerUpNames thisPowerUp;
		switch(PowerUp.name){
			case "Death":
				if(healthLevel.fillAmount == 0){
				obj.GetComponent<CharacterControllerLearn>().Player.MovePattern = PowerUp.MovePattern;
				gameObject.SetActive(false);
				}
				else {
					healthLevel.fillAmount += PowerUp.powerLevel;
				}
			break;
			case "Faster":
				obj.GetComponent<CharacterControllerLearn>().Player.MovePattern = PowerUp.MovePattern;
				gameObject.SetActive(false);
			break;
			case "HigherJump":
				obj.GetComponent<CharacterControllerLearn>().Player.MovePattern = PowerUp.MovePattern;
				gameObject.SetActive(false);
			break;
			case "Points":
				ScoreManager.score += PowerUp.score;
				gameObject.SetActive(false);
			break;
			case "ThreePoints":
				ScoreManager.score += PowerUp.score;
				gameObject.SetActive(false);
			break;
			case "FivePoints":
				ScoreManager.score += PowerUp.score;
				gameObject.SetActive(false);
			break;
			case "TenPoints":
				ScoreManager.score += PowerUp.score;
				gameObject.SetActive(false);
			break;
			case "HealthBoost":
				healthLevel.fillAmount += PowerUp.powerLevel;
				gameObject.SetActive(false);
			break;

		}
	}

}
