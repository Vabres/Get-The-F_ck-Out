using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HorseScript : LifeScripte {

    public Transform Destination;
    public bool WalkRun = false;

	// Use this for initialization
	void Start () {
        GetComponent<Animator>().SetInteger("Pv", Pv);

    }

    public override void Dammage(int c)
    {
        base.Dammage(c);
        GetComponent<Animator>().SetInteger("Pv", Pv);

        // Mort du cheval
        if (Pv == 0)
        {
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<NavMeshAgent>().enabled = false;
            GetComponent<Animator>().enabled = false;
            transform.eulerAngles += new Vector3(0, 0, 90);
            Destroy(this); //destruction de cette instance du script

        }
    }

    // Update is called once per frame
    void Update () {
        
        GetComponent<NavMeshAgent>().destination = Destination.position;

        if(GetComponent<NavMeshAgent>().remainingDistance <= 4)
        {
            WalkRun = false;
        }
        if (GetComponent<NavMeshAgent>().remainingDistance > 4)
        {
            WalkRun = true;

        }
        GetComponent<Animator>().SetBool("WalkRun", WalkRun);
    }
}
