using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour {

	// Use this for initialization
	
	public int value = 3;
	IEnumerator Start()
	{
		while (value > 0)
		{
			yield return new WaitForSeconds(2);
			print(value);
			value--;
		}

	}
}
