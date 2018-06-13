using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{

    public int Paper = 0;
    public int paperToWin = 30;
    public Image noteImage;
    public AudioClip pickupSound;
    public Text countText;
    public Text winText;


    bool a = false;


    private void Start()
    {
        noteImage.enabled = false;
        countText.text = "Paper："+ Paper.ToString();
        winText.text = "";
    }
    private void OnMouseEnter()
    {
        a = true;
    }
    private void OnMouseExit()
    {
        a = false;
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) == true && a == true)
        {
            Paper++;
            Destroy(gameObject);
            GetComponent<AudioSource>().PlayOneShot(pickupSound);
            noteImage.enabled = true;
            countText.text = "Paper：" + Paper.ToString();

            if (Paper == 5)
            {
                winText.text = "YOU WIN!";
            }
        }
    }

    /*private void OnGUI()
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