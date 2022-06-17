using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndGame : MonoBehaviour
{
    void Start()
    {
        // CanvasObject = GetComponent<CanvasObject> ();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Score.capturados);
        if(Score.capturados == 6){
            Debug.Log("lalal");
            // CanvasObject.SetActive(true);
        }
    }
}
