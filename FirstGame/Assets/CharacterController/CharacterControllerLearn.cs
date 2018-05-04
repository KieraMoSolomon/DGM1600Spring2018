using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControllerLearn : MonoBehaviour {

    public Player Player;
	private CharacterController controller;
	public Image healthLevel;
	public GameObject Hero;
	Renderer rend;
    

	void Start(){
		controller = GetComponent<CharacterController>();
		rend = GetComponent<Renderer>();
	}

    void Update() {
       Player.MovePattern.Move(controller, transform);
	   if(healthLevel.fillAmount == 0){
		   StartCoroutine("ChangeColor");
	   }
	}

	IEnumerator ChangeColor(){
		for (float f = 1f; f >= 0; f -= 0.5f){
			Color c = rend.material.color;
        	c.a = f;
        	rend.material.color = c;
			yield return null;
		}
	}
	
}
