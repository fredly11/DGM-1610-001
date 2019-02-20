using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

	public Transform startPoint;
	public Transform endPoint;

	public float moveSpeed;

	private bool moveTowards = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (moveTowards)
		{
			gameObject.transform.position = Vector3.MoveTowards(transform.position, endPoint.transform.position, moveSpeed);
			if (transform.position == endPoint.transform.position) moveTowards = false;
		}
		else
		{
			gameObject.transform.position = Vector3.MoveTowards(transform.position, startPoint.transform.position, moveSpeed);
			if (transform.position == startPoint.transform.position) moveTowards = true;
		}

		
		
	}
}
