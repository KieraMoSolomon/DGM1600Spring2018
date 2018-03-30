using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Subtract : Calculation {

public override float FinishCalculation(){
	solution = (aNum - bNum);
	return solution;
}

}
