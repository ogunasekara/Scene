using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecontrol2 : MonoBehaviour {

    // Use this for initialization
    public spheremove1 element;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            element.startSpin();
        }
    }
}
