using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    public GameObject Panel;

    public void openPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }
}
