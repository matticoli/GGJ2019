﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoke : MonoBehaviour {
    ParticleSystem ps;

    // Use this for initialization
    void Start () {
        ps = GetComponent<ParticleSystem>();
       

    }
	
	// Update is called once per frame
	void Update () {

        var main = ps.main;
        main.maxParticles += 50;
		
	}
}
