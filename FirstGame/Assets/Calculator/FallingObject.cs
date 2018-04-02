using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class FallingObject : ScriptableObject {

	public float fallingNumber;
	public Vector3 startPos;
	

	public void CreateFallingNum(Text fallNum){
		fallingNumber = Random.Range(0, 1000);
		fallNum.text = fallingNumber.ToString();
	}
	/*public void ChangeVelocity(){
		
	}*/

}
