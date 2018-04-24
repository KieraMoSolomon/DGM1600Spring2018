using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

	public Button startButton;

	public void WhenClicked(){
		startButton.interactable = false;
	}
}
