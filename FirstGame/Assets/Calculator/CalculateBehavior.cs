using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculateBehavior : MonoBehaviour {

	public Calculation Calculation;
	public InputField Input1;
	public InputField Input2;
	public Text Solution;
	public Button Addition;
	public Button Subtraction;
	public Button Multiply;
	public Button Divide;

	public void RunCalculation(){
		Solution.text = Calculation.Calculate(Input1.text, Input2.text).ToString();
	}

	public void DisableAddButtonOnClick(){
		Addition.interactable = false;
	}

	public void DisableSubButton(){
		Subtraction.interactable = false;
	}

	public void DisableMultButton(){
		Multiply.interactable = false;
	}

	public void DisableDivButton(){
		Divide.interactable = false;
	}
}
