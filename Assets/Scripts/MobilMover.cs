using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilMover : MonoBehaviour {

    private bool direction;
    public int rotationSpeed;
    public bool initialCond; 

    // Use this for initialization
    void Start () {
        direction = initialCond; 
	}

    public void OnTriggerEnter(Collider other)
    {
        direction = !direction;
    }
    
	// Update is called once per frame
	void Update () {
		if (direction)
        {
            transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * rotationSpeed);
        } else
        {
            transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * -rotationSpeed);
        }
	}
}
