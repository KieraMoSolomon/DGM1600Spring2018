using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Mult : Calculation {

	public override string FinishCalculation(){
	return (aNum * bNum).ToString();
}
}
