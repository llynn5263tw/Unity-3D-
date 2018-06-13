using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyNote : MonoBehaviour {

    public Image noteImage;

    /* bool a = false;
    private void OnMouseEnter()
    {
        a = true;
        
    }
    private void OnMouseExit()
    {
        a = false;
    }
    */

    void Update()
    {
        if (Input.GetKey("e") && noteImage.enabled == true)
        {
            Debug.Log(Input.GetMouseButtonDown(0));
            Debug.Log(noteImage.enabled);
            Destroy(gameObject);
        }
    }
}
