using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealthManager : MonoBehaviour
{
	public FloatData health;
	[System.Serializable]
	public class DamageEvent : UnityEvent<FloatData>{}

	public DamageEvent damageEvent;


	public UnityEvent deathEvent;
	private bool deathTriggered;

	// Use this for initialization
	void Start ()
	{
	if(damageEvent == null)damageEvent = new DamageEvent();

		
	}
	
	// Update is called once per frame
	void Update () {
		if (health.Value <= 0 && !deathTriggered)
		{
			death();
		} 
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			
		damageEvent.Invoke(other.gameObject.GetComponent<EnemyDerp>().damage);
	
		}
	}


	void death()
	{
		deathTriggered = true;
		deathEvent.Invoke();
	}
}
