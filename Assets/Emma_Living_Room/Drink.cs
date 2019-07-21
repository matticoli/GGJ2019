using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Drink : MonoBehaviour {

    smoke smoketest;

    // Use this for initialization
    void Start () {
        smoketest = GameObject.Find("Smoke").GetComponent<smoke>();

        

    }

    // Update is called once per frame
    void Update () {
        
		
	}

   
}
