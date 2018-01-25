using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour {

    public LayerMask layerMasque;

    public float speed;
    public float jumpAmount;
    public float glideAmount;
    public float fallspeed;

    public KeyCode downKey = KeyCode.S;
    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;
    public KeyCode jumpKey = KeyCode.Space;

    public float dist;
    public Vector3 dir;
    private RaycastHit2D hit;


    public Rigidbody2D rb;
   // public Rigidbody2D rocket;

    public bool onGround = false;
    private GameObject wings;
    public bool isGliding;

    // Use this for initialization
    void Start() {

        rb = this.GetComponent<Rigidbody2D>();
        wings = rb.transform.Find("Wings").gameObject;
        wings.SetActive(false);

        isGliding = false;

       

    }

    // Update is called once per frame
    void Update() {


       // Move(Vector3.down, downKey);
        Move(Vector3.left, leftKey);
        Move(Vector3.right, rightKey);
        Jump();

        hit = Physics2D.Raycast(transform.position, -Vector2.up, 1.2f,layerMasque);
        Debug.DrawRay(transform.position, -Vector2.up, Color.red, 10);

        if (hit.collider.tag == "Ground") {
            onGround = true;

        }

        if ((this.GetComponent<Rigidbody2D>().velocity.y < 1)&& onGround == false) {
            onGround = true;
        }
        

    }

    void Move(Vector3 dir, KeyCode key) {

        if (Input.GetKey(key)) {
            transform.Translate(dir * speed * Time.deltaTime);
        }

    }

    void Jump() {


        if (Input.GetKeyDown(jumpKey) && onGround == true) {
            rb.AddForce(Vector3.up * jumpAmount);
            onGround = false;
           // wings.SetActive(true);

        }
        else if(onGround==true){
            wings.SetActive(false);

        }
        else if (Input.GetKey(jumpKey) && onGround == false) {
            rb.gravityScale = glideAmount;
            wings.SetActive(true);
            isGliding = true;
        }

        else if (Input.GetKeyUp(jumpKey)) {
            rb.gravityScale = 1;
            wings.SetActive(false);
            isGliding = false;
        }




    }

  


   
    
}
