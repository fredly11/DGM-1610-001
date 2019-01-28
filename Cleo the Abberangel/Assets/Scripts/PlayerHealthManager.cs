using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
	public float maxHealth;

	public float currentHealth;

	private EnemyDerp enemy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			enemy = other.gameObject.GetComponent<EnemyDerp>();
			takeDamage(enemy.damage);
		}
	}

	void takeDamage(int damageToTake)
	{
		currentHealth -= damageToTake;
		if (currentHealth <= 0)
		{
		death();	
		}
	}

	void death()
	{
		
	}
}
