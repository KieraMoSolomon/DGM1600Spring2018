using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighting : MonoBehaviour {

	public int damage = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		while(Input.GetButton("Fire1")){
			Shoot();
		}
	}

	void Shoot(){
		//instantiate bullet

		if(/*Bullet hit something*/true){
			//HarmingEnemy harm = /*bullet hit. collider.GetComponent();*/
			
			if(/*harm != null*/true){
				//harm.TakeDamage(damage, /*vector3 of place hit*/);
			}
			//destroy bullet
		}
	}
}
