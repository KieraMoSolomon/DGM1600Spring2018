using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour {

	public string[] Names;
	public string[] Keys;

	// Use this for initialization
	void Start () {

		//A for loop will go through the loop until the second part
		//which is the arrgument, is false. Then it will stop going through the loop
		//the first part is the declaration of the integer.
		//the last part is when the int changes so that it's not a never ending loop
		for(int i = 0; i < Names.Length; i++){
			print(Names[i]);
		}	

		for(int i = 0; i < Keys.Length; i++){
			print(Keys[i]);
		}
		for(int i = 0; i < 10; i++){
			print(i);
		}
		for(int i = 0; i < 4; i++){
			print("not in school yet, too young");
		}
		for(int i = 0; i < 16; i++){
			print("Can't drive yet");
		}
		for(int i = 0; i < 18; i++){
			print("Can't vote yet");
		}
		for(int i = 0; i < 21; i++){
			print("Can't drink yet");
		}
		for(int i = 0; i < 25; i++){
			print("Can't rent a car");
		}
		for(int i = 0; i < 65; i++){
			print("Can't retire yet");
		}
		for(int i = 0; i < 10; i++){
			print("Can't graduate yet");
		}
	}
}
