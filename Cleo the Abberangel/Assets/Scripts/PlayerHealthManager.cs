using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealthManager : MonoBehaviour
{
	public FloatData maxHealth;
	public FloatData currentHealth;
	public UnityEvent damageEvent;

	private EnemyDerp enemy;
	// Use this for initialization
	void Start ()
	{
		currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			enemy = other.gameObject.GetComponent<EnemyDerp>();
			damageEvent.Invoke();
		}
	}

	void takeDamage(int damageToTake)
	{
		print("take damage");
		currentHealth.value -= damageToTake;
		if (currentHealth.value <= 0)
		{
		death();	
		}
	}

	void death()
	{
		print("I died");
	}
}
