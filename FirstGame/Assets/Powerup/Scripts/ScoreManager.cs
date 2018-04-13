using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	public static int score;
	public Text scoreDisplay;

	
	// Update is called once per frame
	void Update () {
		scoreDisplay.text = "Score: " + score;
	}
}
