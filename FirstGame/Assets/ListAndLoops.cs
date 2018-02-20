using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListAndLoops : MonoBehaviour {

	public TheIncredibles TheIncredibles;
	public Text AddMember;
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void OnMouseDown()
	{
		TheIncredibles.FamilyList.Add(AddMember.text);
	}
}
