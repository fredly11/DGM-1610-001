using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
	public float maxHealth;

	public float currentHealth;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void TakeDamage(float damageToTake)
	{
		currentHealth -= damageToTake;
		if (currentHealth <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		
	}
}
