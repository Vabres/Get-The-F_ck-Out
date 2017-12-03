using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameScript : MonoBehaviour {

    public GameObject Canvas, Player, StartImage, StoryImage, StartCanvas;

	// Use this for initialization
	void Start () {
		
	}
	
    public void Histoire ()
    {
        StartImage.SetActive(false);
        StoryImage.SetActive(true);
    }

    public void Jeu ()
    {
        Canvas.SetActive(true);
        Player.SetActive(true);
        StartCanvas.SetActive(false);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
