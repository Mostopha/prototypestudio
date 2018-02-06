using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueManager : MonoBehaviour {
    public bool canShowDialogue;
    public Text playerDialogue;
    public GameObject textParent;
    

	// Use this for initialization
	void Start () {
        textParent.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void playerQuote(string s) {
        textParent.SetActive(true);
        playerDialogue.text = s;

        Invoke("deactivateText", 2);
    }

    void deactivateText() {
        textParent.SetActive(false);
    }
}
