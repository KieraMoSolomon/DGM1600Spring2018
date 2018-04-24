using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicAI : MonoBehaviour {
	
	public NavMeshAgent Agent;
	private int pointGoTo = 0;
	public Transform[] PatrolPositions;


	void Start(){
		Agent = GetComponent<NavMeshAgent>();
		SwitchDirection();
	}

	void SwitchDirection(){
		Agent.destination = PatrolPositions[pointGoTo].position;
		pointGoTo = (pointGoTo + 1) % PatrolPositions.Length;
	}

	void Update(){
		if(!Agent.pathPending && Agent.remainingDistance < 0.5f){
			SwitchDirection();
		}
	}
	
}
