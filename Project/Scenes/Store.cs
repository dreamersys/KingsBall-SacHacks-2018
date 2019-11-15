using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Store : MonoBehaviour
{

    public void ReturnFunction()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void endFunction() {
        Application.Quit();
    }
}
