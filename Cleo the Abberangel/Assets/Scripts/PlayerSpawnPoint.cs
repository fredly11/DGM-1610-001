using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnPoint : MonoBehaviour
{

	public GameObject pc;

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			pc.GetComponent<PlayerController>().spawnPoint = gameObject.transform;
		}
	}
}
