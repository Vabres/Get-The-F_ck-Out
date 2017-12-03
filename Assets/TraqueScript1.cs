using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class TraqueScript1 : MonoBehaviour {

    public Transform[] RdmDestination;
    public NavMeshAgent Cible;
    public int R;
    public bool Attack = false, IsWalking = false;
    public Rigidbody RigiSkeleton;
    public Animator AniSkeleton;
    public float Distance;


	// Use this for initialization
	void Start () {
        //PositionHero = GetComponent<Transform>();
        Cible = GetComponent<NavMeshAgent>();
        RigiSkeleton = GetComponent<Rigidbody>();
        AniSkeleton = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Attack = true;
            other.GetComponent<PlayerMovementScript>().TextGameOver.SetActive(true);
            other.GetComponent<PlayerMovementScript>().enabled = false;
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            other.GetComponent<CapsuleCollider>().enabled = false;
            AniSkeleton.SetTrigger("Attack");
            other.GetComponent<Transform>().GetChild(0).GetComponent<GestionBruitScript>().enabled = false;
            R = Random.Range(0, RdmDestination.Length);
            Cible.destination = RdmDestination[R].position;
        }

    }

    void GetRandomPosition() //Sert à trouver un point au hasard sur le NavMesh
    {
        Vector3 randomDirection = Random.insideUnitSphere * Distance;
        randomDirection += transform.position;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomDirection, out hit, Distance, 1);
        Vector3 finalPosition = hit.position;
        GetComponent<NavMeshAgent>().destination = finalPosition;

    }

    // Update is called once per frame
    void Update () {
        if (Cible.remainingDistance < 2)
        {
            R = Random.Range(0, RdmDestination.Length);
            Cible.destination = RdmDestination[R].position;
        }

        if (RigiSkeleton.velocity.magnitude > 2)
        {
            IsWalking = true;
        }
        else
        {
            IsWalking = false;
        }
        AniSkeleton.SetBool("IsWalking", IsWalking);

       /* if (Cible.remainingDistance < 2)
        {
            GetRandomPosition();
        }*/
    }
}
