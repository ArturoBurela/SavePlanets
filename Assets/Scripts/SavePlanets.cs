using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlanets : MonoBehaviour {

    string planetName;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Check for touch inputs
        if(Input.touchCount > 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if(Physics.Raycast(ray, out Hit))
            {
                planetName = Hit.transform.name;
                switch (planetName)
                {
                    case "Mercurio":
                        GameObject.Find(planetName).transform.GetChild(0).GetComponent<Planet>().pressed = true;
                        break;
                    default:
                        break;
                }
            }
        }
	}
}
