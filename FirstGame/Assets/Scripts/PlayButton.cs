using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour {

	public Button startButton;

	// Use this for initialization
	void Start () {
		
	}

	void OnClick(){
		startButton.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
