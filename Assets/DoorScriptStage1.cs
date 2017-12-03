using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScriptStage1 : MonoBehaviour {

    public MeshRenderer Toit;
    public Transform Skeleton;
	// Use this for initialization
	void Start () {
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("collision !");



        if (other.tag == "Player")
        {
            GetComponent<MeshRenderer>().enabled = false;
            Toit.enabled = false;
            if (Skeleton != null)
            {
                Skeleton.GetComponent<TraqueScript1>().enabled = true;
            }
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
