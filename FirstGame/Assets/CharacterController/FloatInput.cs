using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewInput")]
public class FloatInput : InputBase {

	public string inputName = "Horizontal";

	public override float SetFloat(){
		return Input.GetAxis(inputName);
	}
}