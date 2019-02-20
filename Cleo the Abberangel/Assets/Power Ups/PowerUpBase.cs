using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PowerUpBase : ScriptableObject
{

	public float value = 10;
	
	// Use this for initialization
	void OnEnable ()
	{
		value = 5;
	}

}
