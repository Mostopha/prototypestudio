using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooterDie : MonoBehaviour {
    private Transform shooterParent;
    public enemyShootAtPlayer parentScript;
	// Use this for initialization
	void Start () {
        shooterParent = transform.parent;
        parentScript = shooterParent.GetComponent<enemyShootAtPlayer>();
	}
	
	// Update is called once per frame
	void Update () {

        
		
	}

   void OnCollisionEnter2D(Collision2D coll) {
        if (coll.transform.tag == "sword") {
            Destroy(this.gameObject);
            Destroy(this.transform.parent);

        }
    }


}
