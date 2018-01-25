using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windPush : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.GetComponent<PlayerMovementScript>().isGliding == true) {

            //col.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 100);
            Debug.Log("ForcePushed");
        }

    }

    void OnTriggerStay2D(Collider2D col) {
        if (col.gameObject.GetComponent<PlayerMovementScript>().isGliding == true) {

            col.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 20);
            Debug.Log("ForcePushed");
        }

    }


}
