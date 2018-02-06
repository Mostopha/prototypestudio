using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueScript : MonoBehaviour {
    public dialogueManager dM;
    public string dialogue;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.transform.tag == "Player") {
            dM.playerQuote(dialogue);
            Destroy(this.gameObject);
        }
    }
}
