using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour {
    int paper = 0;
    int paperToWin = 4;
    public Text countText;
    public Text winText;
    float distanceToPaper = 1.5f;
    Ray ray;
    RaycastHit hit;
    Vector3 v3 = new Vector3(Screen.width * 0.1f, Screen.height * 0.1f, 0.0f);
    Vector3 hitpoint = Vector3.zero;


    // Use this for initialization
    void Start () {
        countText.text = paper.ToString();
        winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {

        ray = Camera.main.ScreenPointToRay(v3);
        if(Physics.Raycast( ray, out hit, distanceToPaper))
        {
            if( hit.collider.gameObject.name == "Note1")
            {
                paper+=1;
                countText.text = paper.ToString();
                Destroy(hit.collider.gameObject);

                if (paper == paperToWin)
                {
                    winText.text = "You win!";
                }
            }
        }
	}
}
