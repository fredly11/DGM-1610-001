using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	private CharacterController cc;
	public bool isGrounded;
	public float moveSpeed;
	public float jumpForce;
	public float gravity;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask groundLayer;

	public FloatData jumpCount;
	private bool facingright = true;
	public Transform spawnPoint;
	private Vector3 moveDirection = Vector3.zero;

	// Use this for initialization
	void Start ()
	{
		cc = GetComponent<CharacterController>();
		groundLayer = LayerMask.GetMask("World");
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	//	isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

		if (Input.GetAxis("Horizontal") > 0)
		{
			if (!facingright)Flip();
			facingright = true;
			moveDirection.x = moveSpeed;
		}
		else if (Input.GetAxis("Horizontal") < 0)
		{
			if(facingright)Flip();
			facingright = false;
			moveDirection.x = -moveSpeed;
		}
		else
		{
			moveDirection.x = 0;
		}


		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (cc.isGrounded)
			{
				moveDirection.y = jumpForce;

			} else if (jumpCount.Value > 0)
		//	{
				moveDirection.y = jumpForce;
				jumpCount.Value--;
		//	}
		}
		moveDirection.y -= gravity * Time.deltaTime;
		cc.Move(moveDirection * Time.deltaTime);
		
	}

	void Flip()
	{
		transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
	}




}

