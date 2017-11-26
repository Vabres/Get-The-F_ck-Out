using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuiveurScript : MonoBehaviour {

    public Transform CibleTransform;



	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        //timer += Time.deltaTime;

        //Depart = transform.localPosition;
        transform.localPosition = Vector3.Lerp(
            transform.localPosition,
            CibleTransform.localPosition, 
            0.1f);

    }
}
