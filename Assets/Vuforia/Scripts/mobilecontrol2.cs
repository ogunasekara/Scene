using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobilecontrol2 : MonoBehaviour {

    // Use this for initialization
    public spheremove1 Sphere;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase != TouchPhase.Moved)
        {
            Sphere.startSpin();
        }
    }
}
