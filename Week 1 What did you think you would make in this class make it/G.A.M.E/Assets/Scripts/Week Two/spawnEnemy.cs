using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour {
    public GameObject enemyGroup;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D coll) {
        enemyGroup.SetActive(true);
        Destroy(this.gameObject);
    }

}
