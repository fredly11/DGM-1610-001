using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	Rigidbody2D rb;
	FixedJoint2D fj;
	public bool isFlying = true;
	public float flyingLife = 0;
	public float stuckLife = 0;
	float currentTime;
	float startTime;
	private bool stuck = false;
	private CircleCollider2D collider;


	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		fj = GetComponent<FixedJoint2D> ();
		collider = GetComponent<CircleCollider2D>();
		isFlying = true;
		startTime = Time.time;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!isFlying) {
			if (Time.time - currentTime >= stuckLife) {
				Destroy (gameObject);
			}
		}
		
		if (isFlying) {
			if (Time.time - startTime >= flyingLife) {
				Destroy (gameObject);
			}
			float angle = Mathf.Atan2 (rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
		}
	}
	
	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "ProjectileBreaker")
		{
			Destroy(gameObject);
		}
		if (other.tag != "Player" && other.tag != "Projectile" && other.name != "Slider" && other.tag != "Blink" && other.tag != "NoProjectileCollision") {
				currentTime = Time.time;
				isFlying = false;
				rb.velocity = Vector2.zero;
				rb.gravityScale = 0;
				fj.enabled = true;
				fj.connectedBody = other.GetComponent<Rigidbody2D>();
				stuck = true;
				collider.enabled = false;
			
		}
	}
}

