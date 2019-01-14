using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingPowerup : MonoBehaviour
{
	public GameObject player;
	public int jumpCount;

	private PlayerController pc;
	// Use this for initialization
	void Start () {
		pc = player.GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{

		if (other.tag == "Player")
		{

			pc.jumpCount = 5;
			Destroy(this.gameObject);
		}
	}
}
