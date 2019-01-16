using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
	public GameObject doorToOpen;
	public Transform targetPoint;
	public float openSpeed;
	public bool isOpening = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isOpening)
		{
			if (doorToOpen.transform.position.y > targetPoint.position.y)
			{
				doorToOpen.transform.position = new Vector2(doorToOpen.transform.position.x, doorToOpen.transform.position.y - openSpeed);
				if (doorToOpen.transform.position.y <= targetPoint.position.y)
				{
					doorToOpen.transform.position = new Vector2(doorToOpen.transform.position.x, targetPoint.position.y);
					isOpening = false;
				}
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			isOpening = true;	
		}
	}
}
