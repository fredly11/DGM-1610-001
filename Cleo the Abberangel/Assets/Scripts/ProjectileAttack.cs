using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Audio.Google;
using UnityEngine.Experimental.UIElements;

public class ProjectileAttack : MonoBehaviour
{
	public GameObject projectile;
	public Transform firePoint;
	public float thrust = 15;
	public Camera mainCam;
	private Vector3 mousePosition;
	private GameObject newProjectile;
	private Rigidbody2D arrowBody;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			FireProjectile();
		}
	}


	void FireProjectile()
	{
		mousePosition = Input.mousePosition;
		mousePosition.z = firePoint.transform.position.z -mainCam.transform.position.z;
		mousePosition = mainCam.ScreenToWorldPoint (mousePosition);
		var q = Quaternion.FromToRotation (Vector3.up, mousePosition - firePoint.transform.position);

		newProjectile = Instantiate (projectile, firePoint.position, q);
		arrowBody = newProjectile.GetComponent<Rigidbody2D> ();

		arrowBody.velocity = newProjectile.transform.up * thrust;
	}
}
