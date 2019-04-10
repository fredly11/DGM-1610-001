using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Experimental.Audio.Google;
using UnityEngine.Experimental.UIElements;

public class ProjectileAttack : MonoBehaviour
{
	public GameObject projectile;
	public Transform firePoint;
	public float thrust = 15;
	public float maxThrust;
	public float minThrust;
	public Camera mainCam;
	public float thrustGain;
	private bool firing;
	private Vector3 mousePosition;
	private GameObject newProjectile;
	private Rigidbody arrowBody;
	

	private float currentTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (firing && thrust < maxThrust)
		{
			thrust += thrustGain;
			if (thrust >= maxThrust) thrust = maxThrust;
		}
		
		if (Input.GetMouseButtonDown(0))
		{
			currentTime = Time.time;
			firing = true;
			thrust = minThrust;
		}

		if (Input.GetMouseButtonUp(0))
		{
			firing = false;
			FireProjectile();
			
		}
	}


	void FireProjectile()
	{
		mousePosition = Input.mousePosition;
		mousePosition.z = firePoint.transform.position.z - mainCam.transform.position.z;
		mousePosition = mainCam.ScreenToWorldPoint (mousePosition);
		var q = Quaternion.FromToRotation (Vector3.up, mousePosition - firePoint.transform.position);

		newProjectile = Instantiate (projectile, firePoint.position, q);
		arrowBody = newProjectile.GetComponent<Rigidbody> ();

		arrowBody.velocity = newProjectile.transform.up * thrust;
	}
}
