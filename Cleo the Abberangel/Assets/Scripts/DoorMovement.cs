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

	// Use this for initialization
	void Start ()
	{
		startPosition = transform.position;
		endPosition = startPosition;
		endPosition.y -= moveDistance;
	}
	
	// Update is called once per frame
	void Update () {
		if (moving)
		{
			transform.position = Vector3.MoveTowards(transform.position, endPosition,moveSpeed);
		}
	}
}
