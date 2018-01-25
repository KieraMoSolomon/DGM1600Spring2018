using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {


	public string name;

	public int foodCount;
	// Use this for initialization
	
	void OnMouseDown()
	{
		print(name);
		print(foodCount);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
