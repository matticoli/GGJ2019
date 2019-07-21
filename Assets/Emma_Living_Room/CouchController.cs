using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CouchController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

    bool animated = false;

    public void Animate()
    {
        if(!animated)
        {
        GetComponent<Animation>().Play();
            animated = true;
            GetComponent<AudioSource>().Play();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
