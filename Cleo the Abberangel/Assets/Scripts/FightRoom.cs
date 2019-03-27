using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FightRoom : MonoBehaviour
{
	public int spawners;
	public int completedSpawners;
	private bool isTriggered;
	public UnityEvent triggerEvent;
	public UnityEvent completeEvent;
	private bool complete;

	private void Update()
	{
		if (completedSpawners == spawners && !complete)
		{
			complete = true;
			completeEvent.Invoke();
		}	
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player" && !isTriggered)
		{
			triggerEvent.Invoke();
			isTriggered = true;
		}


	}

	public void SpawnerComplete()
	{
		completedSpawners++;
	}
}
