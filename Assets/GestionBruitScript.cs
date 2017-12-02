using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GestionBruitScript : MonoBehaviour {

    public SphereCollider ZoneDeBruit;
    public float Diametre;
    public ParticleSystem Particles;

	// Use this for initialization
	void Start () {
        ZoneDeBruit = GetComponent<SphereCollider>();
	}


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Skeletons")
        {
            other.GetComponent<NavMeshAgent>().destination = transform.position;
        }
    }


    // Update is called once per frame
    void FixedUpdate () {
        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.D))
        {
            ZoneDeBruit.radius = Diametre;
            Particles.startSize = Diametre * 3;
            Particles.Play();

        }
        else
        {
            ZoneDeBruit.radius = 0.5f;
            Particles.Stop();
        }
    }
}
