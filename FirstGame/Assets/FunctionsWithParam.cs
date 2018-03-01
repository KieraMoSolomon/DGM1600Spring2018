using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithParam : MonoBehaviour {


	public int Health = 20;

	void OnTriggerEnter(Collider other) {
		print("Hit something");
		print(other);

		AddNumbers(14, 2);
		PlayerData("Bob");
		AddHealth(25);
	}

	void AddHealth(int newHealth){
		Health += newHealth;
	}

	void AddNumbers(int a, int b){
		print(a += b);
	}

	void PlayerData(string name){
		print("This player is " + name);
	}


}
