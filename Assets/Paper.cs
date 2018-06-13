using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paper : MonoBehaviour
{
    int paper = 0;
    public Text countText;
    public Text winText;
    bool a = false;
    // Use this for initialization

    private void OnMouseEnter()
    {
        a = true;
    }
    private void OnMouseExit()
    {
        a = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e") == true && a == true)
        {
            paper++;
            Destroy(gameObject);
            countText.text = paper.ToString();
        }
    }
}
