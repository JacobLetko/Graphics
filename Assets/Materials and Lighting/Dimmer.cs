using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dimmer : MonoBehaviour 
{
	public float current;
	public float num;

	private void Start()
	{
		current = GetComponent<Light> ().intensity;
	}

	private void Update()
	{
		if (current < num)
			current += .02f;
		if (current > num)
			current -= .02f;

		GetComponent<Light> ().intensity = current;
	}
}
