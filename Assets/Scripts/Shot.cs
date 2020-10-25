using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

	private float ttl = 30f;

	// Use this for initialization
	void Start () {
		StartCoroutine("destroyShot");
	}

	IEnumerator destroyShot() {
		// Destroy every sun shot after x seconds
		yield return new WaitForSeconds(ttl);
		Destroy(gameObject);
	}
}
