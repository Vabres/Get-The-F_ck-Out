using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTirSrcipt : MonoBehaviour {

    public Transform BulletStartPosition1, BulletStartPosition2;
    public GameObject PrefabBullet;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0))
        {
            GameObject Bullet = Instantiate<GameObject>(PrefabBullet);
            Bullet.transform.position = BulletStartPosition1.position;
            Bullet.GetComponent<Rigidbody>().AddForce(BulletStartPosition1.forward * 1000);
        }
        if (Input.GetMouseButtonDown(1))
        {
            GameObject Bullet = Instantiate<GameObject>(PrefabBullet);
            Bullet.transform.position = BulletStartPosition2.position;
            Bullet.GetComponent<Rigidbody>().AddForce(BulletStartPosition2.forward * 1000);
        }
    }
}
