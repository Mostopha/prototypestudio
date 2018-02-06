using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devourEnemies : MonoBehaviour {
    public gameManagerScript GM;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.transform.tag == "Enemy") {
            Destroy(coll.gameObject);

            GM.score++;

        }

    }
}
