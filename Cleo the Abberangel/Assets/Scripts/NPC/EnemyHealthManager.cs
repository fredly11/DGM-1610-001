using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealthManager : MonoBehaviour
{
	public FloatData health;
	private bool knockedDown;
	public UnityEvent knockDownEvent;
	public UnityEvent deathEvent;
	public FloatData playerDamage;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void TakeDamage(float damageToTake)
	{
		health.value -= damageToTake;
		if (health.value <= 0)
		{
			knockedDown = true;
			knockDownEvent.Invoke();
		}
	}

	void Die()
	{
		deathEvent.Invoke();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{ 

		if (other.gameObject.tag == "Projectile")
		{
			print("Arrow Collision");
			if (!knockedDown)
			{
				TakeDamage(playerDamage.value);
			}
			else
			{
				Die();
			}
		}
	}
}