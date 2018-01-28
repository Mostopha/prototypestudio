using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordDamage : MonoBehaviour {
    private float speedMag;
    private float pierce;

    private float velocity;
    private Vector3 previous;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //speedMag = this.GetComponent<Rigidbody2D>().velocity.magnitude;

        velocity = ((transform.position - previous).magnitude) / Time.deltaTime;
        previous = transform.position;


        speedMag = velocity;

       pierce = this.transform.root.GetComponent<Rigidbody2D>().velocity.magnitude;
    }

    void OnCollisionEnter2D(Collision2D other) {
        float damageDealt = speedMag+pierce;

        other.gameObject.GetComponent<Enemy>().Hit(damageDealt);
        Debug.Log("Enemy has beenhit");
    }
}
