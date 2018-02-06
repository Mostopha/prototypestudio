using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text myText;
    public GameObject gameManager;
    public int score;


	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("GameManager");

        
        
	}
	
	// Update is called once per frame
	void Update () {
        myText = this.GetComponent<Text>();
        score = gameManager.GetComponent<gameManagerScript>().score;
        myText.text = score.ToString();
    }
}
