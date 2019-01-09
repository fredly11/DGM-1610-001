using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {
	public GameObject target;

	public float cameraDistance;
	// Use this for initialization
	void Start () {
	
}
	
	// Update is called once per frame
	void Update ()
	{
		gameObject.transform.position = new Vector3(target.transform.position.x, target.transform.position.y, cameraDistance);

	}
}
