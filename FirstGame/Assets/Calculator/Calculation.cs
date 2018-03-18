using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Calculation : ScriptableObject 
{
	public float aNum;
	public float bNum;

	public string Calculate(string a, string b){
		aNum = float.Parse(a);
		bNum = float.Parse(b);

		return FinishCalculation();
	}


	public abstract string FinishCalculation();

	
}
