using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour {

    public int numObjects = 10;
    public GameObject prefab;

    public int enemyNum =0;


    void Start() {
        /*Vector2 center = transform.position;
        for (int i = 0; i < numObjects; i++) {
            Vector2 pos = RandomCircle(center, 50.0f);
            Quaternion rot = Quaternion.FromToRotation(Vector2.left, center - pos);
            Instantiate(prefab, pos, rot);
        }*/

        InvokeRepeating("spawn", 0, 10);
    }

    Vector3 RandomCircle(Vector2 center, float radius) {
        float ang = Random.value * 360;
        Vector2 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        
        return pos;
    }

    void spawn() {
       

            Vector2 center = transform.position;
            for (int i = 0; i < numObjects; i++) {
                Vector2 pos = RandomCircle(center, 50.0f);
                Quaternion rot = Quaternion.FromToRotation(Vector2.left, center - pos);
                Instantiate(prefab, pos, rot);
            }

            
            numObjects=numObjects+5;

        }


    
}
