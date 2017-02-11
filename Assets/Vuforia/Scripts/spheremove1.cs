using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spheremove1 : MonoBehaviour {

    // Use this for initialization
    private bool isSpinning = false;
    public int speed = 50;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isSpinning)
        {
            gameObject.transform.Rotate(new Vector3(0, Time.deltaTime*speed, 0));
        }
	}

    public void rightMove()
    {
        gameObject.transform.Translate(new Vector3(0, 0, Time.deltaTime));
    }

    public void leftMove()
    {
        gameObject.transform.Translate(new Vector3(0, 0, -Time.deltaTime));
    }

    public void upMove()
    {
        gameObject.transform.Translate(new Vector3(0, Time.deltaTime, 0));
    }

    public void downMove()
    {
        gameObject.transform.Translate(new Vector3(0, -Time.deltaTime, 0));
    }

    public void frontMove()
    {
        gameObject.transform.Translate(new Vector3(Time.deltaTime, 0, 0));
    }

    public void backMove()
    {
        gameObject.transform.Translate(new Vector3(-Time.deltaTime, 0, 0));
    }

    public void startSpin()
    {
        isSpinning = true;
    }
}
