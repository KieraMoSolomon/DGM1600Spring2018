using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithParam : MonoBehaviour {

/*This is also for void functions! Void functions don't return anything.
they can take in parameters but they will not send data. They just return a
null value. */
/*Functions with parameters need variables from other functions
they use those variables to complete their code block. When you call a function
that requires a parameter it will demand that there is the correct type of variable sent
to the function you are calling.
 */
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
	void SubNumbers(int a, int b){
		print(a - b);
	}
	void MultNumbers(int a, int b){
		print(a * b);
	}
	void DivNumbers(float a, float b){
		print(a/b);
	}
	void PlayerHealing(int healingPower){
		Health += healingPower;
	}
	void PlayerHelper(int identity){
		print(identity);
	}
	void DontKnow(string yep){
		print(yep);
	}

}
