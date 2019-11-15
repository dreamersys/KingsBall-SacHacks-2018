using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System;
using UnityEngine.UI;

public class EndScene : MonoBehaviour
{
    public GameManager gm;
    public Text idText;
    public Text scoreText;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Debug.Log("End Hey");
        gm.Everything();
        idText.text = "ID: " + gm.UserID;
        scoreText.text = "Score: " + PersistentManagerScript.Instance.CurrentScore;

    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void EndGame()
    {
        Application.Quit();
    }

}



