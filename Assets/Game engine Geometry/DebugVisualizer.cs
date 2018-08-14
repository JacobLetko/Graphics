using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class DebugVisualizer : MonoBehaviour 
{
	void OnDrawGizmosSelected()
	{
		Mesh mesh = GetComponent<MeshFilter> ().mesh;

		Gizmos.color = Color.white;

		foreach (var vert in mesh.vertices)
		{
			Gizmos.DrawSphere (transform.TransformPoint(vert), 0.1f);
		}
	}
}