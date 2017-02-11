using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecontrol1 : MonoBehaviour {

    // Use this for initialization
    public spheremove1 Sphere;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
        {
            Sphere.startSpin();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.parent = Camera.main.transform;
            Sphere.rightMove();
        }
	}
}
