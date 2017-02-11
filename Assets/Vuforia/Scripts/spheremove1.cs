using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spheremove1 : MonoBehaviour {

    // Use this for initialization
    private bool isSpinning = false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isSpinning)
        {
            gameObject.transform.Rotate(new Vector3(0, Time.deltaTime*50, 0));
        }
	}

    public void rightMove()
    {
        gameObject.transform.Translate(new Vector3(Time.deltaTime, 0, 0));
    }

    public void startSpin()
    {
        isSpinning = true;
    }
}
