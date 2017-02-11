using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class make_sphere : MonoBehaviour {

    // Public variables for inter-script communication
    public Material mat;
    public GameObject[] sphere_objects = new GameObject[4];
    public GameObject self;

    // Private variables for local use
    private int count;

	// Use this for initialization
	void Start () {
        count = 0;        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0) && count < 4)
        {
            createSphere();
        }
    }

    void createSphere() {
        sphere_objects[count] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere_objects[count].transform.SetParent(self.transform);
        sphere_objects[count].transform.position = new Vector3(0, 0, -1/10);
        sphere_objects[count].GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat);
        sphere_objects[count].GetComponent<Renderer>().material.SetFloat("_Smoothness", 739/1000);
    }
}
