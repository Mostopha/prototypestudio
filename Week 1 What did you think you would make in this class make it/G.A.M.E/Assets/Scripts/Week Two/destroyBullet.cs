﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Invoke("zeroRequiem", 2);
	}

    void zeroRequiem() {
        Destroy(this.gameObject);
    }

    
}