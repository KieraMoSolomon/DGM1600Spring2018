using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculateBehavior : MonoBehaviour {

	public Calculation Calculation;
	public InputField Input1;
	public InputField Input2;
	public Text Solution;

	public void RunCalculation(){
		Solution.text = Calculation.Calculate(Input1.text, Input2.text).ToString();
	}
}
