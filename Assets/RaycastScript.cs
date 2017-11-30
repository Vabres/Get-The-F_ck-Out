using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour {

    public Camera cam;
    public LineRenderer line;

	// Use this for initialization
	void Start () {
        cam = GetComponent<Camera>();
        line = GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
		if (Physics.Raycast(cam.transform.position, transform.forward , out hit))
        {
            Debug.Log(hit.transform.gameObject.name);

            Debug.DrawRay(cam.transform.position, transform.forward, Color.red);
            line.SetPosition(0, transform.position += new Vector3(0, +5, 0));
            line.SetPosition(1, hit.point);
        }
	}
}
