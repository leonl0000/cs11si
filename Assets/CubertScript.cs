﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubertScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.up / 100;
        transform.localScale *= 1.001f;
	}
}
