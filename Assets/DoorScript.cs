using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	public float Speed;
	public bool IsOpen = false;
    public Vector3 StartPostion;
    public Vector3 EndPosition;
    //public Color StColor, EndColor, CurrentColor;

    public float timer = 0;


	void OnTriggerEnter (Collider c) 
	{
        if (c.tag == "Player")
        {
            IsOpen = true;
            timer = 0;
        }
	}

	void OnTriggerStay (Collider c) 
	{

	}

	void OnTriggerExit (Collider c) 
	{
        if (c.tag == "Player")
        {
            IsOpen = false;
            timer = 1;
        }
	}

    void Update()
    {
        /*
        if (IsOpen)
            timer += Time.deltaTime;
        else
            timer -= Time.deltaTime;
        */
        //Debug.Log(Mathf.Lerp(0, 10, timer));
        //CurrentColor = Color.Lerp(StColor, EndColor, timer);
        transform.localPosition = Vector3.Lerp(StartPostion, EndPosition, (Mathf.Sin(Time.time) + 1)/2);
    }

}
