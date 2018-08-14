using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Focus : MonoBehaviour
{
	public float range;

	public float intensity;
	public float spotAngle;

	Light light;

	void Start () 
	{
		light = GetComponent<Light> ();
		intensity = light.intensity;
		spotAngle = light.spotAngle;
	}

	void Update ()
	{
		spotAngle = range;
		intensity = (10 * (100 - spotAngle)) / (spotAngle / 2);

		light.spotAngle = spotAngle;
		light.intensity = intensity;
	}
}
