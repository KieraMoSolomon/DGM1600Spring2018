using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUpBase : ScriptableObject {

	public int powerLevel;

	public MovePattern MovePatternTransfer;

	public MovePattern Transfer(){
		return MovePatternTransfer;
	}
}
