using System;
using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{

    public float ballTemperature = 20;
    public float startBallHighCm = 100;
    public float forcePush = 100;
    public Camera ballCamera;

    private Rigidbody rigidbody;
    public PhysicMaterial ballPhsysicMaterial;

	// Use this for initialization
	void Start ()
	{
        transform.position = new Vector3(transform.position.x, startBallHighCm, transform.position.z);
	    rigidbody = GetComponent<Rigidbody>();
	    ballPhsysicMaterial.bounciness = ballTemperature * 0.022f;
	}
	
	// Update is called once per frame
	void Update ()
	{

	    float currentPosX = this.transform.position.x;
        float currentPosy = this.transform.position.y;
        float currentPosz = this.transform.position.z;

        ballCamera.transform.position = new Vector3(currentPosX,currentPosy + 1.5f, currentPosz -100f);

	    if (Input.GetKeyDown(KeyCode.Space))
	    {
	        LaunchBall();
	    }
	}

    public void LaunchBall()
    {
        rigidbody.useGravity = true;
        rigidbody.velocity = new Vector3(0,444,forcePush);
    }
}
