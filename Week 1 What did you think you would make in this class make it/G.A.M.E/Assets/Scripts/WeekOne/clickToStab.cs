using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToStab : MonoBehaviour {
    public GameObject stab;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetButton("Fire1")) {
            stab.SetActive(true);
        }
        else { stab.SetActive(false); }
    }
}
