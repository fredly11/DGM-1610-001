﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EnemyDerp : MonoBehaviour
{
	private Rigidbody rb;
	public Transform player;
	public FloatData damage;
	private bool moving = true;

	public float moveSpeed;
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		player = GameObject.Find("Cleo").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (moving)
		{
			if (transform.position.x > player.position.x)
			{
				rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
			}
			else
			{
				rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
			}
		}
	}
	public void KnockDown()
	{
		moving = false;
		gameObject.tag = "Knocked Down";
	}

	public void Death()
	{
		gameObject.active = false;
	}


}