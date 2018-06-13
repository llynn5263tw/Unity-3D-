using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Player_PickUp : MonoBehaviour
{
    int paper;
    public Text countText;
    public Text winText;


    public AudioClip pickupSound;

    void Start()
    {
        paper = 0;
        winText.text = "";
    }
    void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Paper" && Input.GetKey("e") == true)
        {
            paper++;
            Debug.Log(gameObject.tag);
            Debug.Log(Input.GetMouseButtonDown(0));
            //GetComponent<AudioSource>().PlayOneShot(pickupSound);
            Destroy(gameObject);
            countText.text = paper.ToString();
          
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