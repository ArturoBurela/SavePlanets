using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunShot : MonoBehaviour {

	public int shotRate;
	public GameObject shot;

	// Use this for initialization
	void Start () {

	}

	public void shotStart(){
        StartCoroutine("shotStorm");
    }

	IEnumerator shotStorm() {
		GameObject x;
        Vector3 v = RandomVector3();

        while (true){
            v = RandomVector3();
            x = Instantiate(shot, transform.position, Quaternion.identity);
            x.transform.parent = gameObject.transform;
            x.transform.LookAt(v+transform.position);
            //x.GetComponent<Rigidbody>().velocity = transform.forward;
            x.GetComponent<Rigidbody>().AddForce(x.transform.forward * 100f);
            //x.Destroy(gameObject, 1.0f);
            yield return new WaitForSeconds(5f / (float) shotRate);
		}
	}

	public Vector3 RandomVector3(){
     double x0 = -1.0 + Random.value*2.0;
     double x1 = -1.0 + Random.value*2.0;
     double x2 = -1.0 + Random.value*2.0;
     double x3 = -1.0 + Random.value*2.0;
     while(x0*x0 + x1*x1 + x2*x2 + x3*x3 >= 1){
         x0 = -1.0 + Random.value*2.0;
         x1 = -1.0 + Random.value*2.0;
         x2 = -1.0 + Random.value*2.0;
         x3 = -1.0 + Random.value*2.0;
     }
     double a = x0*x0+x1*x1+x2*x2+x3*x3;
     double x = 2*(x1* x3+x0*x2)/a;
     double y = 2*(x2*x3-x0*x1)/a;
     double z = (x0*x0 + x3*x3 - x1*x1 - x2*x2)/a;
     return new Vector3((float)x, 0f, (float)z);
 }

}
