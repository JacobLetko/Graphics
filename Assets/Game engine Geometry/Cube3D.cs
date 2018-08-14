//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class Cube3D : MonoBehaviour 
//{
//	// Use this for initialization
//	void Start ()
//	{
//		var filter = GetComponent<MeshFilter> ();
//		var mesh = new Mesh ();
//		filter.mesh = mesh;
//
//		var verts = new Vector3[8];
//
//		verts [0] = new Vector3 (0, 0, 0);
//		verts [1] = new Vector3 (1, 0, 0);
//		verts [2] = new Vector3 (0, 1, 0);
//		verts [3] = new Vector3 (1, 1, 0);
//		verts [4] = new Vector3 (0, 0, 1);
//		verts [5] = new Vector3 (1, 0, 1);
//		verts [6] = new Vector3 (0, 1, 1);
//		verts [7] = new Vector3 (1, 1, 1);
//
//		mesh.vertices = verts;
//
//		var indices = new int[36];
//
//		indices [0] = 0;
//		indices [1] = 2;
//		indices [2] = 1;
//
//		indices [3] = 2;
//		indices [4] = 3;
//		indices [5] = 1;
//
//		indices [6] = 4;
//		indices [7] = 0;
//		indices [8] = 5;
//
//		indices [9] = 6;
//		indices [10] = 0;
//		indices [11] = 5;
//
//		indices [12] = 7;
//		indices [13] = 4;
//		indices [14] = 8;
//
//		indices [15] = 5;
//		indices [16] = 4;
//		indices [17] = 8;
//
//		indices [18] = 4;
//		indices [19] = 7;
//		indices [20] = 0;
//
//		indices [21] = 2;
//		indices [22] = 7;
//		indices [23] = 0;
//
//		indices [24] = 6;
//		indices [25] = 3;
//		indices [26] = 5;
//
//		indices [27] = 8;
//		indices [28] = 3;
//		indices [29] = 5;
//
//		indices [30] = 2;
//		indices [31] = 7;
//		indices [32] = 3;
//
//		indices [33] = 8;
//		indices [34] = 7;
//		indices [35] = 3;
//
//		mesh.triangles = indices;
//
//		var norms = new Vector3[8];
//
//		norms [0] = -Vector3.forward;
//		norms [1] = -Vector3.forward;
//		norms [2] = -Vector3.forward;
//		norms [3] = -Vector3.forward;
//		norms [4] = -Vector3.forward;
//		norms [5] = -Vector3.forward;
//		norms [6] = -Vector3.forward;
//		norms [7] = -Vector3.forward;
//
//		mesh.normals = norms;
//
//		var UVs = new Vector3[8];
//
//		UVs [0] = new Vector3 (0, 0, 0);
//		UVs [1] = new Vector3 (1, 0, 0);
//		UVs [2] = new Vector3 (0, 1, 0);
//		UVs [3] = new Vector3 (1, 1, 0);
//		UVs [4] = new Vector3 (0, 0, 1);
//		UVs [5] = new Vector3 (1, 0, 1);
//		UVs [6] = new Vector3 (0, 1, 1);
//		UVs [7] = new Vector3 (1, 1, 1);
//
//		mesh.uv = UVs;
//	}
//}
