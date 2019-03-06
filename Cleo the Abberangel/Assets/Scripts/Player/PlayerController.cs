﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	private Rigidbody2D rb;
	public bool isGrounded;
	public float moveSpeed;
	public float jumpForce;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask groundLayer;
	public float friction;
	public FloatData jumpCount;
	private bool facingright = true;
	public Transform spawnPoint;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		groundLayer = LayerMask.GetMask("World");
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

		if (Input.GetAxis("Horizontal") > 0)
		{
			if (!facingright)Flip();
			facingright = true;
			rb.velocity = new Vector2(moveSpeed, rb.velocity.y);	
		}
		else if (Input.GetAxis("Horizontal") < 0)
		{
			if(facingright)Flip();
			facingright = false;
			rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
		}
		else if (Input.GetAxis("Horizontal") == 0 && isGrounded && rb.velocity.x > 0)
		{
			rb.velocity = new Vector2(rb.velocity.x - friction, rb.velocity.y);
			if(rb.velocity.x < 0) rb.velocity = new Vector2(0, rb.velocity.y); 
		}
		else if (Input.GetAxis("Horizontal") == 0 && isGrounded && rb.velocity.x < 0)
		{
			rb.velocity = new Vector2(rb.velocity.x + friction, rb.velocity.y);
			if(rb.velocity.x > 0) rb.velocity = new Vector2(0, rb.velocity.y); 
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (isGrounded)
			{
				rb.velocity = new Vector2(rb.velocity.x, jumpForce);
			} else if (jumpCount.Value > 0)
			{
				rb.velocity = new Vector2(rb.velocity.x, jumpForce);
				jumpCount.Value--;
			}
		}

		
	}

	void Flip()
	{
		transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
	}




}

