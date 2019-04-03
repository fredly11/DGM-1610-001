using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyDoor : MonoBehaviour
{

	public Collection keys;

	public UnityEvent triggerEvent;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			if (keys.collection.Count == 4)
			{
				triggerEvent.Invoke();
			}
		}
	}
}
