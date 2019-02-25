﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour {
	private bool canBlink = false;
	private RaycastHit2D hit;
	private GameObject targetProjectile;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var mousePos = Input.mousePosition;
		mousePos.z = 15;
		Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint (mousePos).x, Camera.main.ScreenToWorldPoint (mousePos).y );

		if (Physics2D.Raycast (rayPos, Vector2.zero, 0f)) {
			hit = Physics2D.Raycast (rayPos, Vector2.zero, 0f);

			if (hit.collider.name == "Blink Area") {
				targetProjectile = hit.collider.gameObject.transform.parent.gameObject;
				Debug.Log ("BLink Area");
			} else {
				targetProjectile = hit.collider.gameObject;
			}
			Projectile targetScript = targetProjectile.GetComponent<Projectile>();
			if (targetScript.isFlying) {
				canBlink = false;
			} else {
				canBlink = true;
			}
			//Debug.Log(hit.collider.name);
		} else {
			canBlink = false;
		}


		if (canBlink && Input.GetMouseButtonDown (1)) {
			this.transform.position = hit.transform.position;
		}
	}
}