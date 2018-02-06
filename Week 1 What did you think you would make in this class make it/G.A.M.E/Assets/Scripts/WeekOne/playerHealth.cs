using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {
    public float health;
    public Text playerHealthText;
    

	// Use this for initialization
	void Start () {
        health = 100;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (health < 0) {
            Destroy(this.transform.root.gameObject);
        }

        playerHealthText.text = health.ToString();
	}

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.transform.tag == "bullet") {
            health -= 10;

            Destroy(coll.gameObject);
        }

        
    }
}
