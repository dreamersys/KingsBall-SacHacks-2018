using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
 
    public GameObject trialObject;
    public int BallReset = 0;

	// Use this for initialization
	void Start () {
        trialObject.SetActive(false);
	}
	
    public void ActivateTrial () {
        trialObject.SetActive(true);
    }

    public void Reset () {
        trialObject.SetActive(false);
        //Reset ball
        this.GetComponent<Rigidbody>().velocity = Vector3.zero;
        this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

    }

    private void Update() {
        if (BallReset == 1) {
            Reset();
            BallReset = 0;
        }
    }
}
