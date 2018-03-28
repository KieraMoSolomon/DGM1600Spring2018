using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerLearn : MonoBehaviour {

	public CCScriptable Script;
	private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;

	void Start(){
		controller = GetComponent<CharacterController>();
	}

    void Update() {
        if (controller.isGrounded) {
            moveDirection.x = Input.GetAxis("Horizontal");
			moveDirection.z = Input.GetAxis("Vertical");
			moveDirection.y = 0;

			moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
            
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
	}
	
}
