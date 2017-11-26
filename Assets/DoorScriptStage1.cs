using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScriptStage1 : MonoBehaviour {

    public MeshRenderer Toit;
    public Transform Hound;
	// Use this for initialization
	void Start () {
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("collision !");

        if (Hound != null)
        {
            Hound.GetComponent<TraqueScript1>().enabled = true;
        }

        if (other.tag == "Player")
        {
            GetComponent<MeshRenderer>().enabled = false;
            Toit.enabled = false;
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
