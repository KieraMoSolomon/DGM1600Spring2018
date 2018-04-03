using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatConstant : InputBase {

	public float floatValue = 0;

	public override float SetFloat(){
		return floatValue;
	}
}
