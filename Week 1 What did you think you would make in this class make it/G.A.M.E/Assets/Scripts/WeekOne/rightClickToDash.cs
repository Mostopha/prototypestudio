using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightClickToDash : MonoBehaviour {
    private bool isDashing;
    private float mag;
    public float windDashSpeed=200;

	// Use this for initialization
	void Start () {
        isDashing = false;
        
        
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(mag);

       if (isDashing == true) {
            mag = Mathf.Lerp(windDashSpeed, 1, 0.95f);
            
        }

        if (Input.GetMouseButtonDown(1)) {
            Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            Vector2 myPos = new Vector2(transform.position.x, transform.position.y + 1);
            Vector2 direction = target - myPos;
            direction.Normalize();

            isDashing = true;
          



           this.GetComponent<Rigidbody2D>().velocity = direction * mag;


            Invoke("dashEnd", 1);
            //Physics2D.GetIgnoreCollision(projectile.GetComponent<Collider2D>(), GetComponent<Collider2D>());


        }
       
    }

    void dashEnd() {
        isDashing = false;

    }

}
