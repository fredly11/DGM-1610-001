using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnPoint : MonoBehaviour
{

	public GameObject pc;

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Player")
		{
			pc.GetComponent<PlayerController>().spawnPoint = gameObject.transform;
		}
	}
}
