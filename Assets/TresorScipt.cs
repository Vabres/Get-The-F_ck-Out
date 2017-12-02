using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TresorScipt : MonoBehaviour {

    public float VitRot, Amplitude, Vitesse;
    public Vector3 StartLoclPos;

	// Use this for initialization
	void Start () {
        StartLoclPos = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
        //transform.localRotation.eulerAngles() += new Vector3(0, 1 * VitRot, 0);
        //if (transform.localRotation.y == 360f)
        //{
        //    transform.localRotation.y = 0f; 
        //}
        transform.Rotate(Vector3.up * Time.deltaTime * VitRot);
        //Debug.Log(Mathf.Sin(Time.deltaTime));
        //Debug.Log(Time.deltaTime);
        transform.localPosition = StartLoclPos + new Vector3(0f, Mathf.Sin(Time.time * Vitesse) * Amplitude, 0f);
	}
}
