﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressurePlate : MonoBehaviour
{

	public UnityEvent triggered;
	private bool trig;

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player" && !trig)
		{
			trig = true;
			triggered.Invoke();
		}
	}


}
