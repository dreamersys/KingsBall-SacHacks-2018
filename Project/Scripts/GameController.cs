using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public Player player;
    public Ball ball;
    public ScoreArea scorearea;
    public float resetTimer = 3f;
    public bool running = false;
    public int positionCounter = 1;
    public bool startedscene = false;

	// Use this for initialization
	void Start () {
        running = true;
        startedscene = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (player.holdingBall == false) {
            resetTimer -= Time.deltaTime;
            if (resetTimer <= 0)
            {
                if (scorearea.scored == 1)
                {
                    positionCounter++;
                    PersistentManagerScript.Instance.CurrentScore++;

                    if (positionCounter == 6) {
                        startedscene = false;
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    }
                    if (positionCounter == 1)
                    {
                        player.transform.position = player.posList[0];
                    }
                    else if (positionCounter == 2)
                    {
                        player.transform.position = player.posList[1];
                    }
                    else if (positionCounter == 3)
                    {
                        player.transform.position = player.posList[2];
                    }
                    else if (positionCounter == 4)
                    {
                        player.transform.position = player.posList[3];
                    }
                    else if (positionCounter == 5)
                    {
                        player.transform.position = player.posList[4];
                    }
                }
                player.PlayerReset = 1;
                ball.BallReset = 1;
                scorearea.ScoreAreaReset = 1;
                resetTimer = 3f;
                scorearea.scored = 0;
            }
        }
        if (startedscene == true)
        {
            if (PersistentManagerScript.Instance.Timer > 0f)
            {
                PersistentManagerScript.Instance.Timer -= Time.deltaTime;
                Debug.Log(PersistentManagerScript.Instance.Timer);
            }
            if (PersistentManagerScript.Instance.Timer <= 0f)
            {
                SceneManager.LoadScene("EndScene");
            }
        }
	}
}
