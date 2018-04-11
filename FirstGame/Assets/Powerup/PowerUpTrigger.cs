using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTrigger : MonoBehaviour {

	public PowerUpBase PowerUp;

	private void OnTriggerEnter(Collider obj) {
		obj.GetComponent<CharacterControllerLearn>().MovePattern = PowerUp.MovePattern;
		gameObject.SetActive(false);
	}

}
