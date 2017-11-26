using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerMovement : MonoBehaviour
{

    public int SpeedMovement, SpeedTurn;
    public float MaxSpeed;
    public Transform Cube;
    public Rigidbody RigiCube;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GetComponent<Rigidbody>().velocity.magnitude < MaxSpeed)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                RigiCube.AddForce(transform.forward * SpeedMovement);
            }
            if (Input.GetKey(KeyCode.S))
            {
                RigiCube.AddForce(-transform.forward * SpeedMovement);
            }
            if (Input.GetKey(KeyCode.Q))
            {
                Cube.eulerAngles += new Vector3(0, -1, 0) * SpeedTurn;
            }
            if (Input.GetKey(KeyCode.D))
            {
                Cube.eulerAngles += new Vector3(0, 1, 0) * SpeedTurn;
            }
        }
    }
}