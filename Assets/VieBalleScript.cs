using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VieBalleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 4);
	}
	

	// Update is called once per frame
	private void OnCollisionEnter (Collision collider) {
        
        if(collider.gameObject.GetComponent<LifeScripte>())
        {
            collider.gameObject.GetComponent<LifeScripte>().Dammage(5);
        }

        Destroy(gameObject);
	}
}
