using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayAndLoops : MonoBehaviour {


	public int[] HighScores;
	public PowerUp[] PowerUp;
	public Player[] Players;

	// Use this for initialization
	void Start () {
		foreach(var Player in Players){
			//do something
			print(Player.PlayerName);
			print(Player.Score);
			print(Player.MPs);
		}
		foreach(var score in HighScores){
			if(score >= 1000){
				print(score);
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
