using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerLearn : MonoBehaviour {

    public MovePattern MovePattern;
	private CharacterController controller;
    

	void Start(){
		controller = GetComponent<CharacterController>();
	}

    void Update() {
       MovePattern.Move(controller, transform);
	}
	
}
