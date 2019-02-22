using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{

	private PlayerController playerController;
	public FloatData health;
	
	// Use this for initialization
	void Start () {
		playerController = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Respawn()
	{
		playerController.gameObject.SetActive(false);
		playerController.transform.position = playerController.spawnPoint.position;
		playerController.gameObject.SetActive(true);
		health.value = health.maxValue;
	}
}
