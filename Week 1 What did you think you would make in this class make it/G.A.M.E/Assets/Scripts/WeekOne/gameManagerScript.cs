using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManagerScript : MonoBehaviour {

    public int score=0;
    public Text scoresText;
    public GameObject player;
    public GameObject deathPanel;
  
   

	// Use this for initialization
	void Start () {
        deathPanel.SetActive(false);
        
	}
	
	// Update is called once per frame
	void Update () {
        scoresText.text = score.ToString();
        if (player == null) {
            deathPanel.SetActive(true);
        }
		
	}
}
