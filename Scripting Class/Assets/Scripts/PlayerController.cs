using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Rigidbody2D rb;

	public float moveSpeed;
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A))
		{
			rb.velocity = new Vector2(-moveSpeed, 0);	
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			rb.velocity = new Vector2(moveSpeed, 0);
		}
	}
}

