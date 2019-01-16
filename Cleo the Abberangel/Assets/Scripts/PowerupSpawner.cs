using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
	public GameObject powerupToSpawn;
	public float respawnTime;
	public float currentTime;
	public bool isRespawning;

	// Use this for initialization
	void Start ()
	{
		SpawnPowerup();
	}
	
	// Update is called once per frame
	void Update () {
		if (isRespawning && Time.deltaTime > currentTime + respawnTime)
		{
			SpawnPowerup();
			isRespawning = false;
		}
	}
	
	void SpawnPowerup()
	{
		Instantiate(powerupToSpawn, gameObject.transform);
	}
}
