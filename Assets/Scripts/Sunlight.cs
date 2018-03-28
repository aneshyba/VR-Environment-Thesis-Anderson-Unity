using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunlight : MonoBehaviour {

    // setting a light object 
    public Light lit;
    
    // getting inital conditions for the flicker
    // min cannot be negative
    // speed cannot be negative 
    public bool initSign;
    public float maxInten;
    public float minInten;
    public double speed; 

    // intensity and increase amount
    private double switchSign;
    private float inten; 


	// Use this for initialization
	void Start () {
        inten = (maxInten + minInten) / 2;
        lit.intensity = inten ;
        if (initSign)
        {
            switchSign = .01 * speed; 
        } else
        {
            switchSign = -.01 * speed;
        }
	}
	
	// Update is called once per frame
	void Update () {
        inten = inten + (float) switchSign; 
        lit.intensity = inten; 
        SwitchSign(); 
    }

    // function switches sign of additive 
    private void SwitchSign()
    {
        if (inten < minInten || inten > maxInten)
        {
            switchSign = -switchSign; 
        }
    }
}
