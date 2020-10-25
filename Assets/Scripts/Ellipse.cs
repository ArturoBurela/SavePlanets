using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellipse : MonoBehaviour {
	public LineRenderer r;
	[Range(3,360)]
	public int verticesNum;
	public float xAxis;
	public float yAxis;

	void Awake(){
		r = GetComponent<LineRenderer> ();
		createEllipse();
	}

	void createEllipse(){
		Vector3[] vertices = new Vector3[verticesNum];
		for (int i=0; i< verticesNum; i++) {
			float angle = ((float) i / (float) verticesNum) * 360 * Mathf.Deg2Rad;
			float x = Mathf.Sin(angle) * xAxis;
			float y = Mathf.Cos(angle) * yAxis;
			vertices[i] = new Vector3(x,3f,y);
		}
		r.positionCount = verticesNum;
		r.SetPositions(vertices);
	}
}
