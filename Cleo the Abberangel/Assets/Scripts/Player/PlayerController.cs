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
		moveDirection.y -= gravity;
	
	//	isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

		if (Input.GetAxis("Horizontal") > 0)
		{
			if (!facingright)Flip();
			facingright = true;
			cc.Move(new Vector3(moveSpeed, cc.velocity.y, 0));
		}
		else if (Input.GetAxis("Horizontal") < 0)
		{
			if(facingright)Flip();
			facingright = false;
			cc.Move(new Vector3(-moveSpeed, cc.velocity.y, 0));
		}


		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (cc.isGrounded)
			{
				moveDirection.y = jumpForce;
				cc.Move(moveDirection);
			} else if (jumpCount.Value > 0)
			{
				cc.Move(moveDirection);
				jumpCount.Value--;
			}
		}

		
	}

	void Flip()
	{
		transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
	}




}

