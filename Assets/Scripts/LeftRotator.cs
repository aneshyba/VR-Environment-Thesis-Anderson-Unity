﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRotator : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.left * Time.deltaTime * 2);
	}
}
