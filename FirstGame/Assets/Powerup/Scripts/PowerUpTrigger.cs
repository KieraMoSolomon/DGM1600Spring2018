using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PowerUpTrigger : MonoBehaviour {

	public PowerUpBase PowerUp;
	public Image healthLevel;
	public enum PowerUpNames {Death, Faster, HigherJump, Points, ThreePoints, FivePoints, TenPoints, HealthBoost};
 

	private void OnTriggerEnter(Collider obj) {
		

		switch(PowerUpNames[PowerUp.name]){
			case PowerUpNames[0]:
				if(healthLevel.fillAmount == 0){
				obj.GetComponent<CharacterControllerLearn>().Player.MovePattern = PowerUp.MovePattern;
				gameObject.SetActive(false);
				}
				else {
					healthLevel.fillAmount += PowerUp.powerLevel;
				}
			break;
			case PowerUpNames[1]:
				obj.GetComponent<CharacterControllerLearn>().Player.MovePattern = PowerUp.MovePattern;
				gameObject.SetActive(false);
			break;
			case PowerUpNames[2]:
				obj.GetComponent<CharacterControllerLearn>().Player.MovePattern = PowerUp.MovePattern;
				gameObject.SetActive(false);
			break;
			case PowerUpNames[3]:
				ScoreManager.score += PowerUp.score;
				gameObject.SetActive(false);
			break;
			case PowerUpNames[4]:
				ScoreManager.score += PowerUp.score;
				gameObject.SetActive(false);
			break;
			case PowerUpNames[5]:
				ScoreManager.score += PowerUp.score;
				gameObject.SetActive(false);
			break;
			case PowerUpNames[6]:
				ScoreManager.score += PowerUp.score;
				gameObject.SetActive(false);
			break;
			case PowerUpNames[7]:
				healthLevel.fillAmount += PowerUp.powerLevel;
				gameObject.SetActive(false);
			break;

		}
	}

}
