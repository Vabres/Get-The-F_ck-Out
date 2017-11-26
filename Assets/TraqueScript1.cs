using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class TraqueScript1 : MonoBehaviour {

    public Transform[] RdmDestination;
    public NavMeshAgent cible;
    public int R;

	// Use this for initialization
	void Start () {
        //PositionHero = GetComponent<Transform>();
        cible = GetComponent<NavMeshAgent>();
        cible.destination = RdmDestination[R].localPosition;
    }


	
	// Update is called once per frame
	void Update () {
        if (cible.remainingDistance < 4)
        {
            R = Random.Range(0, RdmDestination.Length);
            cible.destination = RdmDestination[R].position;
        }

    }
}
