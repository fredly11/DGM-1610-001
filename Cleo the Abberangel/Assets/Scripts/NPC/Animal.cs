using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
	public int maxHealth;
	public int currentHealth;
	public float damage;
	public float moveSpeed;

	private Rigidbody2D rb;
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
