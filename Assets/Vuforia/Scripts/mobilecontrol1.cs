using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobilecontrol1 : MonoBehaviour {

    // Use this for initialization
    public spheremove1 Sphere;
    public bool moving = false;
    public float speed = 0.1F;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 && Input.GetTouch(0).phase != TouchPhase.Moved)
        {
            gameObject.transform.parent = Camera.main.transform;
            moving = true;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved && moving)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            gameObject.transform.Translate(new Vector3(0, 0, touchDeltaPosition.x * speed));
            gameObject.transform.Rotate(new Vector3(touchDeltaPosition.y * speed, 0, 0));
        }
	}
}
