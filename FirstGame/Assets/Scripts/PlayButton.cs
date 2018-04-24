using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour {

	public Transform startButton;
	//public gameObject menu;
	public Animator animator;

	public void WhenClicked(){
		animator.SetTrigger("StartGame");
		startButton.gameObject.SetActive(false);
	}
}
