using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUp : ScriptableObject
{

	public int PowerLevel = 10;
	
	public void RunPowerUp(){
		//Adds Value
		Debug.Log(PowerLevel);
	}
	
}

