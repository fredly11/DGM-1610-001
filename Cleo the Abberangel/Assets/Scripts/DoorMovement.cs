using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{
	private Vector3 startPosition;
	private Vector3 endPosition;
	private bool moving;

	public float moveDistance;
	public float moveSpeed;

	public bool startClosed;
	// Use this for initialization
	void Start ()
	{
		startPosition = transform.position;
		endPosition = startPosition;
		if (startClosed)
		{
			endPosition.y -= moveDistance;
		}
		else
		{
			endPosition.y += moveDistance;
		}
		

	}
	
	// Update is called once per frame
	void Update () {
		if (moving && transform.position != endPosition)
		{
			transform.position = Vector3.MoveTowards(transform.position, endPosition, moveSpeed * Time.deltaTime);
			if (transform.position == endPosition)
			{
				moving = false;
				endPosition = startPosition;
			}
		}
	}

	public void Move()
	{
		moving = true;
	}
}
