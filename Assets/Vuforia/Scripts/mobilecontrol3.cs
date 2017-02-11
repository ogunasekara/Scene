using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobilecontrol3 : MonoBehaviour {

    // Use this for initialization
    public spheremove1 word;
    public bool moving = true;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase != TouchPhase.Moved && moving)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            gameObject.transform.parent = Camera.main.transform;
            moving = false;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase != TouchPhase.Moved && !moving)
        {
            gameObject.transform.localScale = new Vector3(0, 0, 0);
            moving = true; 
        }
    }
}
