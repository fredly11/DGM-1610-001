using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingPowerup : MonoBehaviour
{
	public GameObject spawner;
	private GameObject player;
	public int jumpCount = 5;

	private PowerupSpawner ps;
	private PlayerController pc;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Cleo");
		pc = player.GetComponent<PlayerController>();
		ps = spawner.GetComponent<PowerupSpawner>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnTriggerEnter2D(Collider2D other)
	{

		if (other.tag == "Player")
		{
			
			pc.jumpCount = jumpCount;
			Destroy(this.gameObject);
			ps.isRespawning = true;
			ps.currentTime = Time.deltaTime;
		}
	}
}
