using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour {

	public string[] Names;
	public string[] Keys;

	// Use this for initialization
	void Start () {

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
	}
}
