using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stabCritter : MonoBehaviour {
    private bool attached;
    public GameObject collGameObject;

	// Use this for initialization
	void Start () {

        attached = false;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1")) {
            
            collGameObject.transform.parent = null;
            collGameObject.GetComponent<Rigidbody2D>().simulated = true;

            attached = false;
            collGameObject = null;
            
        }

        if (Input.GetButton("Fire1")) {
            this.GetComponent<Collider2D>().enabled = false;
            this.transform.parent.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            this.transform.parent.transform.parent.gameObject.GetComponent<Collider2D>().enabled = false;
        }
        else {
            this.GetComponent<Collider2D>().enabled = true;
            this.transform.parent.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            this.transform.parent.transform.parent.gameObject.GetComponent<Collider2D>().enabled = true;
        }

    }
    
    void OnCollisionEnter2D(Collision2D coll) {
        if (attached == false) {
            if (coll.gameObject.GetComponent<Rigidbody2D>() != null) {
                if (coll.gameObject.transform.tag == "Enemy") {

                    //GameObject toDestroy = coll.transform.parent.gameObject;
                    //toDestroy.GetComponent<enemyShootAtPlayer>().enabled = false;

                    coll.gameObject.transform.parent = this.gameObject.transform;
                    coll.gameObject.GetComponent<Rigidbody2D>().simulated = false;

                    collGameObject = coll.gameObject;

                    /*if (coll.gameObject.GetComponent<Rigidbody2D>() != null) {
                        this.gameObject.transform.root.gameObject.AddComponent<FixedJoint2D>();
                        this.gameObject.transform.root.gameObject.GetComponent<FixedJoint2D>().connectedBody = coll.gameObject.GetComponent<Rigidbody2D>();
                    }*/
                    attached = true;
                }
            }
        }

    }
}
