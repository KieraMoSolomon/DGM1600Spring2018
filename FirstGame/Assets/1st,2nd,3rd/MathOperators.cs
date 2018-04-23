using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour {

	public int A;
	public int B;
	public int C;
	public bool health;

	// Use this for initialization
	void Start () {
		/*math operators are the same as the ones we have been learning
		about since we were in first grade. The one that is new for scripting
		is the % which gives the remainder of the divide. It is a great way to
		check if a number is odd or even.*/
		/*This is also going to be my logical operators assignment.
		Logical operators are to compare data with other data
		they are useful to use with if statements and different things
		that need arguments to check.
		 */
		if(A <= 0){
			A++;
		}
		if(A >= 10){
			A--;
		}
		if(A > B){
			A = A + B;
			B = A + C;
			A = C * B;
		}
		if(C == 10){
			C = 5;
		}
		if(health == true && B < 20){
			health = false;
		}
		if(A<B){
			C = 8/2;
		}
		if(B < C){
			B = 3 * 2;
		}
		if(C > A){
			A = C - 10;
			B = 10 + C;
		}
		if(B > 5){
			B = B - 5;
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
