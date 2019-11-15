using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Ball ball;
    public GameObject playerCamera;

    public float ballDistance = 2f;
    public float ballThrowingForce = 500f;
    public int PlayerReset = 0;
    public bool holdingBall = true;


    public Vector3 pos1, pos2, pos3, pos4, pos5;
    public Vector3[] posList = new Vector3[5];

    // Use this for initialization
    void Start () {
        ball.GetComponent<Rigidbody>().useGravity = false;
        SetPositionList(ref posList);

       
	}
	
	// Update is called once per frame
	void Update () {
        if (holdingBall) {
            ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;
            if (Input.GetMouseButton(0)) {
                ballThrowingForce += Time.deltaTime * 10;
            }
            if (Input.GetMouseButtonUp(0)) {
                holdingBall = false;
                ball.ActivateTrial();
                ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);
            }
        }
        if(PlayerReset == 1) {
            Reset();
            PlayerReset = 0;
        }
    }

    public void Reset() {
        ballThrowingForce = 500f;
        holdingBall = true;
        ball.GetComponent<Rigidbody>().useGravity = false;
    }

    void SetPosition(ref Vector3 p, float x, float y, float z){
        p.x = x;
        p.y = y;
        p.z = z;
    }

    void SetPositionList(ref Vector3[] p_list){

        SetPosition(ref pos1, -0.06f, 1.48f, -2f);
        SetPosition(ref pos2, 3.1623f, 1.48f, -2f);
        SetPosition(ref pos3, -3.193042f, 1.48f, -2f);
        SetPosition(ref pos4, 3.237f, 1.48f, 1.6027f);
        SetPosition(ref pos5, -3.1801f, 1.48f, 1.6027f);

        p_list[0] = pos1;
        p_list[1] = pos2;
        p_list[2] = pos3;
        p_list[3] = pos4;
        p_list[4] = pos5;
    }

}
