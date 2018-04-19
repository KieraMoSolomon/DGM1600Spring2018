using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerLearn : MonoBehaviour {

    public Player Player;
	private CharacterController controller;

    

	void Start(){
		controller = GetComponent<CharacterController>();
	}

    void Update() {
       Player.MovePattern.Move(controller, transform);
	}
	
}
