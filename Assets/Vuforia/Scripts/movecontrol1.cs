using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecontrol1 : MonoBehaviour {

    // Use this for initialization
    public spheremove1 Sphere;
    public bool moving = false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.parent = Camera.main.transform;
            moving = true;
        }

        if (moving)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Sphere.upMove();
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                Sphere.downMove();
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Sphere.leftMove();
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Sphere.rightMove();
            }
            if (Input.GetKey(KeyCode.R))
            {
                Sphere.frontMove();
            }
            if (Input.GetKey(KeyCode.L))
            {
                Sphere.backMove();
            }
        }
	}
}
