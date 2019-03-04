using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealthManager : MonoBehaviour
{
	public FloatData health;
	public UnityEvent damageEvent;
	public float enemyDamage;

	public UnityEvent deathEvent;
	

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update () {
		if (health.value <= 0)
		{
			death();
		} 
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			enemyDamage = other.gameObject.GetComponent<EnemyDerp>().damage.value;

			health.value -= enemyDamage;

		}
	}


	void death()
	{
		deathEvent.Invoke();
	}
}
