using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    public static int capturados = 0;
    TextMeshProUGUI textoCapturados;
    public GameObject endgame;
    
    // Start is called before the first frame update
    void Start()
    {
        textoCapturados = GetComponent<TextMeshProUGUI> ();
        textoCapturados.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        textoCapturados.text = "Capturados: " + capturados + "/6";
        if(capturados == 6)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            endgame.SetActive(true);
            textoCapturados.enabled = false;
        }
    }
}
