using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallingNum : MonoBehaviour {
	

	public Text fallNum;
	public FallingObject fallingObject;
	public Calculation addNum;
	public Calculation subNum;
	public Calculation multNum;
	public Calculation divNum;


	// Use this for initialization
	void Start () {
		fallingObject.CreateFallingNum(fallNum);
	}
	
	// Update is called once per frame
	void Update () {
		if(addNum.solution == fallingObject.fallingNumber || subNum.solution == fallingObject.fallingNumber || multNum.solution == fallingObject.fallingNumber || divNum.solution == fallingObject.fallingNumber){
			fallingObject.CreateFallingNum(fallNum);
		}
	}

}
