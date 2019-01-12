using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Rigidbody2D rb;
	public bool isGrounded;
	public float moveSpeed;
	public float jumpForce;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask groundLayer;
	
	
	
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

		if (Input.GetAxis("Horizontal") > 0)
		{
			rb.velocity = new Vector2(moveSpeed, rb.velocity.y);	
		}
		else if (Input.GetAxis("Horizontal") < 0)
		{
			rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
		}
	

		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			rb.velocity = new Vector2(rb.velocity.x, jumpForce);
		}
	}

}

