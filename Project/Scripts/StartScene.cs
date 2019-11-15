using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour {
    public bool gameRunning = false;
    public GameManager gm;

    public void StartGame () {
        gameRunning = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Start Hey");
    }
}
