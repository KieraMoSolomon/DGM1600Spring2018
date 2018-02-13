using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayAndLoops : MonoBehaviour {


	public string[] Players;
	public int[] HighScores;
	public PowerUp[] PowerUp;

	// Use this for initialization
	void Start () {
		foreach(var player in Players){
			//do something
			print(player);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
