using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayAndLoops : MonoBehaviour {

	/*for each loops are great for arrays they will itterate through
	the array or list. They will do what ever is in the block of code for
	each variable in the array.
	*/
	/*Arrays are groups of variables that have indexes and save room
	so you have less to code. They will hold as many items as you need
	them to and you can loop through and do something with each of the
	items in the group. */
	public int[] HighScores;
	public PowerUp[] PowerUp;
	public Player[] Players;
	public int[] Health;
	public string[] Names;
	public string[] Evils;
	public int[] Numbers;
	public float[] Doodoos;
	public int[] EvilHealth;
	public int[] ListOfNumbers;

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
		foreach(var powerups in PowerUp){
			print(powerups);
		}
		foreach(var )

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
