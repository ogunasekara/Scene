using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecontrol3 : MonoBehaviour {

    // Use this for initialization
    public spheremove1 word;

    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.parent = Camera.main.transform;
        }
    }
}
