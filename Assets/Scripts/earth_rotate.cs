using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth_rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Rotate(new Vector3(0, Time.deltaTime * 30, 0));
	}
}
