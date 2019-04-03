﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ArrowTrigger : MonoBehaviour
{
	public UnityEvent triggerEvent;
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Projectile")
		{
			triggerEvent.Invoke();
		}
	}
}