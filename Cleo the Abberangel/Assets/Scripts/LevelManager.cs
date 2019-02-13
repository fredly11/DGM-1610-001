using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

	private PlayerController playerController;
	
	// Use this for initialization
	void Start () {
		playerController = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Respawn()
	{
		playerController.gameObject.SetActive(false);
		playerController.transform.position = playerController.spawnPoint.position;
		playerController.gameObject.SetActive(true);
	}
}
