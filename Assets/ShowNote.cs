using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class ShowNote: MonoBehaviour
{

    //int paper;
    //public Text countText;
    //public Text winText;
    public Image noteImage;
    public AudioClip pickupSound;

    void Start()
    {
        //countText.text = paper.ToString();
        //winText.text = "";
        noteImage.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        //paper = Convert.ToInt32(countText);
        if (other.gameObject.tag == "Player")
        {
            
            GetComponent<AudioSource>().PlayOneShot(pickupSound);
            noteImage.enabled = true;
            Destroy(gameObject);
            if(noteImage.enabled == true)
            {
                //paper++;
                //countText.text = paper.ToString();

                /*if (paper == 4)
                {
                    winText.text = "YOU WIN!";
                }*/
            }
        }
        
        
    }

    /*private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && noteImage.enabled == true)
           {
            Debug.Log(Input.GetMouseButtonDown(0));
                noteImage.enabled = false;
           }
    }*/

    /*void OnGUI()
    {
        if (Paper < paperToWin)
        {
            GUI.Box(new Rect((Screen.width / 2) - 100, 10, 200, 35), "" + Paper + " Papers");
        }
        else
        {
            GUI.Box(new Rect((Screen.width / 2) - 100, 10, 200, 35), "All Papers Collected!");
        }
    }*/
}
