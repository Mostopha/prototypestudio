using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpBaddies : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.GetComponent<Rigidbody2D>() != null) {
            this.gameObject.AddComponent<FixedJoint2D>();
            this.gameObject.GetComponent<FixedJoint2D>().connectedBody = coll.gameObject.GetComponent<Rigidbody2D>();
        }
    }
}
