﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtivnickiAuto : MonoBehaviour {

    public float EcarSpeed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, 1, 0) * EcarSpeed * Time.deltaTime);
	}
}
