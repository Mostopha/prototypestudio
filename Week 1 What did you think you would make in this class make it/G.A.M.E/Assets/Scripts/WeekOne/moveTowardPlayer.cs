using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowardPlayer : MonoBehaviour {

    public Transform target;
    public float speed = 0.5f;

    // Use this for initialization
    void Start() {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update() {

        //Vector2.MoveTowards(transform.position, target.position, 10);

        //transform.position = Vector2.Lerp(transform.position, target.position, 0.5f);

        transform.position = Vector2.MoveTowards(transform.position, target.position, 0.1f);

    }
}
