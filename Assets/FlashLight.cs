using UnityEngine;
using System.Collections;

public class FlashLight : MonoBehaviour
{

    public new Light light;    //assign gameobject with light component attached

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {      //Left mouse button
            light.enabled = !light.enabled;      //changes light on/off
        }
    }
}