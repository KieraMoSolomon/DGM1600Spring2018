using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallingNum : MonoBehaviour {
	public float fallingNumber;
	public Text fallNum;

	// Use this for initialization
	void Start () {
		CreateFallingNum();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CreateFallingNum(){
		fallingNumber = Random.Range(0, 1000);
		fallNum.text = fallingNumber.ToString();
	}
}
