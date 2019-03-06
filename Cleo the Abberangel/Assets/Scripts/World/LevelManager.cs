using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{

	private PlayerController playerController;
	public FloatData health;
	private float currentTime;
	private float startTime;
	public float respawnDelay;
	private bool respawnStart;
	
	// Use this for initialization
	void Start () {
		playerController = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (respawnStart)
		{
			currentTime++;
		}

		if (currentTime >= startTime + respawnDelay && respawnStart)
		{
					
			playerController.transform.position = playerController.spawnPoint.position;
			playerController.gameObject.SetActive(true);
			health.Value = health.MaxValue;
			respawnStart = false;

		}
	}

	public void Respawn()
	{
		startTime = Time.time;
		currentTime = startTime;
		respawnStart = true;
		playerController.gameObject.SetActive(false);

	}
}
