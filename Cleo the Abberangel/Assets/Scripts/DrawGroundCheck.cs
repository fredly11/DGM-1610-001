using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGroundCheck : MonoBehaviour
{


	public float groundCheckRadius;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.yellow;
		Gizmos.DrawSphere(transform.position, groundCheckRadius);
	}
}
