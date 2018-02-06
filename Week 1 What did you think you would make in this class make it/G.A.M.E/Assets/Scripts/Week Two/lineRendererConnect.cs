using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineRendererConnect : MonoBehaviour {
    public GameObject target1;
    public GameObject target2;

    private Vector3 target1Pos;
    private Vector3 target2Pos;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        target1Pos = target1.transform.position;
        target2Pos = target2.transform.position;

        this.GetComponent<LineRenderer>().SetPosition(1, target1Pos);
        this.GetComponent<LineRenderer>().SetPosition(2, target2Pos);


        //test code
    }
}
