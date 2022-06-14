using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    public static int capturados = 0;
    TextMeshProUGUI textoCapturados;
    
    // Start is called before the first frame update
    void Start()
    {
        textoCapturados = GetComponent<TextMeshProUGUI> ();
    }

    // Update is called once per frame
    void Update()
    {
        textoCapturados.text = "Capturados: " + capturados + "/5";
    }
}
