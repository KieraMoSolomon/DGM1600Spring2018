using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PowerUpTrigger : MonoBehaviour {

	public PowerUpBase PowerUp;
	public Image healthLevel;
	public enum PowerUpNames {
		Death, Faster, HigherJump, Points, ThreePoints, FivePoints, TenPoints, HealthBoost
		}
	public PowerUpNames powNames;

	private void OnTriggerEnter(Collider obj) {
		
		//PowerUpNames thisPowerUp;
		switch(powNames){
			case PowerUpNames.Death:
				if(healthLevel.fillAmount == 0){
				obj.GetComponent<CharacterControllerLearn>().Player.MovePattern = PowerUp.MovePattern;
				gameObject.SetActive(false);
				}
				else {
					healthLevel.fillAmount += PowerUp.powerLevel;
				}
			break;
			case PowerUpNames.Faster:
				obj.GetComponent<CharacterControllerLearn>().Player.MovePattern = PowerUp.MovePattern;
				gameObject.SetActive(false);
			break;
			case PowerUpNames.HigherJump:
				obj.GetComponent<CharacterControllerLearn>().Player.MovePattern = PowerUp.MovePattern;
				gameObject.SetActive(false);
			break;
			case PowerUpNames.Points:
				ScoreManager.score += PowerUp.score;
				gameObject.SetActive(false);
			break;
			case PowerUpNames.ThreePoints:
				ScoreManager.score += PowerUp.score;
				gameObject.SetActive(false);
			break;
			case PowerUpNames.FivePoints:
				ScoreManager.score += PowerUp.score;
				gameObject.SetActive(false);
			break;
			case PowerUpNames.TenPoints:
				ScoreManager.score += PowerUp.score;
				gameObject.SetActive(false);
			break;
			case PowerUpNames.HealthBoost:
				healthLevel.fillAmount += PowerUp.powerLevel;
				gameObject.SetActive(false);
			break;

		}
	}

}
