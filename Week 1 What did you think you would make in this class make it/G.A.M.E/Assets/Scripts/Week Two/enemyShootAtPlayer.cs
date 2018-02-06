using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShootAtPlayer : MonoBehaviour {

    public float bulletSpeed;
    public GameObject target;
    private Vector2 dir;
    public GameObject bulletPrefab;
    public float shotDelay=1;

    private Vector2 myPos;
    private Vector2 targetPos;

    private bool canShoot;
    private bool reloading;

    private GameObject shooterComponet;


    // Use this for initialization
    void Start () {
        myPos = new Vector2(transform.position.x, transform.position.y);
        canShoot = true;
        reloading = false;
        shooterComponet = transform.Find("shooter").gameObject;
        //shooterComponet = transform.Find("shooter").gameObject;


    }
	
	// Update is called once per frame
	void Update () {

        if (transform.childCount == 0) {
            Destroy(this.gameObject);
        }
        
        if (shooterComponet == null) {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D coll) {
        if (coll.transform.tag == "Player") {
            target = coll.gameObject;
            targetPos = new Vector2(coll.transform.position.x, coll.transform.position.y);
            Debug.Log("Target found");
            dir = targetPos - myPos;

            if (canShoot == true) {
                GameObject bullet = Instantiate(bulletPrefab, this.transform.position, Quaternion.identity);
              
                Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), shooterComponet.GetComponent<Collider2D>());
              
                

                bullet.GetComponent<Rigidbody2D>().AddForce(dir * bulletSpeed);
                canShoot = false;

                if(reloading == false) {
                    Invoke("Reload", shotDelay);
                    reloading = true;
                }
            }


        }


        

        

    }

    void Reload() {
        canShoot = true;
        reloading = false;

    }
}
