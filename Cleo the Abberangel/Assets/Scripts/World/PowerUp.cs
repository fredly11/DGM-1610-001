using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUp : MonoBehaviour
{

	public UnityEvent triggerEvent;


	private void OnTriggerEnter(Collider other)
	{

		if (other.tag == "Player")
		{
			triggerEvent.Invoke();
			gameObject.active = false;
		}
	}
}