using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Switch : MonoBehaviour
{

	public UnityEvent startEvent, playingEvent, dyingEvent, endingEvent;
	public enum states
	{
		starting,
		playing,
		dying,
		ending
	}

	public states currentState;
	
	// Use this for initialization
	void Start () {

		switch (currentState)
		{
			case states.starting:
				startEvent.Invoke();
				break;
			case states.playing:
				playingEvent.Invoke();
				break;
			case states.ending:
				endingEvent.Invoke();
				break;
			case states.dying:
				dyingEvent.Invoke();
				break;
			default:
				throw new ArgumentOutOfRangeException();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
