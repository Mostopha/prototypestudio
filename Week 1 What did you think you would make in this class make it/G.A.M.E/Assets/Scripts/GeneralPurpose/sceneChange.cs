using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour {

    public void changeScene(string nextScene) {
        GameObject.Find("GameManager").GetComponent<pause>().paused=false;
        Time.timeScale = 1f;
        string sceneText = nextScene;
        
        SceneManager.LoadScene(sceneText);

        
    }
}
