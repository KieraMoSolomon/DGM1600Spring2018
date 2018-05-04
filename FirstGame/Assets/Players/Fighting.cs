using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighting : MonoBehaviour {

	public int damage = 10;
	public float timeBetween = 0.2f;
	public GameObject bulletPrefab;
    public Transform bulletSpawn;

	float timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(timer >= timeBetween){
			while(Input.GetButton("Fire1")){
				Shoot();
			}
		}
	}

	void Shoot(){
		timer = 0f;
		//instantiate bullet
		//var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
		//bullet.GetComponent().velocity = bullet.transform.forward * 5;
		if(/*Bullet hit something*/true){
			//HarmingEnemy harm = /*bullet hit. collider.GetComponent();*/
			
			if(/*harm != null*/true){
				//do a get function to get the placehit variable from the bullet script
				//harm.TakeDamage(damage, /*vector3 of place hit*/);
			}
			//destroy bullet
			//Destroy(bullet);
		}
	}
}
