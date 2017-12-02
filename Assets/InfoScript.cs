using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoScript : MonoBehaviour
{


    //public string Difficulty;
    //public int CurrentLife;
    public int Score;
    // Use this for initialization


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        PlayerPrefs.SetInt("Tresor", Score); //sert à sauvegarder entre chaque lancement du jeu
    }

    // Update is called once per frame
    void Update()
    {

    }
}
