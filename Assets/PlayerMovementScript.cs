using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovementScript : MonoBehaviour {


    public int SpeedMovement;
    public float MaxSpeed, FacteurPoids, FacteurSon;
    public Rigidbody RigiPlayer;
    public Transform Camera;
    public int NbTresors;
    public GameObject ToucheE;
    public GestionBruitScript Cube;
    public Text Score;

    // Use this for initialization
    void Start () {
        RigiPlayer = GetComponent<Rigidbody>();
        NbTresors = PlayerPrefs.GetInt("Tresors", 0);
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
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.forward, out hit);
        if (hit.transform.gameObject.tag == "Tresor" && hit.distance < 5)
        {
            ToucheE.SetActive(true);
            //Debug.Log(hit.transform.tag);
            if (Input.GetKeyDown(KeyCode.E))
            {
                NbTresors += 1;
                hit.transform.gameObject.SetActive(false);
                Cube.Diametre += FacteurSon ;
                Score.text = NbTresors + "0 000 $";
            }
        }
        else
        {
            ToucheE.SetActive(false);

        }
        //Debug.DrawRay(transform.position, transform.forward * 20, Color.red);

        RigiPlayer.mass = 1 + NbTresors * FacteurPoids;


    }
}
