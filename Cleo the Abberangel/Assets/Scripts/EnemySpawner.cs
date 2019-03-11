using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;

public class EnemySpawner : MonoBehaviour
{
	public GameObject enemyToSpawn;
	private GameObject currentEnemy;
	private int destroyedEnemies;
	public int enemiesToSpawn;
	private bool spawning;
	public UnityEvent completeEvent;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (!currentEnemy && spawning)
		{
			if (destroyedEnemies <= enemiesToSpawn)
			{
				Spawn();
				destroyedEnemies++;
			}
			else
			{
				spawning = false;
				completeEvent.Invoke();
			}
		}

	}

	public void Spawn()
	{
		currentEnemy = Instantiate(enemyToSpawn, transform.position, transform.rotation);
		
		spawning = true;
	}


}
