using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour {


    public int SpeedMovement;
    public float MaxSpeed;
    public Rigidbody RigiPlayer;
    public Transform Camera;

    // Use this for initialization
    void Start () {
        RigiPlayer = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (RigiPlayer.velocity.magnitude < MaxSpeed)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
            }
            if (Input.GetKey(KeyCode.Q))
            {
                transform.eulerAngles = new Vector3(0, -90, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.eulerAngles = new Vector3(0, 90, 0);
            }

            if (Input.GetKey(KeyCode.Z) && Input.GetKey(KeyCode.Q))
            {
                transform.eulerAngles = new Vector3(0, -45, 0);
            }
            if (Input.GetKey(KeyCode.Z) && Input.GetKey(KeyCode.D))
            {
                transform.eulerAngles = new Vector3(0, 45, 0);
            }
            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.Q))
            {
                transform.eulerAngles = new Vector3(0, 225, 0);
            }
            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            {
                transform.eulerAngles = new Vector3(0, 135, 0);
            }
            Camera.eulerAngles = new Vector3(90, 0, 0);
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.S))
            {
                RigiPlayer.AddForce(transform.forward * SpeedMovement);
            }
        }
    }
}
