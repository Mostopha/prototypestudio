﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {
    private float health, maxHealth;
    public Image healthBar;

    public float Health { get { return health; } }

	// Use this for initialization
	void Start () {
        health = 100;
        maxHealth = 100;
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0) {
            Destroy(this.gameObject);
        }
	}

    public void Hit(float damage) {
        health -= damage;
        healthBar.fillAmount = (float)health / (float)maxHealth;
    }
}
