using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour {

    public GameController gamecontroller;
    public GameObject effectObject;
    public GameObject textObject;

    public int scored = 0;
    public int ScoreAreaReset = 0;

    private void Start() {
        effectObject.SetActive(false);
        textObject.SetActive(false);
    }

    void OnTriggerEnter(Collider otherCollider) {
        if (otherCollider.GetComponent<Ball>() != null) {
            scored = 1;
            effectObject.SetActive(true);
            textObject.SetActive(true);
        }
    }

    private void Update() {
        if (ScoreAreaReset == 1) {
            Reset();
            ScoreAreaReset = 0;
        }
    }
    public void Reset() {
        effectObject.SetActive(false);
        textObject.SetActive(false);

    }

}
