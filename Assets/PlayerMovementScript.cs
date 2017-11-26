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
                Camera.eulerAngles = new Vector3(90, 0, 0);
                RigiPlayer.AddForce(transform.forward * SpeedMovement);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                Camera.eulerAngles = new Vector3(90, 0, 0);
                RigiPlayer.AddForce(transform.forward * SpeedMovement);
            }
            if (Input.GetKey(KeyCode.Q))
            {
                transform.eulerAngles = new Vector3(0, -90, 0);
                Camera.eulerAngles = new Vector3(90, 0, 0);
                RigiPlayer.AddForce(transform.forward * SpeedMovement);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.eulerAngles = new Vector3(0, 90, 0);
                Camera.eulerAngles = new Vector3(90, 0, 0);
                RigiPlayer.AddForce(transform.forward * SpeedMovement);
            }
        }
    }
}
