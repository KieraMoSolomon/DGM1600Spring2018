using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Divide : Calculation {

public override float FinishCalculation(){
	solution = (aNum / bNum);
	return solution;
}
}
