using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDerp : MonoBehaviour
{
	private Rigidbody2D rb;
	public Transform player;
	public int damage;

	public float moveSpeed;
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
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
