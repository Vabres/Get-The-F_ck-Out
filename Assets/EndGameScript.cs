using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGameScript : MonoBehaviour {

    public GameObject PlayCanvas, EndGameCanvas;
    public Text ScoreText1, ScoreText2;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayCanvas.SetActive(false);
            EndGameCanvas.SetActive(true);
            other.GetComponent<PlayerMovementScript>().enabled = false;
            ScoreText2.text += ScoreText1.text;
        }
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
}
