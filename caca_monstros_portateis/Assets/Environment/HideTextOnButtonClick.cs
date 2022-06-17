using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTextOnButtonClick : MonoBehaviour
{

    public void onClickButtonYes()
    {
        Score.capturados += 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

        public void onClickButtonNo()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
