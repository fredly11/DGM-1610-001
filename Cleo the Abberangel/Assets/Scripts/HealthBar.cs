using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public Image barImage;
	public FloatData fillData;
	 
	// Use this for initialization
	void Start ()
	{
		barImage = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		barImage.fillAmount = fillData.Value / fillData.MaxValue;
	}
}
