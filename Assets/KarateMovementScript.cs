using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarateMovementScript : MonoBehaviour {

    public int SpeedMovement;
    public float MaxSpeed;
    public int Tresor;
    public Rigidbody RigiKarate;

    // Use this for initialization
    void Start () {
        RigiKarate = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (RigiKarate.velocity.magnitude < MaxSpeed)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                RigiKarate.AddForce(transform.forward * SpeedMovement);
            }
            if (Input.GetKey(KeyCode.S))
            {
                RigiKarate.AddForce(-transform.forward * SpeedMovement);
            }
            if (Input.GetKey(KeyCode.Q))
            {
                RigiKarate.AddForce(-transform.right * SpeedMovement);
            }
            if (Input.GetKey(KeyCode.D))
            {
                RigiKarate.AddForce(transform.right * SpeedMovement);
            }
            if (Input.GetKeyUp(KeyCode.Z) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.Q))
            {

            }
        }
    }
}
