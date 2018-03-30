using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Mult : Calculation {

	public override float FinishCalculation(){
	solution = (aNum * bNum);
	return solution;
}
}
