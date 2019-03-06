using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FightRoom : MonoBehaviour
{

	public UnityEvent triggerEvent;
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			triggerEvent.Invoke();
		}
	}
}
