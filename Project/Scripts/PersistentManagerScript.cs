using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersistentManagerScript : MonoBehaviour {

    public static PersistentManagerScript Instance { get; private set;  }

    public int CurrentScore = 0;
    public float Timer;

    private void Awake()
    {
        Timer = 40f;
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else 
        {
            Destroy(gameObject);
        }
    }

}
