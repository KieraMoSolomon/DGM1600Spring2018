using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarmingEnemy : MonoBehaviour {

	public int enemyHealth = 50;
	public int currentHealth;
	public ParticleSystem hitPart;
	bool enemyDead;

	// Use this for initialization
	void Start () {
		currentHealth = enemyHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if(enemyDead){
			Destroy(gameObject);
		}
		
	}

	void TakesDamage(int amount, Vector3 placeHit){
		if(enemyDead){
			return;
		}
		
		currentHealth -= amount;
		hitPart.transform.position = placeHit;
		hitPart.Play();
		if(currentHealth <= 0){
			enemyDead = true;
		}
	}
}
