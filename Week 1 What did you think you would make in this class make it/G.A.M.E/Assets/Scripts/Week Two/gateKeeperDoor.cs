using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gateKeeperDoor : MonoBehaviour {

    public float sacrifice;
    public GameObject doors;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (sacrifice > 3) {
            Destroy(doors);
        }
	}


    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.transform.tag == "Enemy") {
            sacrifice++;
        }


    }
}
