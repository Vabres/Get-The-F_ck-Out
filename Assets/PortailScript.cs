using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortailScript : MonoBehaviour {

    public string NextLvl;
    public AsyncOperation loadNxtLvl;
    public GameObject PlsWait;
    public bool EndLvl = false;

    IEnumerator Go2NxtLvl ()
    {
        loadNxtLvl = SceneManager.LoadSceneAsync(NextLvl);

        while (!loadNxtLvl.isDone)
        {
            yield return null;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            EndLvl = true;
            PlsWait.SetActive(true);
            /*if (!loadNxtLvl.isDone)
            {
                PlsWait.SetActive(true);
            }*/
        }
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if(EndLvl && loadNxtLvl == null)
            StartCoroutine(Go2NxtLvl());
	}
}
