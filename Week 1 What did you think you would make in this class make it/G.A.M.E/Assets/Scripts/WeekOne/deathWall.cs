using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathWall : MonoBehaviour {
    public GameObject deathPanel;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Player") {
           //coll.gameObject.SetActive(false);

            Destroy(coll.gameObject);
            Invoke("restartScene", 2);
            
        }

    }

    void restartScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
