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
	public UnityEvent damageEvent;
	public FloatData playerDamage;

	private int trigCount;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void TakeDamage()
	{
		damageEvent.Invoke();
		if (health.Value <= 0)
		{
			knockedDown = true;
			knockDownEvent.Invoke();
		}
	}

	void Die()
	{
		deathEvent.Invoke();
	}

	private void OnTriggerEnter(Collider other)
	{ 

		if (other.gameObject.tag == "Projectile")
		{
			trigCount++;
			if (trigCount == 2)
			{
				trigCount = 0;
				print("Arrow Collision");
				if (!knockedDown)
				{
					TakeDamage();
			
				}
				else
				{
					Die();
				}
			}
		}
	}
}