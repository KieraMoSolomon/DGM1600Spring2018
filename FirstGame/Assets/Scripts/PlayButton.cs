using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour {

	public Transform startButton;
	public Transform pausePanel;
	

	//public gameObject menu;
	public Animator animator;

	public void StartButtonWhenClicked(){
		animator.SetTrigger("StartGame");
		startButton.gameObject.SetActive(false);
		pausePanel.gameObject.SetActive(true);
	}

	public void PauseButtonOnClick(){
		animator.SetTrigger("PauseGame");
		startButton.gameObject.SetActive(true);
		pausePanel.gameObject.SetActive(false);
	}
}
