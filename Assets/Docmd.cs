using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Docmd : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void doPlay()
    {
        Debug.Log("doplay");
        SceneManager.LoadScene("0315(上傳版)");
    }

    public void exitPlay()
    {
        Debug.Log("doExit");
        Application.Quit();
    }
}
