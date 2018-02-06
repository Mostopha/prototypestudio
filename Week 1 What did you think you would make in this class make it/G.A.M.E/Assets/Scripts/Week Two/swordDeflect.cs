using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordDeflect : MonoBehaviour {
    public Rigidbody2D bulletBod;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter2D(Collision2D coll) {
        if (coll.transform.tag == "bullet") {
            bulletBod = coll.gameObject.GetComponent<Rigidbody2D>();

            bulletBod.velocity = -bulletBod.velocity;

            
        }
    }
}
