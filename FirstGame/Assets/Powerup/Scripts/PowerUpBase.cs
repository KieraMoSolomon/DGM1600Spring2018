using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUpBase : ScriptableObject {

	public float powerLevel;
	public int score;

	public MovePattern MovePattern;
}
