using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeScripte : MonoBehaviour {

    public  int Pv;

	// Use this for initialization
	void Start () {
		
	}
	
    public virtual void Dammage(int c)
    {
        Pv -= c;
    }



	// Update is called once per frame
	void Update () {
		
	}
}
