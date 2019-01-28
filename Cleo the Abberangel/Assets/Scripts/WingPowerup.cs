using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingPowerup : MonoBehaviour
{
	public GameObject spawner;
	private GameObject player;
	private GameObject playerArt;
	public int jumpCount = 5;
	private Animator playerAnimator;

	private PowerupSpawner ps;
	private PlayerController pc;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Cleo");
		playerArt = GameObject.Find("CleoArt");
		playerAnimator = playerArt.GetComponent<Animator>();
		pc = player.GetComponent<PlayerController>();
		spawner = GameObject.Find("Powerup Spawner");
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
			ps.isRespawning = true;
			ps.currentTime = Time.realtimeSinceStartup;
			Destroy(gameObject);

		}
	}
}
