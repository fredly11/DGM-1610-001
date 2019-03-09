using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EnemySpawner : MonoBehaviour
{
	public GameObject enemyToSpawn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn()
	{
		Instantiate(enemyToSpawn);
	}
}
